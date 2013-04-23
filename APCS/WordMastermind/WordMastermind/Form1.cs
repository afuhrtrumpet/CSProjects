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
    public partial class Form1 : Form
    {
        private const int MAX_TURNS = 9;
        private int myWordSize;

        private System.Drawing.Color[] myColorTable = 
		    {Color.White,			//bad guess
		     Color.Yellow,			//almost
		     Color.LightGreen};	    //correct


        private Size guessBoxSize = new Size(40, 40);

        private Label[,] guesses;

        private WordMastermindGame myGame;
        private int currentRow;

        public Form1(int wordSize, string wordFileName)
        {
            myWordSize = wordSize;   
            InitializeComponent();
            label1.Text = "Enter a " + myWordSize + "-letter word";
            myGame = new WordMastermindGame(wordFileName, MAX_TURNS, myWordSize);
            buildLabels();
            newGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text.ToLower();
            if (textBox1.Text.Length != myWordSize)
            {
                MessageBox.Show("Your word must have " + myWordSize + " letters.");
                textBox1.SelectAll();
            }
            else if (!myGame.isValidWord(textBox1.Text))
            {
                MessageBox.Show("Please enter a valid word.");
                textBox1.SelectAll();
            }
            else
            {
                int[] colorArray = myGame.makeGuess(textBox1.Text);
                for (int i = 0; i < myWordSize; i++)
                {
                    guesses[currentRow, i].Text = guess[i].ToString();
                    guesses[currentRow, i].BackColor = myColorTable[colorArray[i]];
                }
                currentRow++;
                for (int i = 0; i < colorArray.Length; i++)
                {
                    if (colorArray[i] != 2)
                        break;
                    if (i == colorArray.Length - 1)
                    {
                        DialogResult result = MessageBox.Show("Play again?", "You win!", MessageBoxButtons.YesNo);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                            newGame();
                        else Close();
                    }
                }
                if (myGame.outOfGuesses())
                {
                    DialogResult result = MessageBox.Show("The secret word was " + myGame.getSecretWord() + ". Try again?", "Game over!", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                        newGame();
                    else Close();
                }
                textBox1.SelectAll();
            }
        }

        private void newGame()
        {
            myGame.newGame();
            foreach (Label guess in guesses)
            {
                guess.Text = "";
                guess.BackColor = Color.White;
            }
            currentRow = 0;
#if DEBUG
            label5.Text = myGame.getSecretWord();
#endif
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWrong.BackColor = myColorTable[0];
            lblAlmost.BackColor = myColorTable[1];
            lblCorrect.BackColor = myColorTable[2];
        }

        private void buildLabels()
        {
            this.SuspendLayout();
            guesses = new Label[MAX_TURNS, myWordSize];
            int labelSize = myWordSize > 6 ? (groupBox1.Size.Width / myWordSize) - 5 - (int)6/myWordSize: 40;
            for (int r = 0; r < MAX_TURNS; r++)
            {
                for (int c = 0; c < myWordSize; c++)
                {
                    guesses[r, c] = new Label();
                    this.groupBox1.Controls.Add(guesses[r, c]);
                    guesses[r, c].BackColor = System.Drawing.Color.White;
                    guesses[r, c].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    guesses[r, c].Location = new System.Drawing.Point(c * (labelSize + 5) + 6, r * (labelSize + 5) + 16);
                    guesses[r, c].Name = "label5";
                    guesses[r, c].Size = new System.Drawing.Size(labelSize, labelSize);
                    guesses[r, c].TabIndex = 0;
                    guesses[r, c].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                }
            }
        }

    }
}
