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
        public static MainInterface Current { get; private set; }
        public MainInterface()
        {
            InitializeComponent();
            Current = this;

            //set the initial value of the lblcal label to 2900
            lblcal.Text = "2900";
        }

        public void SubtractFromCalories(int value)
        {
            lblcal.Text = (Convert.ToInt32(lblcal.Text) - value).ToString();
        }

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
