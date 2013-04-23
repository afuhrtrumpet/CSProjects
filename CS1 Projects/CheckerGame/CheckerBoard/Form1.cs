using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckerBoard
{
    public partial class Form1 : Form
    {
        private Board.Players currentPlayer = Board.Players.TOP;
        private static int squareSize = 50;
        private static int columns = 8;
        private static int rows = 8;
        Board myBoard = new Board(squareSize, columns, rows,
            Brushes.Green, Brushes.Red,
            Brushes.Honeydew, Brushes.CornflowerBlue);
        public Form1()
        {
            InitializeComponent();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkSize();
            checkColumns();
            checkRows();
            pictureBox1.Invalidate();	// causes a paint event for the panel
            textBox1.SelectAll();	// selects the text for easy replacement
            myBoard = new Board(squareSize, columns, rows, Brushes.Green, Brushes.Red, Brushes.Honeydew, Brushes.CornflowerBlue);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Make the canvas the right size.
            pictureBox1.Size = new Size(columns * squareSize, rows * squareSize);
            Graphics g = e.Graphics;
            myBoard.CheckMovableCheckers(currentPlayer);
            myBoard.Paint(g);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            checkSize();
            textBox1.SelectAll();	// selects the text for easy replacement
        }

        // Process the board size input.
        // If the input value is good, reset the instance variable
        // squareSize to the new value.
        private void checkSize()
        {
            try
            {
                int num = Convert.ToInt32(textBox1.Text);
                if (num < 1 || num > 1000)
                {
                    MessageBox.Show("Enter a number between 1 and 1000.");
                    textBox1.Focus();	// put the cursor back in the text box.
                    textBox1.SelectAll();
                }
                else
                {
                    squareSize = num;	// input is good, so update the instance variable
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a valid whole number!");
            }
        }
        private void checkColumns()
        {
            try
            {
                int num = Convert.ToInt32(textBox2.Text);
                if (num % 2 == 1)
                {
                    MessageBox.Show("Enter an even number.");
                    textBox1.Focus();	// put the cursor back in the text box.
                    textBox1.SelectAll();
                }
                else
                {
                    columns = num;	// input is good, so update the instance variable
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a valid whole number!");
            }
        }
        private void checkRows()
        {
            try
            {
                int num = Convert.ToInt32(textBox3.Text);
                rows = num;	// input is good, so update the instance variable
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a valid whole number!");
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point clickPoint = e.Location;
            bool nextTurn = myBoard.Click(clickPoint);
            if (nextTurn)
            {
                if (currentPlayer == Board.Players.TOP) currentPlayer = Board.Players.BOTTOM;
                else currentPlayer = Board.Players.TOP;
            }
            Refresh();
        }
    }
}
