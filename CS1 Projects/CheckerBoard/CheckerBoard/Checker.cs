//Alex Fuhr
using System;
using System.Drawing;

namespace CheckerBoard
{
    class Checker
    {
        //Declare coordinates, scale factor, size, row, column, and brush.
        private const double scaleFactor = .4;
        private int myX, myY, mySize, myRow, myColumn;
        private Brush myBrush;
        //Initialize the variables listed above.
        public Checker(int column, int row, int size, Brush checkerBrush)
        {
            myRow = row;
            myColumn = column;
            mySize = (int) Math.Round((size * scaleFactor));
            myBrush = checkerBrush;
            myX = (int)(myColumn * size + size * ((1 - scaleFactor) / 2));
            myY = (int)(myRow * size + size * ((1 - scaleFactor) / 2));
        }
        //Paint the checker.
        public void Paint(Graphics g)
        {
            g.FillEllipse(myBrush, myX, myY, mySize, mySize);
        }
    }
}
