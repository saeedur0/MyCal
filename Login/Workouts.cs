using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Workouts : Form
    {
        public Workouts()
        {
            InitializeComponent();

            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            new MainInterface().Show();
            this.Hide();
        }

        private void btncardio_Click(object sender, EventArgs e)
        {
            new cardio().Show();
            this.Hide();
        }

        private void btnstrength_Click(object sender, EventArgs e)
        {
            new strength().Show();
            this.Hide();
        }
    }
}
