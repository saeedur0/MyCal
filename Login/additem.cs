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

namespace Login
{
    public partial class additem : Form
    {
        
        public additem()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void btnrice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 130 kcal, 2.2g of fat, 25.22g of carbs. Add item to meal log?", "Add Rice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface main = new MainInterface(); //creating an instance of the MainInterface form
                int calories = int.Parse(main.lblcal.Text); //parsing the text value of the label to an integer
                calories -= 130; //subtracting the value of the item being added
                main.lblcal.Text = calories.ToString(); //updating the label with the new value
            }
            else
            {
                //nothing
            }
        }
    }
}
