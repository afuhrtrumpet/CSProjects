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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            //Opens the slide puzzle form using the default constructor.
            Form1 slidePuzzle = new Form1();
            slidePuzzle.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Asks for user input and opens a slide puzzle if an image is selected.
            DialogResult result = imageDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                string fileChoice = imageDialog.FileName;
                Form1 slidePuzzle = new Form1(Image.FromFile(imageDialog.FileName));
                slidePuzzle.Show();
            }
        }
    }
}
