using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CricketCricketCricket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tempButton_Click(object sender, EventArgs e)
        {            
            int numberOfChirps = Convert.ToInt32(chirpNumber.Text);
            double seconds = Convert.ToInt32(time.Text);
            double temperature = (numberOfChirps / (seconds / 60) + 40) / 4;
            answer.Text = temperature.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
