using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphicsDemo
{
    class WordsAndLines
    {
        public void paint(Graphics g)
        {
            g.DrawLine(new Pen(Color.PeachPuff, 5), 200, 200, 524, 400);
            g.DrawString("Hi.", new Font("Arial", 36, FontStyle.Bold), new SolidBrush(Color.FromArgb(5, 60, 0)), 200, 100);
            
        }
    }
}
