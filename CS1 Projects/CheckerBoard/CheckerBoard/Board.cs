//Alex Fuhr
using System.Drawing;

namespace CheckerBoard
{
    class Board
    {
        //Declare checker arrays for each side, size, columns, rows, and all brushes.
        private Checker[] topCheckers;
        private Checker[] bottomCheckers;
        private int mySize, myColumns, myRows;
        private Brush mySquareBrush1, mySquareBrush2, myCheckerBrush1, myCheckerBrush2;
        //Initialize all variables listed above.
        public Board(int size, int columns, int rows, Brush firstSquareBrush, Brush secondSquareBrush, Brush firstCheckerBrush, Brush secondCheckerBrush)
        {
            mySize = size;
            myColumns = columns;
            myRows = rows;
            mySquareBrush1 = firstSquareBrush;
            mySquareBrush2 = secondSquareBrush;
            myCheckerBrush1 = firstCheckerBrush;
            myCheckerBrush2 = secondCheckerBrush;
            //Determine how many rows on each side are filled by checkers.
            int checkerFilledRows = myRows / 2 - 1;
            //Initialize both arrays based on columns and rows.
            topCheckers = new Checker[myColumns * checkerFilledRows / 2];
            bottomCheckers = new Checker[myColumns * checkerFilledRows / 2];
            //Provide values for each term in the array.
            for (int i = 0; i < myColumns / 2; i++)
            {
                for (int j = 0; j < checkerFilledRows; j++)
                {
                    //Determine column shift for each checker.
                    int indent = j % 2 == 1 ? 1 : 0;
                    topCheckers[i * (topCheckers.Length / (myColumns / 2)) + j] = new Checker(i * 2 + indent, j, mySize, myCheckerBrush1);
                }
            }
            for (int i = 0; i < myColumns / 2; i++)
            {
                for (int j = 0; j < myRows / 2 - 1; j++)
                {
                    int verticalModifier = myRows % 2 == 1 ? 1 : 0;
                    int indent = (j + myRows / 2 + 1 + verticalModifier) % 2 == 1 ? 1 : 0;
                    bottomCheckers[i * (bottomCheckers.Length / (myColumns / 2)) + j] = new Checker(i * 2 + indent, j + myRows / 2 + 1 + verticalModifier, mySize, myCheckerBrush2);
                }
            }
        }
        //Paint the board and checkers.
        public void Paint(Graphics g)
        {
            //Create the board's background.
            g.FillRectangle(mySquareBrush1, 0, 0, mySize * myColumns, mySize * myRows);
            g.DrawRectangle(Pens.Black, 0, 0, mySize * myColumns - 1, mySize * myRows - 1);
            //Create the secondary rectangles.
            for (int i = 0; i < myColumns / 2; i++)
            {
                for (int j = 0; j < myRows; j++)
                {
                    //Determine if the square will be indented.
                    int indent = j % 2 == 1 ? mySize : 0;
                    g.FillRectangle(mySquareBrush2, i * mySize * 2 + indent, j * mySize, mySize, mySize);
                    g.DrawRectangle(Pens.Black, i * mySize * 2 + indent, j * mySize, mySize, mySize);
                }
            }
            //Paint each of the checkers.
            foreach (Checker checker in topCheckers)
            {
                checker.Paint(g);
            }
            foreach (Checker checker in bottomCheckers)
            {
                checker.Paint(g);
            }
        }
    }
}
