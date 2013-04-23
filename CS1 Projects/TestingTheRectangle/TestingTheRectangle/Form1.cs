using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestingTheRectangle
{
    public partial class Form1 : Form
    {
        private DateTime timeThingy;
        private Random coords = new Random();
        private System.Drawing.Graphics canvas;
        private Rectangle r = new Rectangle(50, 50, 50, 70);
        private Rectangle r2 = new Rectangle(10, 20, 30, 40);
        private Pen p = new Pen(System.Drawing.Color.DarkRed, 3.0f);
        private Pen p2 = new Pen(System.Drawing.Color.DarkCyan, 10.0f);
        private Pen p3 = new Pen(System.Drawing.Color.Chocolate, 5.0f);
        public Form1()
        {
            InitializeComponent();
            Paint += new PaintEventHandler(Form1_Paint);
            Paint += new PaintEventHandler(Form1_Time);
        }
        private void Form1_Time(object sender, PaintEventArgs e)
        {
            timeThingy = DateTime.Now;
            time.Text = Convert.ToString(timeThingy);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            canvas = CreateGraphics();
            canvas.DrawLine(p, 20, 20, 200, 200);
            canvas.DrawRectangle(p2, r);
            canvas.DrawEllipse(p3, r2);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas.Clear(SystemColors.Control);
            canvas.DrawLine(p, coords.Next(500), coords.Next(500), coords.Next(600), coords.Next(600));
            r2.X = coords.Next(600);
            r2.Y = coords.Next(600);
            r.Offset(4, 5);
            Refresh();
        }
    }
}
