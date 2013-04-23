using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeTester
{
    public partial class TreeDisplay : Form
    {
        private TreeADT myTree;
        public TreeDisplay(TreeADT tree)
        {
            InitializeComponent();
            myTree = tree;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            myTree.drawTree(g, pictureBox1.Width);
        }
    }
}
