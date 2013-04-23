using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickHouse
{
    class Grass
    {
        public static void Paint(Graphics g, bool snow)
        {
            //Paints grass as well as snow if specified.
            g.FillRectangle(Brushes.Green, 0, 450, 630, 150);
            if (snow)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(240, Color.WhiteSmoke)), 0, 450, 630, 150);
            }
        }
    }
}
