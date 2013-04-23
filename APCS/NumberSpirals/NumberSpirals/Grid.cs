using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberSpirals
{
    class Grid
    {
        public static GridPoint Spiral(int number, int t)
        {
            int[,] myGrid;
            int r = 0;
            int c = 0;
            bool done = false;
            double sqrt = Math.Sqrt(number);
            for (int i = (int)sqrt; !done; i--)
            {
                if (number % i == 0)
                {
                    done = true;
                    c = i;
                }
            }
            r = number / c;
            myGrid = new int[r, c];
            int direction = 0;
            int currentR = 0;
            int currentC = 0;
            for (int i = 1; i < myGrid.GetLength(0) * myGrid.GetLength(1) + 1; i++)
            {
                if (currentR >= myGrid.GetLength(0) || currentC >= myGrid.GetLength(1) || currentC < 0 || currentR < 0 || myGrid[currentR, currentC] != 0)
                {
                    switch (direction)
                    {
                        case 0: currentC--; currentR++; break;
                        case 1: currentR--; currentC--; break;
                        case 2: currentC++; currentR--; break;
                        case 3: currentR++; currentC++; break;
                    }
                    direction = (direction+1) % 4;
                }
                if (i == t)
                    return new GridPoint(currentR + 1, currentC + 1);
                myGrid[currentR, currentC] = i;
                switch (direction)
                {
                    case 0: currentC++; break;
                    case 1: currentR++; break;
                    case 2: currentC--; break;
                    case 3: currentR--; break;
                }
            }
            return new GridPoint(0, 0);
        }
    }
}
