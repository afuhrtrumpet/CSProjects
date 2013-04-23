using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickHouse
{
    class Door
    {
        public static void Paint(Graphics g, int x, int y, int width, int height, Brush doorBrush, Brush borderBrush, Brush doorKnobBrush, bool isArched, bool isDouble)
        {
            //Paint either arched or rectangular door based on boolean value.
            if (isArched == true)
            {
                g.FillPie(doorBrush, x, y, width, width, 180, 180);
                g.DrawArc(new Pen(borderBrush, 2), x, y, width, width, 180, 180);
                g.FillRectangle(doorBrush, x, y + width/2, width, height - width/2);
                Point[] points = {new Point(x, y+width/2), new Point(x, y+height), new Point(x+width, y+height), new Point(x+width, y+width/2)};
                g.DrawLines(new Pen(borderBrush, 2), points);
            }
            else
            {
                g.FillRectangle(doorBrush, x, y, width, height);
                g.DrawRectangle(new Pen(borderBrush, 2), x, y, width, height);
            }
            //Paint extra line and doorknob to make double door.
            if (isDouble == true)
            {
                g.DrawLine(new Pen(borderBrush, 2), x + width / 2, y, x + width / 2, y + height);
                g.FillEllipse(doorKnobBrush, x + width / 8, y + height / 2, 10, 10);
            }
            //Paint doorknob.
            g.FillEllipse(doorKnobBrush, x + width * 3 / 4, y + height / 2, 10, 10);
        }
    }
}
