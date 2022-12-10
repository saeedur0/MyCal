using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class debugmenu : Form
    {
        public debugmenu()
        {
            InitializeComponent();
            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new register().Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new MainInterface().Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new Workouts().Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new strength().Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            new cardio().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
