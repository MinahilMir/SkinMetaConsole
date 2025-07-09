using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SkinMetaConsole
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            // Ensure that Login2Form exists in your project
            Login2 login2 = new Login2();
            login2.Show();

            // Hide the current login form (optional)
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Get user input from your sign-up form
            string name = signupNameBox.Text;
            string city = signupCitybox.Text;
            int age = Convert.ToInt32(signupAgebox.Text);
            string email = signupEmailbox.Text;
            string password = signupPswdbox.Text;
            string confirmPassword = signupConfirmPswdbox.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Registration Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Insert the new user into the database
            int newUserId = RegisterNewUser(name, city, age, email, password);

            if (newUserId > 0)
            {
                // Store the email for future reference
                CurrentUserManager.SetCurrentUser(email);

                // Navigate to the next form or dashboard
                this.Hide();
                // Next form to show after successful sign-up
                QuestionareSkinType nextForm = new QuestionareSkinType(CurrentUser.UserID, 1);
                nextForm.Show();
            }
            else
            {
                MessageBox.Show("Sign-up failed. Please try again.", "Registration Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to register a new user and return their ID
        private int RegisterNewUser(string name, string city, int age, string email, string password)
        {
            int newUserId = 0;
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    // Insert query with OUTPUT clause to get the new ID
                    string query = @"INSERT INTO Users (Name, City, Age, Email, Password) 
                           OUTPUT INSERTED.UserID
                           VALUES (@name, @city, @age, @email, @password)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        con.Open();
                        // ExecuteScalar returns the first column of the first row
                        newUserId = (int)cmd.ExecuteScalar();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return newUserId;
        }
    }
}

