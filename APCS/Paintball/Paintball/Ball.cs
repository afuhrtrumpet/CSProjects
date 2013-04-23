using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paintball
{
    class Ball
    {
        private Point myLocation;
        private Size mySize;
        Color myColor;

        public Ball(Point location, Size size, Color color)
        {
            myLocation = new Point(location.X - size.Width/2, location.Y - size.Height/2);
            mySize = size;
            myColor = color;
        }

        public void Paint(Graphics g)
        {
            g.FillEllipse(new SolidBrush(myColor), myLocation.X, myLocation.Y, mySize.Width, mySize.Height);
        }
    }
}
