// GRADING ID: A9391
// PROGRAM NUMBER: 01
// DUE DATE: 25 September 2018
// COURSE SECTION: 01

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // calculates values and displays totals once the button has been pressed
        private void clcBtn_Click(object sender, EventArgs e)
        {
            double length, // holds the total length of the walls in the room
                height, // holds the height of the room's walls
                minGallons; // holds the minimum float value for the gallons of paint needed

            int doors, // holds the number of doors in the room
                windows, // holds the number of  windows in the room
                coats, // holds the number of the coats of paint desired
                gallonsToBuy; // holds the rounded value of gallons needed using Math.Ceiling

            const int DOOR_SQFT = 20; // the amount of sq. ft. being taken up by a door
            const int WNDW_SQFT = 15; // the amount of sq. ft. being taken up by a window
            const int SQFT_PER_GAL = 385; // the amount of sq. ft. 1 gallon of paint covers

            length = double.Parse(wllsLngthTxt.Text);
            height = double.Parse(hghtWllsTxt.Text);
            doors = int.Parse(doorTxt.Text);
            windows = int.Parse(wndwsTxt.Text);
            coats = int.Parse(coatsTxt.Text);

            minGallons = (((length * height) - (windows * WNDW_SQFT) - (doors * DOOR_SQFT)) * coats) / SQFT_PER_GAL;
            gallonsToBuy = (int)Math.Round(minGallons);

            actualGlnsLbl.Text = $"You need a minimum of {minGallons:F1} gallons of paint";
            roundedGlnsLbl.Text = $"You'll need to buy {gallonsToBuy} gallons, though";
            
        }

        // clears all data if clearBtn is clicked
        private void clearBtn_Click(object sender, EventArgs e)
        {
            wllsLngthTxt.Text = "";
            hghtWllsTxt.Text = "";
            doorTxt.Text = "";
            wndwsTxt.Text = "";
            coatsTxt.Text = "";
            actualGlnsLbl.Text = ""; 
            roundedGlnsLbl.Text = "";
        }
    }
}
