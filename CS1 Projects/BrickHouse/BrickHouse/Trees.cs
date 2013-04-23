//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickHouse
{
    class Trees
    {
        public static void Paint(Graphics g, double width, double height, int bottomLeftX, int bottomLeftY, bool snow)
        {
            //Declare and initialize a point array containing values from one point multiplied by a size parameter.
            Point[] treePoints =
            {
                new Point(bottomLeftX - (int) (40 * width), bottomLeftY - (int) (20 * height)),
                new Point(bottomLeftX - (int) (20 * width), bottomLeftY - (int) (40 * height)),
                new Point(bottomLeftX - (int) (30 * width), bottomLeftY - (int) (40 * height)),
                new Point(bottomLeftX - (int) (10 * width), bottomLeftY - (int) (60 * height)),
                new Point(bottomLeftX - (int) (20 * width), bottomLeftY - (int) (60 * height)),
                new Point(bottomLeftX, bottomLeftY - (int) (80 * height)),
                new Point(bottomLeftX - (int) (10 * width), bottomLeftY - (int) (80 * height)),
                new Point(bottomLeftX + (int) (10 * width), bottomLeftY - (int) (100 * height)),
                new Point(bottomLeftX + (int) (30 * width), bottomLeftY - (int) (80 * height)),
                new Point(bottomLeftX + (int) (20 * width), bottomLeftY - (int) (80 * height)),
                new Point(bottomLeftX + (int) (40 * width), bottomLeftY - (int) (60 * height)),
                new Point(bottomLeftX + (int) (30 * width), bottomLeftY - (int) (60 * height)),
                new Point(bottomLeftX + (int) (50 * width), bottomLeftY - (int) (40 * height)),
                new Point(bottomLeftX + (int) (40 * width), bottomLeftY - (int) (40 * height)),
                new Point(bottomLeftX + (int) (60 * width), bottomLeftY - (int) (20 * height)),
                new Point(bottomLeftX - (int) (40 * width), bottomLeftY - (int) (20 * height)),
            };
            //Declare and initialize another point array for the snow on the tree.
            Point[] snowPoints =
            {
                treePoints[3],
                treePoints[4],
                treePoints[5],
                treePoints[6],
                treePoints[7],
                treePoints[8],
                treePoints[9],
                treePoints[10],
                treePoints[11],
                new Point(bottomLeftX + (int) (20 * width), bottomLeftY - (int) (50 * height)),
                new Point(bottomLeftX + (int) (10 * width), bottomLeftY - (int) (60 * height)),
                new Point(bottomLeftX, bottomLeftY - (int) (50 * height)),
                treePoints[3],
            };
            //Paint tree using array and size, as well as snow if specified.
            g.FillPolygon(Brushes.Green, treePoints);
            g.FillRectangle(Brushes.Brown, bottomLeftX, bottomLeftY - (int)(20 * height), (int)(20 * width), (int)(20 * height));
            if (snow)
            {
                g.FillPolygon(new SolidBrush(Color.FromArgb(200, Color.WhiteSmoke)), snowPoints);
            }
        }
    }
}
