using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DivingGame
{
    class CaveCell
    {
        private static Color[] cellColors =
        {
            Color.FromArgb(180, 0, 0),
            Color.FromArgb(0, 0, 180),
            Color.FromArgb(0, 0, 160),
            Color.FromArgb(0, 0, 140),
            Color.FromArgb(0, 0, 120),
            Color.FromArgb(0, 0, 100),
            Color.FromArgb(0, 0, 80),
            Color.FromArgb(0, 0, 60),
            Color.FromArgb(0, 0, 40),
            Color.FromArgb(0, 0, 20),
            Color.FromArgb(0, 0, 0)
        };
        private byte myDepth;
        private bool highlighted;
        private Rectangle myRectogram;

        public CaveCell(byte depth, Rectangle rectogram)
        {
            myRectogram = rectogram;
            myDepth = depth;
            highlighted = false;
        }

        public void Paint(Graphics g)
        {
            Brush cellBrush = highlighted ? Brushes.Red : new SolidBrush(cellColors[myDepth]);
            g.FillRectangle(cellBrush, myRectogram);
            g.DrawString(myDepth.ToString(), new Font("Times New Roman", 8f), Brushes.White, myRectogram.Location);
        }

        public void setHighlighted(bool value) { highlighted = value; }

        public byte getDepth() { return myDepth; }
    }
}
