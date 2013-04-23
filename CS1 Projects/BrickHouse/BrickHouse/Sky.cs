using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BrickHouse
{
    class Sky
    {
        //Declare constants for sky brushes.
        private static LinearGradientBrush DAYTIME_SKY_BRUSH = new LinearGradientBrush(new Rectangle(0, 0, 630, 450), Color.DeepSkyBlue, Color.LightSkyBlue, 90);
        private static LinearGradientBrush SUNSET_BRUSH = new LinearGradientBrush(new Rectangle(0, 0, 630, 450), Color.DarkRed, Color.OrangeRed, 90);
        private static SolidBrush NIGHTTIME_SKY_BRUSH = new SolidBrush(Color.MidnightBlue);
        public static void Paint(Graphics g, string sky)
        {
            //Declares a variable for a sky brush and assigns it based on input string, then paints sky using specified brush.
            Brush skyBrush = Brushes.White;
            switch (sky)
            {
                case "Day": skyBrush = DAYTIME_SKY_BRUSH;
                break;
                case "Sunset": skyBrush = SUNSET_BRUSH;
                break;
                case "Night": skyBrush = NIGHTTIME_SKY_BRUSH;
                break;
            }
            g.FillRectangle(skyBrush, new Rectangle(0, 0, 630, 450));
        }
    }
}
