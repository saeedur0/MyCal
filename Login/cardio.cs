using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class cardio : Form
    {
        public cardio()
        {
            InitializeComponent();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            new Workouts().Show();
            this.Hide();
        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            new Workouts().Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
