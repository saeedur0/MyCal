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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class Settings : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mycal.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter da = new OleDbDataAdapter();



        public Settings()
        {
            InitializeComponent();
            
        }



        private void backbtn_Click(object sender, EventArgs e)
        {
            new MainInterface().Show();
            this.Hide();
        }

        private void lblLogOff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Press OK to Log Out", "Log Out?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                //^^Displays a message box
                this.Hide(); //Hides the Settings Form
                System.Threading.Thread.Sleep(500); //Waits 0.5 seconds to allow user to understand whats going on
                new Login().Show(); //Displays Login Form
            }
            else
            { 

            }
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            //Updates the fields 'weight', 'goal weight', 'activity' in the email primary key. 
            string query = "UPDATE tbl_users SET [weight]=@weight, [goal weight]=@gw, [activity]=@act WHERE email=@email";

            cmd = new OleDbCommand(query, conn);

            conn.Open();
            cmd.Parameters.AddWithValue("@weight", txtweight.Text);
            cmd.Parameters.AddWithValue("@gw", txtgoalweight.Text);
            cmd.Parameters.AddWithValue("@activity", txtAct.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Details Updated Successfully", "MyCal Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Message Box appears notifying the user that their details have been updated.

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            new Delete_Account().Show();
        }
    }
}
