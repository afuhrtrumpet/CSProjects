using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DivingGame
{
    class Cave
    {
        private CaveCell[,] caveGrid;

        public Cave()
        {
            caveGrid = new CaveCell[10,10];
            Random gen = new Random();
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    caveGrid[r,c] = new CaveCell((byte)gen.Next(1, 11), new Rectangle(40 * c, 40 * r, 40, 40));
                }
            }
        }

        public Cave(int randomSeed)
        {
            caveGrid = new CaveCell[10, 10];
            Random gen = new Random(randomSeed);
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    caveGrid[r,c] = new CaveCell((byte)gen.Next(1, 11), new Rectangle(40 * c, 40 * r, 40, 40));
                }
            }
        }

        public void Paint(Graphics g)
        {
            foreach (CaveCell cell in caveGrid)
            {
                cell.Paint(g);
            }
        }

        private void resetTiles()
        {
            foreach (CaveCell tile in caveGrid)
            {
                tile.setHighlighted(false);
            }
        }

        public bool tryEscape (int maxDepthRating, int r, int c)
        {
            resetTiles();
            try
            {
                if (caveGrid[r,c].getDepth() <= maxDepthRating)
                {
                    if (r == caveGrid.GetLength(0) - 1 && c == caveGrid.GetLength(1) - 1)
                    {
                        caveGrid[r, c].setHighlighted(true);
                        return true;
                    }
                    else
                    {
                        if (tryEscape(maxDepthRating, r, c + 1))
                        {
                            caveGrid[r, c].setHighlighted(true);
                            return true;
                        }
                        else
                        {
                            bool value = tryEscape(maxDepthRating, r + 1, c);
                            caveGrid[r, c].setHighlighted(value);
                            return value;
                        }
                    }
                }
                else
                    return false;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
    }
}
