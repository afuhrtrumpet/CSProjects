using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            try
            {
                int times = int.Parse(tbxRolls.Text);
                if (times < 0)
                {
                    MessageBox.Show("No negative numbers!");
                    tbxRolls.SelectAll();
                }
                else
                {
                    int[] rollCounts = new int[11];
                    for (int i = 0; i < times; i++)
                    {
                        int sum = generator.Next(1, 7) + generator.Next(1, 7);
                        rollCounts[sum - 2]++;
                    }
                    lblResults.Text = "";
                    for (int i = 0; i < rollCounts.Length; i++)
                    {
                        lblResults.Text = lblResults.Text + (i + 2) + ") " + rollCounts[i] + "\n";
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input must be an integer.");
                tbxRolls.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Too long!");
                tbxRolls.SelectAll();
            }
        }
    }
}
