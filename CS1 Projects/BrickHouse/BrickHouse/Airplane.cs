using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickHouse
{
    class Airplane
    {
        //Declare x and y instance fields.
        private int myX;
        private int myY;
        public Airplane(int x, int y)
        {
            //Assign construction parameters to instance fields.
            myX = x;
            myY = y;
        }
        public void Paint(Graphics g, string bannerText, Brush airplaneBrush)
        {
            //Using myX and myY as top right corner, draw airplane using points offset from those values.
            Point[] stringPoints = {new Point(myX - 150, myY), new Point(myX - 130, myY + 20), new Point(myX - 150, myY + 40)};
            Point[] tailPoints = {new Point(myX - 100, myY + 30), new Point(myX - 130, myY + 30), new Point(myX - 130, myY)};
            Point[] wingPoints = {new Point(myX - 60, myY + 20), new Point(myX - 30, myY + 50), new Point(myX - 40, myY + 20)};
            Rectangle[] windows = {new Rectangle(myX - 40, myY + 10, 10, 10), new Rectangle(myX - 60, myY + 10, 10, 10), new Rectangle(myX - 80, myY + 10, 10, 10), new Rectangle(myX - 100, myY + 10, 10, 10)};
            g.FillEllipse(airplaneBrush, myX - 40, myY, 40, 40);
            g.FillEllipse(airplaneBrush, myX - 110, myY, 40, 40);
            g.FillRectangle(airplaneBrush, myX - 90, myY, 70, 40);
            g.FillPolygon(airplaneBrush, wingPoints);
            g.DrawLines(new Pen(Brushes.Gray), wingPoints);
            g.FillPolygon(airplaneBrush, tailPoints);
            g.FillPie(Brushes.White, myX - 30, myY + 10, 20, 20, 270, 90);
            g.FillRectangles(Brushes.White, windows);
            g.DrawLines(new Pen(Brushes.Gray), stringPoints);
            g.FillRectangle(Brushes.PapayaWhip, myX - 250, myY, 100, 40);
            g.DrawString(bannerText, new Font("Comic Sans MS", 15, FontStyle.Bold), Brushes.SeaGreen, new Point(myX - 250, myY + 5));
        }
        public void Move(int x, int xLength)
        {
            //Offset x and move x back to the left of screen if it is completely off the right side of screen.
            myX += x;
            myX %= xLength + 250;
        }
    }
}
