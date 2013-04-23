using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsDemo
{
    class OtherShapes
    {
        public void paint(Graphics g)
        {
            g.FillEllipse(new HatchBrush(HatchStyle.Shingle, Color.MidnightBlue, Color.Turquoise), 170, 150, 200, 150);
            g.FillPie(Brushes.Yellow, 210, 250, 60, 60, 30, 300);
        }
    }
}
