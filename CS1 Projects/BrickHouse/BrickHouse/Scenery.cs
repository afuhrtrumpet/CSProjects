using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Timers;

namespace BrickHouse
{
    class Scenery
    {
        //Declare and initialize object variables.
        private static Airplane skyPlane = new Airplane(390, 5);
        private static Smoke[] clouds = {new Smoke(new Rectangle(390, 70, 40, 20), 200), new Smoke(new Rectangle(430, 40, 40, 20), 200), new Smoke(new Rectangle(470, 10, 40, 20), 200)};
        public static void Paint(string sky, Graphics g, double treeWidth, double treeHeight, int cloudDarkness, string bannerName, int airplaneRed, int airplaneGreen, int airplaneBlue, bool snow)
        {
            //Paint each item in the scenery and alter cloud darkness.
            Sky.Paint(g, sky);
            foreach (Smoke cloud in clouds)
            {
                cloud.Paint(g);
                cloud.CloudDarkness = cloudDarkness;
            }
            Grass.Paint(g, snow);
            Trees.Paint(g, treeWidth, treeHeight, 540, 450, snow);
            Trees.Paint(g, treeWidth, treeHeight, 60, 450, snow);
            skyPlane.Paint(g, bannerName, new SolidBrush(Color.FromArgb(airplaneRed, airplaneGreen, airplaneBlue)));
        }
        public static void AnimateClouds()
        {
            //Set the cloud back to a starting position if at maximum value, otherwise move in the slope of the line containing all three clouds.
            foreach (Smoke cloud in clouds)
            {
                if (cloud.GetY() <= -20)
                {
                    cloud.Reset(390, 70);
                }
                else
                {
                    cloud.Move(4, -3);
                }
            }           
        }
        public static void AnimateAirplane()
        {
            //Move airplane.
            skyPlane.Move(1, 630);
        }
    }
}
