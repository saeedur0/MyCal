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
    public partial class Settings : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
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
            MessageBox.Show("Press OK to Log Out", "Log Out?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //^^Displays a message box
            this.Hide(); //Hides the Settings Form
            System.Threading.Thread.Sleep(500); //Waits 0.5 seconds to allow user to understand whats going on
            new Login().Show(); //Displays Login Form
        }

        private void lblSave_Click(object sender, EventArgs e)
        {

        }
    }
}
