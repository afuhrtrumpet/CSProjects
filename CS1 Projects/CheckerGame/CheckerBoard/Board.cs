using System.Drawing;
using System.Collections.Generic;

namespace CheckerBoard
{
    class Board
    {
        private Checker currentlySelectedChecker;
        private List<Point> highlightedSquares;
        public enum Players { TOP, BOTTOM };
        private Checker[] topCheckers;
        private Checker[] bottomCheckers;
        private int mySize, myColumns, myRows;
        private Brush mySquareBrush1, mySquareBrush2, myCheckerBrush1, myCheckerBrush2;
        public Board(int size, int columns, int rows, Brush firstSquareBrush, Brush secondSquareBrush, Brush firstCheckerBrush, Brush secondCheckerBrush)
        {
            mySize = size;
            myColumns = columns;
            myRows = rows;
            mySquareBrush1 = firstSquareBrush;
            mySquareBrush2 = secondSquareBrush;
            myCheckerBrush1 = firstCheckerBrush;
            myCheckerBrush2 = secondCheckerBrush;
            int checkerFilledRows = myRows / 2 - 1;
            topCheckers = new Checker[myColumns * checkerFilledRows / 2];
            bottomCheckers = new Checker[myColumns * checkerFilledRows / 2];
            for (int i = 0; i < myColumns / 2; i++)
            {
                for (int j = 0; j < checkerFilledRows; j++)
                {
                    int indent = j % 2 == 1 ? 1 : 0;
                    topCheckers[i * (topCheckers.Length / (myColumns / 2)) + j] = new Checker(i * 2 + indent, j, mySize, myCheckerBrush1);
                }
            }
            for (int i = 0; i < myColumns / 2; i++)
            {
                for (int j = 0; j < checkerFilledRows; j++)
                {
                    int verticalModifier = myRows % 2 == 1 ? 1 : 0;
                    int indent = (j + myRows / 2 + 1 + verticalModifier) % 2 == 1 ? 1 : 0;
                    bottomCheckers[i * (bottomCheckers.Length / (myColumns / 2)) + j] = new Checker(i * 2 + indent, j + myRows / 2 + 1 + verticalModifier, mySize, myCheckerBrush2);
                }
            }
        }
        public void Paint(Graphics g)
        {
            g.FillRectangle(mySquareBrush1, 0, 0, mySize * myColumns, mySize * myRows);
            g.DrawRectangle(Pens.Black, 0, 0, mySize * myColumns - 1, mySize * myRows - 1);
            for (int i = 0; i < myColumns / 2; i++)
            {
                for (int j = 0; j < myRows; j++)
                {
                    int indent = j % 2 == 1 ? mySize : 0;
                    g.FillRectangle(mySquareBrush2, i * mySize * 2 + indent, j * mySize, mySize, mySize);
                    g.DrawRectangle(Pens.Black, i * mySize * 2 + indent, j * mySize, mySize, mySize);
                }
            }
            if (highlightedSquares != null)
            {
                foreach (Point point in highlightedSquares)
                {
                    SolidBrush highlightBrush = new SolidBrush(Color.FromArgb(100, 255, 255, 255));
                    g.FillRectangle(highlightBrush, point.X, point.Y, mySize, mySize);
                } 
            }
            foreach (Checker checker in topCheckers)
            {
                checker.Paint(g);
            }
            foreach (Checker checker in bottomCheckers)
            {
                checker.Paint(g);
            }
        }
        public void CheckMovableCheckers(Players checkers)
        {
            Checker[] checkerArray = checkers == Players.TOP ? topCheckers : bottomCheckers;
            Checker[] otherCheckerArray = checkers == Players.TOP ? bottomCheckers : topCheckers;
            int downOrUp = checkers == Players.TOP ? 1 : -1;
            foreach (Checker checker in checkerArray)
            {
                for (int i = 0; i < checkerArray.Length; i++)
                {
                    if (checker.Row + downOrUp < 0 || checker.Row + downOrUp >= myRows || checker.Column + 1 >= myColumns) break;
                    if (checker.Row + downOrUp == checkerArray[i].Row && checker.Column + 1 == checkerArray[i].Column) break;
                    if (checker.Row + downOrUp == otherCheckerArray[i].Row && checker.Column + 1 == otherCheckerArray[i].Column) break;
                    if (i == checkerArray.Length - 1)
                    {
                        checker.Movable = true;
                        checker.movablePoints.Add(new Point(mySize * (checker.Column + 1), mySize * (checker.Row + downOrUp)));
                    }
                }
                for (int i = 0; i < checkerArray.Length; i++)
                {
                    if (checker.Row + downOrUp < 0 || checker.Row + downOrUp >= myRows || checker.Column - 1 < 0) break;
                    if (checker.Row + downOrUp == checkerArray[i].Row && checker.Column - 1 == checkerArray[i].Column) break;
                    if (checker.Row + downOrUp == otherCheckerArray[i].Row && checker.Column - 1 == otherCheckerArray[i].Column) break;
                    if (i == checkerArray.Length - 1)
                    {
                        checker.Movable = true;
                        checker.movablePoints.Add(new Point(mySize * (checker.Column - 1), mySize * (checker.Row + downOrUp)));
                    }
                }
            }
        }
        public bool Click(Point clickLocation)
        {
            Checker clickedChecker = null;
            int row = clickLocation.Y / mySize;
            int column = clickLocation.X / mySize;
            foreach (Checker checker in topCheckers)
                if (checker.Row == row && checker.Column == column)
                    clickedChecker = checker;
            foreach (Checker checker in bottomCheckers)
                if (checker.Row == row && checker.Column == column)
                    clickedChecker = checker;
            if (clickedChecker != null)
            {
                highlightedSquares.Clear();
                highlightedSquares = clickedChecker.movablePoints;
                currentlySelectedChecker = clickedChecker;
            }
            else
            {
                if (highlightedSquares.Count != 0)
                {
                    for (int i = 0; i < highlightedSquares.Count; i++)
                    {
                        if (row == highlightedSquares[i].Y / mySize && row == highlightedSquares[i].X / mySize)
                        {
                            currentlySelectedChecker.Row = highlightedSquares[i].Y / mySize;
                            currentlySelectedChecker.Column = highlightedSquares[i].X / mySize;
                            currentlySelectedChecker.movablePoints.Clear();
                            foreach (Checker checker in topCheckers)
                                checker.Movable = false;
                            foreach (Checker checker in bottomCheckers)
                                checker.Movable = false;
                            currentlySelectedChecker = null;
                            highlightedSquares.Clear();
                            return true;
                        }
                        else
                        {
                            if (i == highlightedSquares.Count - 1)
                            {
                                currentlySelectedChecker = null;
                                highlightedSquares.Clear();
                            }
                        }
                    }
                }
            }
            return false;
        }
        public int Columns
        {
            get
            {
                return myColumns;
            }
            set
            {
                myColumns = value;
            }
        }
        public int Rows
        {
            get
            {
                return myRows;
            }
            set
            {
                myRows = value;
            }
        }
        public int size
        {
            get
            {
                return mySize;
            }
            set
            {
                mySize = value;
            }
        }
    }
}