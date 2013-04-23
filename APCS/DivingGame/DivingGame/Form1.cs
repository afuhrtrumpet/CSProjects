using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DivingGame
{
    public partial class Form1 : Form
    {
        private Cave myCave;
        public Form1()
        {
            InitializeComponent();
            myCave = new Cave();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewCave_Click(object sender, EventArgs e)
        {
            int seed;
            if (txtSeed.Text.Equals(""))
            {
                myCave = new Cave();
                Refresh();
            }
            else if (int.TryParse(txtSeed.Text, out seed))
            {
                myCave = new Cave(seed);
                Refresh();
            }
            else
            {
                MessageBox.Show("Invalid seed value!");
            }
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            int maxDepthRating;
            if (int.TryParse(txtDepth.Text, out maxDepthRating))
            {
                lblPrayers.Visible = !myCave.tryEscape(maxDepthRating, 0, 0);
                Refresh();
            }
            else
            {
                MessageBox.Show("Invalid depth value!");
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            myCave.Paint(g);
        }
    }
}
