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
    public partial class strength : Form
    {
        public strength()
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

        
    }
}
