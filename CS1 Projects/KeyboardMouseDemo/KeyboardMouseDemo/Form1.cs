using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardMouseDemo
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Y HELLO THAR";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "KTHXBAI";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "The " + e.Button + " MUST BE kIlLeD aT " + e.Location;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            moveLabel(e.KeyData);
        }

        private void moveLabel(Keys key)
        {
            Point p = label2.Location;
            if (key == Keys.Right) p.Offset(50, 0);
            if (key == Keys.Left) p.Offset(-50, 0);
            if (key == Keys.Up) p.Offset(0, -50);
            if (key == Keys.Down) p.Offset(0, 50);
            label2.Location = p;
        }
    }
}
