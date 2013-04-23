using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsDemo
{
    class Boxes
    {
        public void paint(Graphics g)
        {
            g.FillRectangle(Brushes.LightSalmon, 0, 0, 600, 400);
            LinearGradientBrush fade = new LinearGradientBrush(new Rectangle(30, 30, 50, 30), Color.CornflowerBlue, Color.DarkGreen, 140);
            g.FillRectangle(fade, 30, 30, 540, 340);
        }
    }
}
