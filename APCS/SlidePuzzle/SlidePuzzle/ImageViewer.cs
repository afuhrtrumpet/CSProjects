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
    public partial class ImageViewer : Form
    {
        private Image myImage;
        public ImageViewer(Image image)
        {
            //Set image variable, form size, and picture box size.
            InitializeComponent();
            myImage = image;
            this.Size = new Size(myImage.Width + 10, myImage.Height + 30);
            pictureBox1.Size = new Size(myImage.Width, myImage.Height);
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Paint image.
            Graphics g = e.Graphics;
            g.DrawImage(myImage, pictureBox1.Location);
        }
    }
}
