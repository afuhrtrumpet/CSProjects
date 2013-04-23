using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        private int layerCount = 1;
        private int currentLayer = 0;
        private Image myImage;
        private List<List<Shape>> shapes = new List<List<Shape>>();
        private int currentShape = 0;
        private bool trails = false;
        private bool drag = false;
        private Bitmap background;
        /// <summary>
        /// Initializes and sets values for the components of form 1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            //Background sparkles

            //int cols = canvas.Width;
            //int rows = canvas.Height;
            //Color shade = Color.White;
            //System.Random rnd = new System.Random();
            //background = new Bitmap(cols, rows);

            //for (int c = 0; c < cols; c++)
            //{
            //    for (int r = 0; r < rows; r++)
            //    {
            //        shade = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            //        background.SetPixel(c, r, shade);
            //    }
            //}
            listBox1.SelectedIndex = 0;
            numericUpDownBlue.Value = 0;
            numericUpDownGreen.Value = 0;
            numericUpDownRed.Value = 0;
            shapes.Add(new List<Shape>());
        }
        /// <summary>
        /// Adds a shape to mouse position and turns on drag.
        /// </summary>
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //TODO: Capture the starting point for the shape, create the shape object and add 
            //		it to the list of shapes.
            switch (currentShape)
            {
                case 0: shapes[currentLayer].Add(new Line(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y, 
                    label2.BackColor)); break;
                case 1: shapes[currentLayer].Add(new Oval(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y, label2.BackColor)); break;
                case 2: shapes[currentLayer].Add(new Box(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y, label2.BackColor)); break;
                case 3: shapes[currentLayer].Add(new Picture(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y,
                    Shapes.Properties.Resources.hkdawg, label2.BackColor)); break;
                case 4: shapes[currentLayer].Add(new Picture(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y,
                myImage, label2.BackColor)); break;
            }
            drag = true;
            Refresh();
        }
        /// <summary>
        /// Turns off drag.
        /// </summary>
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            //TODO: Capture the ending point, update the last shape in the list and refresh the screen.
            drag = false;
        }
        /// <summary>
        /// Paints all the shapes in each layer and their opacities.
        /// </summary>
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Draw background sparkles
            //g.DrawImage(background, 0, 0);

            //TODO: Loop thru the shapes list and tell each shape to draw itself.
            foreach (List<Shape> list in shapes)
                foreach (Shape shape in list)
                    shape.draw(g);
        }
        /// <summary>
        /// Changes the shape or clears the layer depending on the character pressed.r
        /// </summary>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Convert.ToChar(e.KeyChar.ToString().ToLower()))
            {
                case 't': trails = !trails; break;
                case 'c': shapes[currentLayer].Clear(); Refresh(); break;
                case 'l': currentShape = 0; break;
                case 'o': currentShape = 1; break;
                case 'r': currentShape = 2; break;
                case 'h': currentShape = 3; break;
                case 'i': DialogResult result = imageDialog.ShowDialog();
                    if (result != DialogResult.Cancel)
                    {
                        string fileChoice = imageDialog.FileName;
                        myImage = Image.FromFile(fileChoice);
                        currentShape = 4; 
                    }break;
            }
        }
        /// <summary>
        /// Sets location of current shape if trails are disabled, creates new shape from original and current mouse position if trails are enabled.
        /// </summary>
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //TODO: Capture the mouse location and if trails are on add a new shape to the list each time.
            if (drag)
            {
                if (trails)
                {
                    if (shapes.Count != 0)
                    {
                        switch (currentShape)
                        {
                            case 0: shapes[currentLayer].Add(new Line(shapes[currentLayer][shapes[currentLayer].Count - 1].getX1(), shapes[currentLayer][shapes[currentLayer].Count - 1].getY1(),
                                e.Location.X, e.Location.Y, label2.BackColor)); break;
                            case 1: shapes[currentLayer].Add(new Oval(shapes[currentLayer][shapes[currentLayer].Count - 1].getX1(), shapes[currentLayer][shapes[currentLayer].Count - 1].getY1(),
                                e.Location.X, e.Location.Y, label2.BackColor)); break;
                            case 2: shapes[currentLayer].Add(new Box(shapes[currentLayer][shapes[currentLayer].Count - 1].getX1(), shapes[currentLayer][shapes[currentLayer].Count - 1].getY1(),
                                e.Location.X, e.Location.Y, label2.BackColor)); break;
                            case 3: shapes[currentLayer].Add(new Picture(shapes[currentLayer][shapes[currentLayer].Count - 1].getX1(), shapes[currentLayer][shapes[currentLayer].Count - 1].getY1(),
                                e.Location.X, e.Location.Y,
                    Shapes.Properties.Resources.hkdawg, label2.BackColor)); break;
                            case 4: shapes[currentLayer].Add(new Picture(shapes[currentLayer][shapes[currentLayer].Count - 1].getX1(), shapes[currentLayer][shapes[currentLayer].Count - 1].getY1(), e.Location.X, e.Location.Y,
            myImage, label2.BackColor)); break;
                        }
                        Refresh();
                    }
                }
                else
                {
                    if (shapes.Count != 0)
                    {
                        shapes[currentLayer][shapes[currentLayer].Count - 1].setX2(e.Location.X);
                        shapes[currentLayer][shapes[currentLayer].Count - 1].setY2(e.Location.Y); 
                    }
                    Refresh();
                }
            }
        }
        /// <summary>
        /// Sets the red value of the current color.
        /// </summary>
        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
        }
        /// <summary>
        /// Sets the green value of the current color. 
        /// </summary>
        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
        }
        /// <summary>
        /// Sets the blue value of the current color.
        /// </summary>
        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
        }
        /// <summary>
        /// Adds a new layer.
        /// </summary>
        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            shapes.Add(new List<Shape>());
            listBox1.Items.Add("");
            currentLayer = listBox1.Items.Count - 1;
            listBox1.Items[listBox1.Items.Count - 1] = "Layer " + layerCount;
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox1.Refresh();
            layerCount++;
        }
        /// <summary>
        /// Deletes currently selected layer.
        /// </summary>
        private void btnDeleteLayer_Click(object sender, EventArgs e)
        {
            if (shapes.Count != 1)
            {
                shapes.RemoveAt(currentLayer);
                listBox1.Items.RemoveAt(currentLayer);
                listBox1.Refresh();
                if (currentLayer - 1 >= 0)
                    currentLayer -= 1;
                else currentLayer = 0;
                listBox1.SelectedIndex = currentLayer;
                Refresh();
            }
        }
        /// <summary>
        /// Updates the current layer.
        /// </summary>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLayer = listBox1.SelectedIndex;
        }
    }
}
