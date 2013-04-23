using System;
using System.Drawing;
using System.Collections.Generic;

namespace CheckerBoard
{
    class Checker
    {
        public List<Point> movablePoints = new List<Point>();
        private bool movable;
        private int myX, myY, mySize, myRow, myColumn, myOriginalSize;
        private Brush myBrush;
        public Checker(int column, int row, int size, Brush checkerBrush)
        {
            myRow = row;
            myColumn = column;
            myOriginalSize = size;
            mySize = size * 3 / 4;
            myBrush = checkerBrush;
            movable = false;
            
        }
        public void Paint(Graphics g)
        {
            myX = myColumn * myOriginalSize + myOriginalSize / 8;
            myY = myRow * myOriginalSize + myOriginalSize / 8;
            if (movable)
            {
                SolidBrush highlightBrush = new SolidBrush(Color.FromArgb(150, 255, 255, 255));
                g.FillEllipse(highlightBrush, myX - mySize / 6, myY - mySize / 6, mySize * 4 / 3, mySize * 4 / 3); 
            }
            g.FillEllipse(myBrush, myX, myY, mySize, mySize);
        }
        public int Row
        {
            get
            {
                return myRow;
            }
            set
            {
                myRow = value;
            }
        }
        public int Column
        {
            get
            {
                return myColumn;
            }
            set
            {
                myColumn = value;
            }
        }
        public bool Movable
        {
            get
            {
                return movable;
            }
            set
            {
                movable = value;
            }
        }
    }
}
