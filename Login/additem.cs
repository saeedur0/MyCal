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
            this.MouseDown += additem_MouseDown;
            this.MouseMove += additem_MouseMove;
            this.MouseUp += additem_MouseUp;
        }

        private bool _isDragging = false;
        private Point _startPoint;

        private void additem_MouseDown(object sender, MouseEventArgs e)
        {
            // Start dragging the form only if the left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _startPoint = e.Location;
            }
        }

        private void additem_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                // Calculate the distance the mouse has been moved since the form was clicked
                int offsetX = e.Location.X - _startPoint.X;
                int offsetY = e.Location.Y - _startPoint.Y;

                // Update the position of the form based on the mouse movement
                this.Location = new Point(this.Location.X + offsetX, this.Location.Y + offsetY);
            }
        }

        private void additem_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging the form when the mouse button is released
            _isDragging = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnchkn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 165 kcal, 0g of Carbs, 31g of Protein, 4g of fat. Add item to meal log?", "Add 100g Cooked Chicken Breast", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(165); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(0);
                mainInterface.AddtoPro(31);
                mainInterface.AddtoFat(4);
                mainInterface.AddtoEaten(165);
            }
            else
            {
                //nothing
            }
        }

        private void btnbroc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 31 kcal, 6g of Carbs, 3g of Protein, 0g of fat. Add item to meal log?", "Add 100g Broccoli", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(31); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(6);
                mainInterface.AddtoPro(3);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(31);
            }
            else
            {
                //nothing
            }
        }

        private void btncorn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 96 kcal, 21g of Carbs, 3g of Protein, 2g of fat. Add item to meal log?", "Add 100g Corn", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(96); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(21);
                mainInterface.AddtoPro(3);
                mainInterface.AddtoFat(2);
                mainInterface.AddtoEaten(96);
            }
            else
            {
                //nothing
            }
        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 95 kcal, 25g of Carbs, 1g of Protein, 0g of fat. Add item to meal log?", "Add 1 Apple", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(130); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(95);
                mainInterface.AddtoPro(1);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(95);
            }
            else
            {
                //nothing
            }
        }

        private void btnban_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 110 kcal, 28g of Carbs, 1g of Protein, 0g of fat. Add item to meal log?", "Add 1 Banana", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(110); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(28);
                mainInterface.AddtoPro(1);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(110);
            }
            else
            {
                //nothing
            }
        }

        private void btnbeef_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 250 kcal, 0g of Carbs, 35g of Protein, 10g of fat. Add item to meal log?", "Add 100g Beef", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(250); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(0);
                mainInterface.AddtoPro(35);
                mainInterface.AddtoFat(10);
                mainInterface.AddtoEaten(250);
            }
            else
            {
                //nothing
            }
        }

        private void btnlentils_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 116 kcal, 25g of Carbs, 9g of Protein, 0g of fat. Add item to meal log?", "Add 100g Lentils", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(116); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(25);
                mainInterface.AddtoPro(9);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(116);
            }
            else
            {
                //nothing
            }
        }

        private void btnpot_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 87 kcal, 25g of Carbs, 3g of Protein, 0g of fat. Add item to meal log?", "Add 100g Boiled Potato", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(87); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(25);
                mainInterface.AddtoPro(3);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(87);
            }
            else
            {
                //nothing
            }
        }

        private void btnsal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 206 kcal, 0g of Carbs, 23g of Protein, 12g of fat. Add item to meal log?", "Add 100g Salmon", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(206); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(0);
                mainInterface.AddtoPro(23);
                mainInterface.AddtoFat(12);
                mainInterface.AddtoEaten(206);
            }
            else
            {
                //nothing
            }
        }

        private void btnegg_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 72 kcal, 0g of Carbs, 7g of Protein, 5g of fat. Add item to meal log?", "Add 1 Medium Egg", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(72); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(0);
                mainInterface.AddtoPro(7);
                mainInterface.AddtoFat(5);
                mainInterface.AddtoEaten(72);
            }
            else
            {
                //nothing
            }
        }

        private void mycalbuttons11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 92 kcal, 1g of Carbs, 6g of Protein, 8g of fat. Add item to meal log?", "Add 25g Cheese", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(92); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(1);
                mainInterface.AddtoPro(6);
                mainInterface.AddtoFat(8);
                mainInterface.AddtoEaten(92);
            }
            else
            {
                //nothing
            }
        }

        private void btnyog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 58 kcal, 4g of Carbs, 10g of Protein, 0g of fat. Add item to meal log?", "Add 100g Greek Yoghurt", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(58); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(4);
                mainInterface.AddtoPro(10);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(58);
            }
            else
            {
                //nothing
            }
        }

        private void btnhon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 64 kcal, 17g of Carbs, 0g of Protein, 2g of fat. Add item to meal log?", "Add 1 tbsp (21g) Honey", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(64); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(17);
                mainInterface.AddtoPro(0);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(64);
            }
            else
            {
                //nothing
            }
        }

        private void btnpast_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 196 kcal, 38g of Carbs, 7g of Protein, 1g of fat. Add item to meal log?", "Add 100g Pasta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(196); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(38);
                mainInterface.AddtoPro(7);
                mainInterface.AddtoFat(1);
                mainInterface.AddtoEaten(196);
            }
            else
            {
                //nothing
            }
        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 25 kcal, 4g of Carbs, 3g of Protein, 0g of fat. Add item to meal log?", "Add 100g Spinach", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(25); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(4);
                mainInterface.AddtoPro(3);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(25);
            }
            else
            {
                //nothing
            }
        }

        private void btnLet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 16 kcal, 3g of Carbs, 1g of Protein, 0g of fat. Add item to meal log?", "Add 100g Iceberg Lettuce", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(16); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(3);
                mainInterface.AddtoPro(1);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(16);
            }
            else
            {
                //nothing
            }
        }

        private void btntom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 18 kcal, 4g of Carbs, 1g of Protein, 0g of fat. Add item to meal log?", "Add 100g Tomato", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(18); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(4);
                mainInterface.AddtoPro(1);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(18);
            }
            else
            {
                //nothing
            }
        }

        private void btncuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 45 kcal, 11g of Carbs, 2g of Protein, 0g of fat. Add item to meal log?", "Add 100g Cucumber", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(45); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(11);
                mainInterface.AddtoPro(2);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(45);
            }
            else
            {
                //nothing
            }
        }

        private void btnpea_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 50 kcal, 15g of Carbs, 1g of Protein, 0g of fat. Add item to meal log?", "Add 1 Peach", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(50); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(15);
                mainInterface.AddtoPro(1);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(50);
            }
            else
            {
                //nothing
            }
        }

        private void btnmay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 94 kcal, 0g of Carbs, 0g of Protein, 10g of fat. Add item to meal log?", "Add 1tbsp Mayo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnwe_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 68 kcal, 13g of Carbs, 1g of Protein, 1g of fat. Add item to meal log?", "Add 1 Weetabix Biscuit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(68); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(13);
                mainInterface.AddtoPro(1);
                mainInterface.AddtoFat(1);
                mainInterface.AddtoEaten(68);
            }
            else
            {
                //nothing
            }
        }

        private void btnor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 62 kcal, 15g of Carbs, 3g of Protein, 0g of fat. Add item to meal log?", "Add 1 Orange", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(62); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(15);
                mainInterface.AddtoPro(3);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(62);
            }
            else
            {
                //nothing
            }
        }

        private void btnpiz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 285 kcal, 36g of Carbs, 12g of Protein, 11g of fat. Add item to meal log?", "Add 1 Pizza Slice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(285); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(36);
                mainInterface.AddtoPro(12);
                mainInterface.AddtoFat(11);
                mainInterface.AddtoEaten(285);
            }
            else
            {
                //nothing
            }
        }

        private void btndon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 377 kcal, 25g of Carbs, 24g of Protein, 31g of fat. Add item to meal log?", "Add 100g Doner Meat", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(377); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(25);
                mainInterface.AddtoPro(24);
                mainInterface.AddtoFat(31);
                mainInterface.AddtoEaten(377);
            }
            else
            {
                //nothing
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnwater_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 0 kcal, 0g of Carbs, 0g of Protein, 0g of fat. Add item to meal log?", "Add 100ml Water", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(0); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(0);
                mainInterface.AddtoPro(0);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(0);
            }
            else
            {
                //nothing
            }
        }

        private void btnbluemilk_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 157 kcal, 12g of Carbs, 9g of Protein, 9g of fat. Add item to meal log?", "Add 100ml Blue Top Milk", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(157); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(12);
                mainInterface.AddtoPro(9);
                mainInterface.AddtoFat(9);
                mainInterface.AddtoEaten(157);
            }
            else
            {
                //nothing
            }
        }

        private void btnpep_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 44 kcal, 11g of Carbs, 0g of Protein, 0g of fat. Add item to meal log?", "Add 100ml Pepsi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(44); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(11);
                mainInterface.AddtoPro(0);
                mainInterface.AddtoFat(0);
                mainInterface.AddtoEaten(44);
            }
            else
            {
                //nothing
            }
        }

        private void btnsmo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Macros: 160 kcal, 39g of Carbs, 3g of Protein, 1g of fat. Add item to meal log?", "Add 100ml Green Smoothie", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
                mainInterface.SubtractFromCalories(168); //call the SubtractFromCalories method and pass in the value to subtract
                mainInterface.AddtoCarbs(39);
                mainInterface.AddtoPro(3);
                mainInterface.AddtoFat(1);
                mainInterface.AddtoEaten(168);
            }
            else
            {
                //nothing
            }
        }

        private void lblone_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoBurn(1); 
        }

        private void lblten_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoBurn(10); 
        }

        private void lblcent_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoBurn(100); 
        }

        private void lblc100_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoCarbs(100);
        }

        private void lblc10_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoCarbs(10);
        }

        private void lblc1_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoCarbs(1);
        }

        private void lblpro100_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoPro(100);
        }

        private void lblpro10_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoPro(10);
        }

        private void lblpro1_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoPro(1);
        }

        private void lblfat100_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoFat(100);
        }

        private void lblfat10_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoFat(10);
        }

        private void lblfat1_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.AddtoFat(1);
        }

        private void lblcal100_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.SubtractFromCalories(100);
        }

        private void lblcal10_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.SubtractFromCalories(10);
        }

        private void lblcal1_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = MainInterface.Current; //get the existing instance of the MainInterface form
            mainInterface.SubtractFromCalories(1);
        }
    }
}
