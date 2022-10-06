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
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(10); //This increments the progress bar value by ten
            if (progressBar1.Value == 100) //If statement, if the progress bar is full then

            {
                timer1.Enabled = false;  //the timer will be disabled and 
                Login form = new Login(); //This connects to my login form
                form.Show();              //This shows my login form and
                this.Hide();              //hides this form

            }

        }
    }
}
