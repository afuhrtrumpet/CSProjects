using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordMastermind
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 game;
            if (checkBox1.Checked)
                game = new Form1((int) numericUpDown1.Value, "p:\\LATIN.dat");
            else game = new Form1((int) numericUpDown1.Value, "p:\\wordlist2.txt");
            game.Show();
        }
    }
}
