using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        private int sheenNumber;
        private bool gameInProgress;
        private bool gamePaused;
        private PongGame itsPong;
        /// <summary>
        /// Initializes form components and starts a new game.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            newGame();
        }
        /// <summary>
        /// Initializes pong game, sets boolean variables to false, and sets the selected index of listbox to 0.
        /// </summary>
        private void newGame()
        {
            itsPong = new PongGame(2, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            gameInProgress = false;
            gamePaused = false;
            timer1.Enabled = false;
            listBox1.SelectedIndex = 0;
        }
        /// <summary>
        /// Sets game components
        /// </summary>
        private void startGame()
        {
            itsPong.setGravity(checkBox1.Checked);
            sheenNumber = (int)numericUpDown1.Value;
            gameInProgress = true;
            timer1.Enabled = true;
        }
        /// <summary>
        /// Paints the components of the game.
        /// </summary>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            itsPong.Paint(g);
        }
        /// <summary>
        /// Moves elements in the pong game, updates score labels, and checks to see if either player has won.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            itsPong.Move();
            int firstScore = itsPong.getScore(0);
            int secondScore = itsPong.getScore(1);
            label2.Text = "" + firstScore;
            label3.Text = "" + secondScore;
            if (firstScore >= sheenNumber)
            {
                newGame();
                MessageBox.Show("Player 1 wins!");
            }
            if (secondScore >= sheenNumber)
            {
                newGame();
                MessageBox.Show("Player 2 wins!");
            }
            pictureBox1.Refresh();
        }
        /// <summary>
        /// Handles various key inputs.
        /// </summary>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
                if (!gameInProgress)
                    startGame();
            if (e.KeyData == Keys.Left || e.KeyData == Keys.A)
                itsPong.ChangePlayaDirection(0);
            if (e.KeyData == Keys.Right || e.KeyData == Keys.L)
                itsPong.ChangePlayaDirection(1);
            if (e.KeyData == Keys.N)
                newGame();
            if (e.KeyData == Keys.P)
                if (gameInProgress)
                {
                    timer1.Enabled = !timer1.Enabled;
                    gamePaused = !gamePaused;
                    itsPong.setMotionBlur(checkBox2.Checked);
                    Refresh();
                }
        }
        /// <summary>
        /// Changes graphical style to that of the box's selected index.
        /// </summary>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gamePaused || !gameInProgress)
            {
                switch (listBox1.SelectedIndex)
                {
                    case 0: itsPong.resetGraphicalStyle(); pictureBox1.BackgroundImage = null; label2.BackColor = Color.Black;
                        label3.BackColor = Color.Black; label2.ForeColor = Color.White; label3.ForeColor = Color.White; break;
                    case 1: itsPong.changeGraphicalStyle(Pong.Properties.Resources.paddle, Pong.Properties.Resources.ball);
                        pictureBox1.BackgroundImage = Pong.Properties.Resources.grid1; label2.BackColor = Color.White;
                        label3.BackColor = Color.White; label2.ForeColor = Color.Black; label3.ForeColor = Color.Black; break;
                    case 2: itsPong.changeGraphicalStyle(Pong.Properties.Resources.neonpaddle, Pong.Properties.Resources.neonball);
                        pictureBox1.BackgroundImage = null; label2.BackColor = Color.Black; label3.BackColor = Color.Black;
                        label2.ForeColor = Color.Orange; label3.ForeColor = Color.Orange; break;
                }
                Refresh(); 
            }
        }
        /// <summary>
        /// Enables or disables motion blur based on check box's value.
        /// </summary>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (gamePaused || !gameInProgress)
            {
                itsPong.setMotionBlur(checkBox2.Checked);
                Refresh();
            }
        }
    }
}
