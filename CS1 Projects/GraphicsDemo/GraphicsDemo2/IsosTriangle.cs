 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphicsDemo2
{
    class IsosTriangle
    {
        private Brush myBrush;
        private int myX, myY, myWidth, myHeight;

        public IsosTriangle(Brush brush, int x, int y, int width, int height)
        {
            myBrush = brush;
            myX = x;
            myY = y;
            myWidth = width;
            myHeight = height;
        }

        public void Paint(Graphics g)
        {
            Point[] points = 
            {
                new Point(myX, myY),
                new Point(myX - myWidth / 2, myY + myHeight),
                new Point(myX + myWidth / 2, myY + myHeight)
            };
            g.FillPolygon(myBrush, points);
        }
    }
}
