using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paintball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn2ps_Click(object sender, EventArgs e)
        {
            Short2P newForm = new Short2P();
            newForm.Show();
        }

        private void btn1pa_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Do you have what it takes to stop the rapidly reproducing amoeba? It's time to find out.";
        }

        private void btn1pe_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Stop bombs using... paintballs? Yeah, it doesn't make much sense, but it's fun.";
        }

        private void btn2ps_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Just basic shoot-the-runner action.";
        }

        private void btn2pl_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Power-ups and lives make for a lengthy and hectic 2-player game.";
        }

        private void btn2pl_Click(object sender, EventArgs e)
        {
            Long2P newForm = new Long2P();
            newForm.Show();
        }

        private void btn1pa_Click(object sender, EventArgs e)
        {
            Amoeba newForm = new Amoeba();
            newForm.Show();
        }

        private void btn1pe_Click(object sender, EventArgs e)
        {
            Endless newForm = new Endless();
            newForm.Show();
        }
    }
}
