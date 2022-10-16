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
using System.Data.OleDb;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=mycal.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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
            con.Open();
            string login = "SELECT * From tbl_users WHERE email= '" + emailBox1.Text + "' and password= '" + passwordBox1.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new MainInterface().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailBox1.Text = "";
                passwordBox1.Text = "";
            
            }

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new register().Show();
            this.Hide();
        }
    }
}
