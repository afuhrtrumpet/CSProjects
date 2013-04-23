using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SlidePuzzle
{
    public partial class Form1 : Form
    {
        //Declare instance variables for a source image, image list, start time, move count, board, tile size, and a constant for rows/columns.
        private Image mySourceImage;
        private List<Image> myImages = new List<Image>();
        private DateTime startTime;
        private int moveCount = 0;
        private SlidePuzzleBoard myBoard;
        private Size tileSize;
        private const int rowsCols = 3;
        public Form1(Image sourceImage)
        {
            //Takes an image as a parameter and breaks it into tiles, also initializing other instance variables.
            InitializeComponent();
            mySourceImage = sourceImage;
            Bitmap image = new Bitmap(sourceImage);
            for (int i = 0; i < rowsCols; i++)
            {
                for (int j = 0; j < rowsCols; j++)
                {
                    myImages.Add(new Bitmap(image.Clone(new Rectangle(j * (image.Size.Width / rowsCols), i * (image.Size.Height / rowsCols), image.Size.Width / rowsCols, image.Size.Height / rowsCols), System.Drawing.Imaging.PixelFormat.DontCare)));
                } 
            }   
            tileSize = myImages[0].Size;
            myImages[myImages.Count - 1] = new Bitmap(tileSize.Width, tileSize.Height);
            pictureBox1.Width = rowsCols * tileSize.Width;
            pictureBox1.Height = rowsCols * tileSize.Height;
            startTime = DateTime.Now;
            myBoard = new SlidePuzzleBoard(myImages, rowsCols, rowsCols);
        }
        public Form1()
        {
            //Adds default images to the image list, and initializes instance variables.
            InitializeComponent();
            tileSize = tileImages.Images[0].Size;
            pictureBox1.Width = rowsCols * tileSize.Width;
            pictureBox1.Height = rowsCols * tileSize.Height;
            startTime = DateTime.Now;
            int i = 0;
            foreach (Image image in tileImages.Images)
            {
                myImages.Add(image);
                i++;
            }
            myBoard = new SlidePuzzleBoard(myImages, rowsCols, rowsCols);
        }

        private void Reset()
        {
            //Resets all instance variables to their starting value.
            moveCount = 0;
            tileSize = myImages[0].Size;
            myBoard = new SlidePuzzleBoard(myImages, rowsCols, rowsCols);
            startTime = DateTime.Now;
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Call the board's paint method.
            Graphics g = e.Graphics;
            myBoard.Paint(g);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Find row and column, then call the move method and check to see if move is valid.
            int row = e.Location.Y / tileSize.Height;
            int column = e.Location.X / tileSize.Width;
            if (myBoard.Move(row, column))
                moveCount++;
            Refresh();
            DialogResult selection = System.Windows.Forms.DialogResult.No;
            //If Winner() returns true, display message box asking if user wants to play again.
            if (myBoard.Winner())
            {
                selection = MessageBox.Show("Congratulations! You took " + (DateTime.Now - startTime) + " and " + moveCount + " moves to win. Play again?", "You won!", MessageBoxButtons.YesNo);
                if (selection == System.Windows.Forms.DialogResult.Yes)
                    Reset();
                else Close();
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Display source image in a new form only if one exists.
            if (mySourceImage == null)
                MessageBox.Show("If you can count, you already know the source image.");
            else
            {
                ImageViewer sourceImageViewer = new ImageViewer(mySourceImage);
                sourceImageViewer.Show();
            }
        }
    }
}
