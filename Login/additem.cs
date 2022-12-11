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
            DialogResult result = MessageBox.Show("Macros: 130 kcal, 25g of Carbs, 3g of Protein, 2g of fat. Add item to meal log?", "Add 100g Rice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(130); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(25);
                mainInterface.AddtoPro(3);
                mainInterface.AddtoFat(2);
                mainInterface.AddtoEaten(130);
            }
            else
            {
                //nothing
            }
        }
    }
}
