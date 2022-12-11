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
    public partial class MainInterface : Form
    {

        public MainInterface()
        {
            InitializeComponent();
            lblcal.Text = Calories.ToString(); //the label takes on the the value of the variable 'calories'
        }

        int Calories = 2900;


        private void btnWorkouts_Click(object sender, EventArgs e)
        {
            new Workouts().Show();
            this.Hide();
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            new Settings().Show(); //The Settings form is showed to the user
            this.Hide(); //The main interface form is closed
        }

        public void pbplus_Click(object sender, EventArgs e)
        {
            new additem().Show();
        }


    }
}
