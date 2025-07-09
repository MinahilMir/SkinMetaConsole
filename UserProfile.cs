using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinMetaConsole
{
    public partial class UserProfile : Form
    {
        private SqlConnection con = DatabaseHelper.GetConnection();
        private int currentUserID;
        UserProfile User;
        private string currentUserEmail;
        public UserProfile()
        {
            InitializeComponent();
        }
        public UserProfile(int userID, string email)
        {
            InitializeComponent();
            currentUserID = userID;
            LoadUserProfileDetails();
            currentUserEmail = email;
        }
        public int GetUserId()
        {
            return currentUserID;
        }

        public void LoadUserProfileDetails()
        {
            try
            {
                // Open connection
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Load Basic User Information
                string userQuery = @"
            SELECT Name, Age, City, Email 
            FROM Users 
            WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(userQuery, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUserID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Set basic user info labels
                            UserName.Text = reader["Name"].ToString();
                            Age.Text = reader["Age"].ToString();
                            City.Text = reader["City"].ToString();
                            Email.Text = reader["Email"].ToString();
                        }
                    }
                }

                // Load User Responses
                LoadUserResponses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public void LoadUserResponses()
        {
            try
            {
                // Ensure connection is open
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string responsesQuery = @"
            SELECT 
                q.QuestionText, 
                a.AnswerText
            FROM UserResponses ur
            JOIN Questions q ON ur.QuestionID = q.QuestionID
            JOIN Answers a ON ur.AnswerID = a.AnswerID
            WHERE ur.UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(responsesQuery, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUserID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Dictionary mapping specific questions to labels
                        var responseMappings = new Dictionary<string, Label>
                {
                    {"How often do you experience breakouts?", BreakoutFrequency},
                    {"What type of acne do you usually get?", AcneType},
                    {"Do breakouts flare up due to stress and hormones?", SandH},
                    {"What are your main skin concerns?", Concerns},
                    {"Any goals for your skincare routine?", Goals},
                    {"Do you have dark circles under your eyes?", DarkCircles},
                    {"How does your skin feel after washing?", SkinafterWash},
                    {"Does your skin react to new products?", prodReaction},
                    {"Do you experience redness, itching or irritation?", redness},
                    {"Are you sensitive to fragranced products?", FprodReaction},
                    {"How would you describe your Skin Type?", SkinType},
                    {"How would you describe your skin texture?", SkinTexture}
                };

                        while (reader.Read())
                        {
                            string questionText = reader["QuestionText"].ToString();
                            string answerText = reader["AnswerText"].ToString();

                            // Check if this question is mapped to a label
                            if (responseMappings.ContainsKey(questionText))
                            {
                                responseMappings[questionText].Text = answerText;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user responses: {ex.Message}",
                    "Responses Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        // Other existing methods remain the same...

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            guna2Panel1.AutoRoundedCorners = true;
            guna2Panel1.BorderRadius = 50; // Adjust this value
            guna2Panel1.BorderThickness = 0; // Optional for border visibility
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            Control panel = sender as Control;
            using (Pen pen = new Pen(Color.Black, 0)) // Black border, 2px thickness
            {
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            }
        }

        private void AcneType_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            productCatalog Products = new productCatalog();
            Products.Show();
            this.Hide();
        }

        private void RoutineButton_Click(object sender, EventArgs e)
        {
            routine UserRoutine = new routine();
            UserRoutine.Show();
            this.Hide();
        }

        private void AnalysisButton_Click(object sender, EventArgs e)
        {
            Tracker UserAnalysis = new Tracker();
            UserAnalysis.Show();
            this.Hide();
        }

        private void DiaryButton_Click(object sender, EventArgs e)
        {
            SkinDiary UserDiary = new SkinDiary(currentUserID);
            UserDiary.Show();
            this.Hide();
        }

        private void Recommend_Click(object sender, EventArgs e)
        {
            Recommendation Recommend = new Recommendation();
            Recommend.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings UserSettings = new Settings(currentUserID, currentUserEmail, this);
            if (UserSettings.ShowDialog() == DialogResult.OK)
            {
                // Reload data after settings form is closed
                LoadUserProfileDetails();
            }
        }
    }
}