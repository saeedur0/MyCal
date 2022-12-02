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

            this.fnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.elbl.BackColor = System.Drawing.Color.Transparent;
            this.plbl.BackColor = System.Drawing.Color.Transparent;
            this.clbl.BackColor = System.Drawing.Color.Transparent;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mycal.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        
        private void backbtn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
        
        private void btnJoin3_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtEmail.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Fields are Empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPass.Text == txtconfPass.Text)
            {
                con.Open();
                
                string register = "INSERT INTO tbl_users (Email, Password, Name, Weight, GoalWeight, Height, Gender, ActivityLevel) VALUES (?,?,?,?,?,?,?,?)";

                cmd = new OleDbCommand(register, con);

                cmd.Parameters.AddWithValue("Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("Password", txtPass.Text);
                cmd.Parameters.AddWithValue("Name", txtName.Text);
                cmd.Parameters.AddWithValue("Weight", txtweight.Text);
                cmd.Parameters.AddWithValue("GoalWeight", txtgoalweight.Text);
                cmd.Parameters.AddWithValue("Height", cboHeight.GetItemText(cboHeight.SelectedItem));
                cmd.Parameters.AddWithValue("Gender", cboGender.GetItemText(cboGender.SelectedItem));
                cmd.Parameters.AddWithValue("ActivityLevel", cboAct.GetItemText(cboAct.SelectedItem));


                
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

        private void pbInfoAc_Click(object sender, EventArgs e)
        {
            new info().Show();
        }
    }
}
