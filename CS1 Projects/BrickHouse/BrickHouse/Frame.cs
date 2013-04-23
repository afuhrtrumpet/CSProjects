using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BrickHouse
{
    class Frame
    {
        public static void Paint(Graphics g, string houseStyle)
        {
            //Create and assign texture brushes based on a string and paint.
            switch (houseStyle)
            {
                case "Brick":
                Bitmap bricks = new Bitmap(20, 20);
                Graphics g2 = Graphics.FromImage(bricks);
                g2.FillRectangle(Brushes.DarkRed, 0, 0, 20, 20);
                g2.DrawLine(new Pen(Brushes.Chocolate), new Point(0, 0), new Point(20, 0));
                g2.DrawLine(new Pen(Brushes.Chocolate), new Point(0, 10), new Point(0, 20));
                g2.DrawLine(new Pen(Brushes.Chocolate), new Point(0, 10), new Point(20, 10));
                g2.DrawLine(new Pen(Brushes.Chocolate), new Point(10, 0), new Point(10, 10));
                TextureBrush brickBrush = new TextureBrush(bricks);
                g.FillRectangle(brickBrush, 150, 210, 320, 240);
                break;
                case "Igloo":
                Bitmap iceBlocks = new Bitmap(20, 20);
                Graphics g3 = Graphics.FromImage(iceBlocks);
                g3.FillRectangle(Brushes.White, 0, 0, 20, 20);
                g3.DrawLine(new Pen(Brushes.LightGray), new Point(0, 0), new Point(20, 0));
                g3.DrawLine(new Pen(Brushes.LightGray), new Point(0, 10), new Point(0, 20));
                g3.DrawLine(new Pen(Brushes.LightGray), new Point(0, 10), new Point(20, 10));
                g3.DrawLine(new Pen(Brushes.LightGray), new Point(10, 0), new Point(10, 10));
                TextureBrush iceBrush = new TextureBrush(iceBlocks);
                g.FillPie(iceBrush, 150, 160, 320, 240, 180, 180);
                g.FillRectangle(iceBrush, 150, 270, 320, 180);
                break;
                case "Stone":
                Bitmap stoneBlocks = new Bitmap(20, 20);
                Graphics g4 = Graphics.FromImage(stoneBlocks);
                g4.FillRectangle(Brushes.Gray, 0, 0, 20, 20);
                g4.DrawLine(new Pen(Brushes.Black), new Point(0, 0), new Point(20, 0));
                g4.DrawLine(new Pen(Brushes.Black), new Point(0, 10), new Point(0, 20));
                g4.DrawLine(new Pen(Brushes.Black), new Point(0, 10), new Point(20, 10));
                g4.DrawLine(new Pen(Brushes.Black), new Point(10, 0), new Point(10, 10));
                TextureBrush stoneBrush = new TextureBrush(stoneBlocks);
                g.FillRectangle(stoneBrush, 150, 210, 320, 240);
                break;
                case "Log Cabin":
                Bitmap logs = new Bitmap(100, 20);
                Graphics g5 = Graphics.FromImage(logs);
                g5.FillRectangle(Brushes.SaddleBrown, 0, 0, 100, 20);
                g5.DrawLine(new Pen(Brushes.Black), new Point(0, 0), new Point(100, 0));
                g5.DrawLine(new Pen(Brushes.Black), new Point(0, 10), new Point(0, 20));
                g5.DrawLine(new Pen(Brushes.Black), new Point(0, 10), new Point(100, 10));
                g5.DrawLine(new Pen(Brushes.Black), new Point(50, 0), new Point(50, 10));
                g5.FillEllipse(Brushes.Black, 40, 5, 2, 2);
                g5.FillEllipse(Brushes.Black, 60, 5, 2, 2);
                g5.FillEllipse(Brushes.Black, 10, 15, 2, 2);
                g5.FillEllipse(Brushes.Black, 90, 15, 2, 2);
                TextureBrush logBrush = new TextureBrush(logs);
                g.FillRectangle(logBrush, 150, 210, 320, 240);
                break;
            }
        }
    }
}
