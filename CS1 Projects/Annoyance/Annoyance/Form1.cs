using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Annoyance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_MouseEnter(object sender, EventArgs e)
        //{
        //    Random generator = new Random();
        //    Cursor.Position = new Point(generator.Next(1000), generator.Next(1000));
        //}

        //private void Form1_MouseHover(object sender, EventArgs e)
        //{
        //    Random generator = new Random();
        //    Cursor.Position = new Point(generator.Next(1000), generator.Next(1000));
        //}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) Cursor.Position.Offset(0, -5);
            if (e.KeyData == Keys.Down) Cursor.Position.Offset(0, 5);
            if (e.KeyData == Keys.Right) Cursor.Position.Offset(5, 0);
            if (e.KeyData == Keys.Left) Cursor.Position.Offset(-5, 0);
        }
    }
}
