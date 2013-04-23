using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphicsDemo
{
    class StringBeads
    {
        public static void paint(Graphics g)
        {
            Bitmap texture = new Bitmap(10, 10);
            Graphics g2 = Graphics.FromImage(texture);
            g2.FillRectangle(new SolidBrush(Color.FromArgb(100, 230, 75, 120)), 0, 0, 10, 10);
            g2.DrawLine(Pens.Chocolate, 4, 0, 4, 9);
            g2.FillEllipse(Brushes.Chartreuse, 3, 3, 3, 3);
            TextureBrush tb = new TextureBrush(texture);
            g.FillRectangle(tb, 0, 0, 600, 430);
        }
    }
}
