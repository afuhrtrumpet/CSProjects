using System;
using System.Windows.Forms;

namespace PostfixCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;

            string postfixExpr = txtPostfix.Text.Trim();
            if (postfixExpr.Length == 0)
            {
                MessageBox.Show("Enter a stinkin' expression!");
                return;
            }

            lblExpression.Text = (postfixExpr);
            txtPostfix.Text = ("");
            lblAnswer.Text = ("");

            try
            {
                result = ExpressionUtils.postfixCalc(postfixExpr);
                lblAnswer.Text = ("" + result);
                pictureBox1.BackgroundImage = null;
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Invalid numeric input!", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                pictureBox1.BackgroundImage = null;
            }

            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Unbalanced equation!  Too many operators.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                pictureBox1.BackgroundImage = null;
            }

            catch (System.DivideByZeroException ex)
            {
                MessageBox.Show("Can't divide by zero, idiot!", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                pictureBox1.Image = PostfixCalculator.Properties.Resources.naan_bread;
            }

            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                pictureBox1.BackgroundImage = null;
            }


        }
    }
}
