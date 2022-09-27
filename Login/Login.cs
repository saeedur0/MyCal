using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void emailBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void emailBox1_Enter(object sender, EventArgs e)
        {
            if (emailBox1.Text == "Email") {
                emailBox1.Text = "";

                emailBox1.ForeColor = Color.Black;

            }
        }

        private void emailBox1_Leave(object sender, EventArgs e)
        {
            if (emailBox1.Text == "")
            {
                emailBox1.Text = "Email";

                emailBox1.ForeColor = Color.Silver;

            }
        }
    }
}
