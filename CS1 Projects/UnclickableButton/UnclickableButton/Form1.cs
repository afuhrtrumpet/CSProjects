using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnclickableButton
{
    public partial class Form1 : Form
    {
        private int timesMoved = 0;
        private Random randomLocations = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (timesMoved == 100)
            {
                button1.Text = "You're really bored...";
            }
            timesMoved++;
            button1.Location = new Point(randomLocations.Next(300 - 123), randomLocations.Next(300 - 23));
            Refresh();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Location = new Point(randomLocations.Next(300 - 123), randomLocations.Next(300 - 23));
            Refresh();
        }

    }
}
