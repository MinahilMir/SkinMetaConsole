using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SkinMetaConsole
{
    public partial class Settings : Form
    {
        private int currentUserID;
        private UserProfile parentProfile;
        private string currentUserEmail;
        // Dictionary to map category names to their respective IDs from the database
        private Dictionary<string, int> categoryMapping = new Dictionary<string, int>
        {
            { "Skin Type", 1 },
            { "Sensitivity", 2 },
            { "Acne", 3 },
            { "Concerns", 4 }
        };

        public Settings(int userID, string email, UserProfile parentForm = null)
        {
            InitializeComponent();
            currentUserID = userID;
            parentProfile = parentForm;
            currentUserEmail = email;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT Name, Age, City, Email FROM Users WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", currentUserID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Map database values to your form controls
                                UpdateUserName.Text = reader["Name"].ToString();
                                UpdateAge.Text = reader["Age"].ToString();
                                UpdateCity.Text = reader["City"].ToString();
                                UpdateEmail.Text = reader["Email"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenQuestionnaire(string categoryName)
        {
            try
            {
                // Get the current user ID from our static class
                int userID = currentUserID;

                // Check if we have a valid user ID
                if (userID <= 0)
                {
                    MessageBox.Show("You must be logged in to update your profile.",
                        "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Look up the category ID from the category name
                if (categoryMapping.TryGetValue(categoryName, out int categoryID))
                {
                    // Open the appropriate questionnaire form based on the category
                    Form questionnaire;

                    switch (categoryName)
                    {
                        case "Skin Type":
                            questionnaire = new QuestionareSkinType(userID, categoryID);
                            break;
                        case "Acne":
                            questionnaire = new QuetionareAcne(userID, categoryID);
                            break;
                        case "Sensitivity":
                            questionnaire = new QuestionareSensitivity(userID, categoryID);
                            break;
                        case "Concerns":
                            questionnaire = new QuestionareSkinConcerns(userID, categoryID);
                            break;
                        default:
                            MessageBox.Show($"Category {categoryName} not implemented yet.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Show the selected questionnaire
                    if (questionnaire.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show($"{categoryName} information updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Category {categoryName} not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening questionnaire: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // New method to clear existing responses before adding new ones
        private void ClearExistingResponses(int categoryID)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Delete existing responses for this user and category
                    string deleteQuery = @"
                        DELETE FROM UserResponses 
                        WHERE UserID = @UserID AND CategoryID = @CategoryID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", currentUserID);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing existing responses: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSkinType_Click(object sender, EventArgs e)
        {
            OpenQuestionnaire("Skin Type");
        }

        private void UpdateSkinAcne_Click(object sender, EventArgs e)
        {
            OpenQuestionnaire("Acne");
        }

        private void UpdateSkinSensitivity_Click(object sender, EventArgs e)
        {
            OpenQuestionnaire("Sensitivity");
        }

        private void UpdateSkinConcerns_Click(object sender, EventArgs e)
        {
            OpenQuestionnaire("Concerns");
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(UpdateUserName.Text) ||
                    string.IsNullOrWhiteSpace(UpdateAge.Text) ||
                    string.IsNullOrWhiteSpace(UpdateCity.Text) ||
                    string.IsNullOrWhiteSpace(UpdateEmail.Text))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if Age is a valid number
                if (!int.TryParse(UpdateAge.Text, out int age))
                {
                    MessageBox.Show("Age must be a valid number.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Update user information in the database
                    string updateQuery = @"
                        UPDATE Users 
                        SET Name = @Name, Age = @Age, City = @City, Email = @Email 
                        WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", UpdateUserName.Text);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@City", UpdateCity.Text);
                        cmd.Parameters.AddWithValue("@Email", UpdateEmail.Text);
                        cmd.Parameters.AddWithValue("@UserID", currentUserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Force parent form to refresh if available
                            if (parentProfile != null)
                            {
                                parentProfile.LoadUserProfileDetails();
                            }

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}