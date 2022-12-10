using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class Delete_Account : Form
    {
        public Delete_Account()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mycal.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDanger_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("By pressing 'OK' you will lose your MyCal account. All account data will be lost forever.", "FINAL WARNING", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {

                //Deletes the email that is entered from the user table
                string query = "DELETE FROM tbl_users WHERE email = @email";

                cmd = new OleDbCommand(query, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Account Deleted Successfully, MyCal will close now", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Threading.Thread.Sleep(100); //Waits 0.1 seconds
                Application.Exit(); //Program Stops
            }
            else
            {
                //if the user presses cancel then the delete account form will disappear.
                this.Hide();
            }
        }

    }
}
