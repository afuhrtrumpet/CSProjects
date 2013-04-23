using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IfDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            bool result = int.TryParse(textBox1.Text, out temp);
            if (!result)
            {
                MessageBox.Show("That's not a valid input!");
            }
            else if (temp <= 30)
            {
                MessageBox.Show("Est frigidum!");
            }
            else if (temp >= 90)
            {
                MessageBox.Show("Est calidissimum! Conare natare.");
            }
            else if (temp >= 60)
            {
                MessageBox.Show("Est calidum.");
            }
            else
            {
                MessageBox.Show("It's nice outside");
            }
            DialogResult yesOrNo = MessageBox.Show("Are you having fun?", "Anonymous Survey", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
            if (yesOrNo == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("That's good!");
            }
            else
            {
                Console.Beep(700, 2000);
                Console.Beep(300, 1000);
                MessageBox.Show("You have been deemed unworthy for this program.");
                Close();
            }
        }
    }
}
