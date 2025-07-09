using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinMetaConsole
{
    public partial class QuestionareSkinType : Form
    {
        private SqlConnection con = DatabaseHelper.GetConnection();
        private int currentUserID;
        private int categoryID;
        private Dictionary<int, Guna.UI2.WinForms.Guna2RadioButton> selectedAnswers = new Dictionary<int, Guna.UI2.WinForms.Guna2RadioButton>();

        public QuestionareSkinType()
        {
            InitializeComponent();
        }

        public QuestionareSkinType(int userID, int catID)
        {
            InitializeComponent();
            currentUserID = userID;
            categoryID = catID;
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Fetch questions for the selected category
                string questionsQuery = @"
                    SELECT q.QuestionID, q.QuestionText
                    FROM Questions q
                    WHERE q.CategoryID = @CategoryID
                    ORDER BY q.QuestionID";

                using (SqlCommand cmd = new SqlCommand(questionsQuery, con))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    DataTable questionsTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(questionsTable);
                    }

                    // Create dynamic UI elements for each question
                    int yPosition = 20;
                    foreach (DataRow questionRow in questionsTable.Rows)
                    {
                        int questionID = Convert.ToInt32(questionRow["QuestionID"]);
                        string questionText = questionRow["QuestionText"].ToString();

                        // Create question label
                        Label questionLabel = new Label
                        {
                            Text = questionText,
                            Location = new Point(20, yPosition),
                            AutoSize = true,
                            Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                        };
                        this.Controls.Add(questionLabel);

                        yPosition += 30;

                        // Load answers for this question
                        string answersQuery = @"
                            SELECT a.AnswerID, a.AnswerText,
                            (SELECT TOP 1 ur.AnswerID FROM UserResponses ur 
                             WHERE ur.UserID = @UserID AND ur.QuestionID = @QuestionID) AS UserAnswerID
                            FROM Answers a
                            WHERE a.QuestionID = @QuestionID
                            ORDER BY a.AnswerID";

                        using (SqlCommand answerCmd = new SqlCommand(answersQuery, con))
                        {
                            answerCmd.Parameters.AddWithValue("@UserID", currentUserID);
                            answerCmd.Parameters.AddWithValue("@QuestionID", questionID);
                            DataTable answersTable = new DataTable();
                            using (SqlDataAdapter answerAdapter = new SqlDataAdapter(answerCmd))
                            {
                                answerAdapter.Fill(answersTable);
                            }

                            // Get the user's previously selected answer (if any)
                            int? userAnswerID = null;
                            if (answersTable.Rows.Count > 0 && answersTable.Rows[0]["UserAnswerID"] != DBNull.Value)
                            {
                                userAnswerID = Convert.ToInt32(answersTable.Rows[0]["UserAnswerID"]);
                            }

                            // Create radio buttons for each answer
                            int xPosition = 50;
                            foreach (DataRow answerRow in answersTable.Rows)
                            {
                                int answerID = Convert.ToInt32(answerRow["AnswerID"]);
                                string answerText = answerRow["AnswerText"].ToString();

                                Guna.UI2.WinForms.Guna2RadioButton radioButton = new Guna.UI2.WinForms.Guna2RadioButton
                                {
                                    Text = answerText,
                                    Location = new Point(xPosition, yPosition),
                                    Tag = new AnswerData { QuestionID = questionID, AnswerID = answerID },
                                    AutoSize = true
                                };

                                // Check if this was the user's previous answer
                                if (userAnswerID.HasValue && userAnswerID.Value == answerID)
                                {
                                    radioButton.Checked = true;
                                    // Store the initially selected answer
                                    selectedAnswers[questionID] = radioButton;
                                }

                                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                                this.Controls.Add(radioButton);
                                xPosition += 150;
                            }
                        }

                        yPosition += 50; // Space for the next question
                    }

                    // Add Submit button at the bottom
                    Guna.UI2.WinForms.Guna2Button submitButton = new Guna.UI2.WinForms.Guna2Button
                    {
                        Text = "Submit",
                        Location = new Point(250, yPosition + 20),
                        Size = new Size(100, 40),
                        FillColor = Color.FromArgb(255, 128, 128)
                    };
                    submitButton.Click += SubmitButton_Click;
                    this.Controls.Add(submitButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading questions: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2RadioButton rb = sender as Guna.UI2.WinForms.Guna2RadioButton;
            if (rb != null && rb.Checked)
            {
                AnswerData data = (AnswerData)rb.Tag;
                selectedAnswers[data.QuestionID] = rb;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the user has answered all questions
                if (selectedAnswers.Count == 0)
                {
                    MessageBox.Show("Please answer at least one question.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (var answer in selectedAnswers)
                            {
                                int questionID = answer.Key;
                                AnswerData data = (AnswerData)answer.Value.Tag;

                                // Check if a response already exists
                                string checkQuery = @"
                            SELECT ResponseID FROM UserResponses 
                            WHERE UserID = @UserID AND QuestionID = @QuestionID";

                                SqlCommand checkCmd = new SqlCommand(checkQuery, connection, transaction);
                                checkCmd.Parameters.AddWithValue("@UserID", currentUserID);
                                checkCmd.Parameters.AddWithValue("@QuestionID", questionID);
                                object existingResponseID = checkCmd.ExecuteScalar();

                                if (existingResponseID != null)
                                {
                                    // Update existing response
                                    string updateQuery = @"
                                UPDATE UserResponses
                                SET AnswerID = @AnswerID
                                WHERE UserID = @UserID AND QuestionID = @QuestionID";

                                    SqlCommand updateCmd = new SqlCommand(updateQuery, connection, transaction);
                                    updateCmd.Parameters.AddWithValue("@AnswerID", data.AnswerID);
                                    updateCmd.Parameters.AddWithValue("@UserID", currentUserID);
                                    updateCmd.Parameters.AddWithValue("@QuestionID", questionID);
                                    updateCmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    // Insert new response
                                    string insertQuery = @"
                                INSERT INTO UserResponses (UserID, QuestionID, AnswerID, CategoryID)
                                VALUES (@UserID, @QuestionID, @AnswerID, @CategoryID)";

                                    SqlCommand insertCmd = new SqlCommand(insertQuery, connection, transaction);
                                    insertCmd.Parameters.AddWithValue("@UserID", currentUserID);
                                    insertCmd.Parameters.AddWithValue("@QuestionID", questionID);
                                    insertCmd.Parameters.AddWithValue("@AnswerID", data.AnswerID);
                                    insertCmd.Parameters.AddWithValue("@CategoryID", categoryID);
                                    insertCmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Your responses have been updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Set dialog result to OK before closing
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Transaction failed: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving responses: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Helper class to store the question and answer IDs
        private class AnswerData
        {
            public int QuestionID { get; set; }
            public int AnswerID { get; set; }
        }
    }
}