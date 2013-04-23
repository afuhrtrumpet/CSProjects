//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickHouse
{
    class Windows
    {
        public static void PaintRectangular(Graphics g, int x, int y, int width, int height, Brush externalBrush, int lightIntensity)
        {
            //Paint window based on rectangle parameters, a brush, and a color.
            SolidBrush indoorBrush = new SolidBrush(Color.FromArgb(255, 255, lightIntensity));
            g.FillRectangle(indoorBrush, x, y, width, height);
            g.DrawRectangle(new Pen(externalBrush, 3), x, y, width, height);
            g.DrawLine(new Pen(externalBrush, 3), x, y + height/2, x + width, y + height/2);
            g.DrawLine(new Pen(externalBrush, 3), x + width/2, y, x + width/2, y + height);
        }

        public static void PaintElliptical(Graphics g, int x, int y, int width, int height, Brush externalBrush, int lightIntensity)
        {
            //Paint window based on rectangle parameters, a brush, and a color.
            SolidBrush indoorBrush = new SolidBrush(Color.FromArgb(255, 255, lightIntensity));
            g.FillEllipse(indoorBrush, x, y, width, height);
            g.DrawEllipse(new Pen(externalBrush, 3), x, y, width, height);
            g.DrawLine(new Pen(externalBrush, 3), x, y + height / 2, x + width, y + height / 2);
            g.DrawLine(new Pen(externalBrush, 3), x + width / 2, y, x + width/2,  y + height);
        }
    }
}
