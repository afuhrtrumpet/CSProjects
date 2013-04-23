using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickHouse
{
    class House
    {
        public static void Paint(Graphics g, string houseStyle, string chimneyStyle, bool doorIsArched, bool doorIsDouble, int lightIntensity, int doorFillRed, int doorFillGreen, int doorFillBlue, int doorBorderRed, int doorBorderGreen, int doorBorderBlue, int windowRed, int windowGreen, int windowBlue, int roofFillRed, int roofFillGreen, int roofFillBlue, int roofBorderRed, int roofBorderGreen, int roofBorderBlue)
        {
            //Paint each component of house using given parameters.
            Roof.PaintChimney(g, chimneyStyle);
            Frame.Paint(g, houseStyle);
            Windows.PaintRectangular(g, 180, 340, 80, 60, new SolidBrush(Color.FromArgb(windowRed, windowGreen, windowBlue)), lightIntensity);
            Windows.PaintRectangular(g, 360, 340, 80, 60, new SolidBrush(Color.FromArgb(windowRed, windowGreen, windowBlue)), lightIntensity);
            Windows.PaintRectangular(g, 180, 230, 40, 60, new SolidBrush(Color.FromArgb(windowRed, windowGreen, windowBlue)), lightIntensity);
            Windows.PaintRectangular(g, 400, 230, 40, 60, new SolidBrush(Color.FromArgb(windowRed, windowGreen, windowBlue)), lightIntensity);
            Windows.PaintElliptical(g, 290, 240, 40, 40, new SolidBrush(Color.FromArgb(windowRed, windowGreen, windowBlue)), lightIntensity);
            Door.Paint(g, 280, 330, 60, 120, new SolidBrush(Color.FromArgb(doorFillRed, doorFillGreen, doorFillBlue)), new SolidBrush(Color.FromArgb(doorBorderRed, doorBorderBlue, doorBorderGreen)), Brushes.Gold, doorIsArched, doorIsDouble);  
            //Paint the roof for specified house styles.
            if (houseStyle.Equals("Brick") || houseStyle.Equals("Stone") || houseStyle.Equals("Log Cabin"))
            {
                Roof.PaintRoof(g, Color.FromArgb(roofBorderRed, roofBorderGreen, roofBorderBlue), Color.FromArgb(roofFillRed, roofFillGreen, roofFillBlue));
            }           
        }
    }
}
