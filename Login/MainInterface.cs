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

            //initial values of all labels of the meal log
            lblcal.Text = "2900";
            lblcarbs.Text = "0";
            lblpro.Text = "0";
            lblfat.Text = "0";
            lbleat.Text = "0";
            lblburned.Text = "0";
        }

        public void SubtractFromCalories(int value)
        {
            //Converts the value of the label to an integer and this is subtracted from the from the value of the food item in the other form
            lblcal.Text = (Convert.ToInt32(lblcal.Text) - value).ToString();
        }

        public void AddtoCarbs(int value)
        {
            lblcarbs.Text = (Convert.ToInt32(lblcarbs.Text) + value).ToString();
        }

        public void AddtoPro(int value)
        {
            lblpro.Text = (Convert.ToInt32(lblpro.Text) + value).ToString();
        }

        public void AddtoFat(int value)
        {
            lblfat.Text = (Convert.ToInt32(lblfat.Text) + value).ToString();
        }

        public void AddtoEaten(int value)
        {
            lbleat.Text = (Convert.ToInt32(lbleat.Text) + value).ToString();
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

        private void pbInfoAc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Macros are in grams", "Macro Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
