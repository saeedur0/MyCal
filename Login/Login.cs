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

        private void passwordBox1_Enter(object sender, EventArgs e)
        {
            if (passwordBox1.Text == "Password")
            {
                passwordBox1.Text = "";

                passwordBox1.ForeColor = Color.Black;

            }
        }

        private void passwordBox1_Leave(object sender, EventArgs e)
        {
            if (passwordBox1.Text == "")
            {
                passwordBox1.Text = "Password";

                passwordBox1.ForeColor = Color.Silver;

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            emailBox1.Text = "";
            if (emailBox1.Text == "")
            {
                MessageBox.Show("Please enter your Email", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailBox1.Focus();
                return;
            }
            try
            {
                MyCal_UsersDataTableAdapters.tbl_usersTableAdapter user = new MyCal_UsersDataTableAdapters.tbl_usersTableAdapter();
                MyCal_UsersData.tbl_usersDataTable dt = user.GetDataByEmailPassword(emailBox1.Text,passwordBox1.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Process your login here

                    MainInterface form = new MainInterface();
                        form.Show();
                        this.Hide();

                }
                else
                {
                    MessageBox.Show("Your Email or Password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
