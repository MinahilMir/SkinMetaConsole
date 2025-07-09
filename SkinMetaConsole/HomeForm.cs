using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinMetaConsole
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {

            // Create an instance of the LoginForm
            LoginForm loginForm = new LoginForm();

            // Show the login form
            loginForm.Show();

            // Optionally, hide the current form
            this.Hide();
        }
    }
}
