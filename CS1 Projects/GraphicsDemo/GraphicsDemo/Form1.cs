using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Boxes b = new Boxes();
            b.paint(g);
            WordsAndLines wl = new WordsAndLines();
            wl.paint(g);
            OtherShapes o = new OtherShapes();
            o.paint(g);
            StringBeads.paint(g);
        }
    }
}
