using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mycal.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();

        }

        

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtEmail.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Fields are Empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPass.Text == txtconfPass.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtPass.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Account Creation Successful", "You have now joined MyCal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtconfPass.Text = "";
                txtPass.Focus();

            
            }
        }
    }
}
