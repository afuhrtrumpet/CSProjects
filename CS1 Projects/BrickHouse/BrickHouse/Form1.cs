using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrickHouse
{
    public partial class Form1 : Form
    {
        //Declare and initialize variables to use for parameters.
        private int airplaneRed = 200;
        private int airplaneGreen = 200;
        private int airplaneBlue = 200;
        private int roofBorderRed = 200;
        private int roofBorderGreen = 200;
        private int roofBorderBlue = 200;
        private int roofFillRed = 100;
        private int roofFillGreen = 100;
        private int roofFillBlue = 100;
        private int windowRed = 100;
        private int windowGreen = 100;
        private int windowBlue = 100;
        private int doorFillRed = 100;
        private int doorFillGreen = 100;
        private int doorFillBlue = 100;
        private int doorBorderRed = 200;
        private int doorBorderGreen = 200;
        private int doorBorderBlue = 200;
        private int cloudDarkness = 200;
        private int lightIntensity = 0;
        private bool snow = false;
        private bool doorIsArched = false;
        private bool doorIsDouble = false;
        private double treeWidth = 1;
        private double treeHeight = 1;
        private string sky = "Day";
        private string houseStyle = "Brick";
        private string chimneyStyle = "Brick";
        public Form1()
        {
            InitializeComponent();
            //Set starting values for all of the input controls.
            timeList.SelectedIndex = 0;
            houseStyleList.SelectedIndex = 0;
            chimneyStyleList.SelectedIndex = 0;
            treeWidthList.SelectedIndex = 5;
            treeHeightList.SelectedIndex = 5;
            doorFillBlueBar.Value = 100;
            doorFillGreenBar.Value = 100;
            doorFillRedBar.Value = 100;
            doorBorderBlueBar.Value = 200;
            doorBorderGreenBar.Value = 200;
            doorBorderRedBar.Value = 200;
            windowBlueBar.Value = 100;
            windowRedBar.Value = 100;
            windowGreenBar.Value = 100;
            roofFillBlueBar.Value = 100;
            roofFillRedBar.Value = 100;
            roofFillGreenBar.Value = 100;
            roofBorderBlueBar.Value = 200;
            roofBorderRedBar.Value = 200;
            roofBorderGreenBar.Value = 200;
            airplaneBlueBar.Value = 150;
            airplaneRedBar.Value = 150;
            airplaneGreenBar.Value = 150;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Create graphics object and paint the scenery and house using variables as parameters.
            Graphics g = e.Graphics;
            Scenery.Paint(sky, g, treeWidth, treeHeight, cloudDarkness, "Alex Fuhr", airplaneRed, airplaneGreen, airplaneBlue, snow);
            House.Paint(g, houseStyle, chimneyStyle, doorIsArched, doorIsDouble, lightIntensity, doorFillRed, doorFillGreen, doorFillBlue, doorBorderRed, doorBorderGreen, doorBorderBlue, windowRed, windowGreen, windowBlue, roofFillRed, roofFillGreen, roofFillBlue, roofBorderRed, roofBorderGreen, roofBorderBlue);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //Assign values to each variable based on the input control values and repaint.
            snow = snowBox.Checked;
            airplaneBlue = airplaneBlueBar.Value;
            airplaneRed = airplaneRedBar.Value;
            airplaneGreen = airplaneGreenBar.Value;
            roofBorderBlue = roofBorderBlueBar.Value;
            roofBorderRed = roofBorderRedBar.Value;
            roofBorderGreen = roofBorderGreenBar.Value;
            roofFillBlue = roofFillBlueBar.Value;
            roofFillRed = roofFillRedBar.Value;
            roofFillGreen = roofFillGreenBar.Value;
            windowBlue = windowBlueBar.Value;
            windowRed = windowRedBar.Value;
            windowGreen = windowGreenBar.Value;
            doorFillBlue = doorFillBlueBar.Value;
            doorFillGreen = doorFillGreenBar.Value;
            doorFillRed = doorFillRedBar.Value;
            doorBorderBlue = doorBorderBlueBar.Value;
            doorBorderGreen = doorBorderGreenBar.Value;
            doorBorderRed = doorBorderRedBar.Value;
            cloudDarkness = cloudDarknessBar.Value;
            lightIntensity = lightIntensityBar.Value;
            doorIsArched = archedBox.Checked;
            doorIsDouble = doubleBox.Checked;
            sky = timeList.Text;
            chimneyStyle = chimneyStyleList.Text;
            houseStyle = houseStyleList.Text;
            treeWidth = double.Parse(treeWidthList.Text);
            treeHeight = double.Parse(treeHeightList.Text);
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Move the clouds and repaint.
            Scenery.AnimateClouds();
            pictureBox1.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Move airplane and repaint.
            Scenery.AnimateAirplane();
            pictureBox1.Refresh();
        }
    }
}
