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

       
    }
}
