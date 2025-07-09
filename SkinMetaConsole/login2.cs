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
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }
        private bool AuthenticateUser(string email, string password)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        private void OpenUserProfile(string email)
        {
            // Retrieve user details
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = "SELECT UserID, Name, City, Age FROM Users WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("UserID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string city = reader.GetString(reader.GetOrdinal("City"));
                            string Email = reader.GetString(reader.GetOrdinal("Email"));
                            int age = reader.GetInt32(reader.GetOrdinal("Age"));

                            // Open User Profile Form
                            UserProfile profileForm = new UserProfile(userId, Email);
                            profileForm.Show();
                            this.Hide(); // Hide login form
                        }
                    }
                }
            }
        }
        private void login_button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT UserID FROM Users WHERE Email = @email AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        string emailInput = emailtextBox.Text.Trim();
                        string passwordInput = passwordBox.Text;

                        cmd.Parameters.AddWithValue("@email", emailInput);
                        cmd.Parameters.AddWithValue("@password", passwordInput);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Store both UserID and Email for global access
                            CurrentUser.UserID = Convert.ToInt32(result);
                            CurrentUser.Email = emailInput;

                            // Open user profile or next form
                            UserProfile profile = new UserProfile(CurrentUser.UserID, CurrentUser.Email);
                            profile.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}