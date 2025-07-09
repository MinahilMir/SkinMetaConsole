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
    public partial class Tracker : Form
    {
        public Tracker()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
            this.Hide();
        }
    }
}
