using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Pong
{
    class Ball : Movable
    {
        /*
         * Attributes:
         *      myRectogram
         *      myBounds
         *      deltaX
         *      deltaY
         *      
         * Behaviors:
         *      paint()
         *      move()
         *      changeDirection()
         */
        private bool myBlur;
        private Point[] myPreviousLocations;
        private Image myImage;
        private Rectangle myRectogram;
        private Rectangle myBounds;
        private int myDeltaX;
        private double myDeltaY;
        private double myGravity;
        /// <summary>
        /// Constructs the Ball object.
        /// </summary>
        /// <param name="rectogram">A rectangle representing the ball's location and size.</param>
        /// <param name="bounds">A rectangle representing the ball's bounds.</param>
        /// <param name="deltaX">The amount that the ball will move in the X direction.</param>
        /// <param name="deltaY">The amount that the ball will move in the Y direction.</param>
        /// <param name="gravity">The amount that Y velocity increments on each move.</param>
        /// <param name="blur">True if a motion blur is also painted with the ball.</param>
        public Ball(Rectangle rectogram, Rectangle bounds, int deltaX, int deltaY, double gravity, bool blur)
        {
            myRectogram = rectogram;
            myBounds = bounds;
            myDeltaX = deltaX;
            myDeltaY = deltaY;
            myGravity = gravity;
            myPreviousLocations = new Point[5];
            for (int i = 0; i < myPreviousLocations.Length; i++)
                myPreviousLocations[i].Offset(-1 * myRectogram.Width, -1 * myRectogram.Height);
            myBlur = blur;
        }
        /// <summary>
        /// Paints the ball and any corresponding motion blur.
        /// </summary>
        /// <param name="g">The graphics object that the ball will be painted on.</param>
        public void paint(Graphics g)
        {
            if (myImage == null)
            {
                g.FillEllipse(Brushes.White, myRectogram);
                if (myBlur)
                {
                    for (int i = 0; i < myPreviousLocations.Length; i++)
                        if (myPreviousLocations[i] != null)
                            g.FillEllipse(new SolidBrush(Color.FromArgb(40 + 40 * i, 255, 255, 255)), new Rectangle(myPreviousLocations[i], myRectogram.Size)); 
                }
            }
            else
            {
                g.DrawImage(myImage, myRectogram.Location);
                if (myBlur)
                {
                    for (int i = 0; i < myPreviousLocations.Length; i++)
                    {
                        if (myPreviousLocations[i] != null)
                        {
                            ImageAttributes attributes = new ImageAttributes();
                            ColorMatrix colorMatrix = new ColorMatrix();
                            colorMatrix.Matrix33 = .1F + .2F * i;
                            attributes.SetColorMatrix(colorMatrix);
                            g.DrawImage(myImage, new Rectangle(myPreviousLocations[i], myRectogram.Size), 0, 0, myRectogram.Size.Width, myRectogram.Size.Height, GraphicsUnit.Pixel, attributes);
                        }
                    } 
                }
            }
            
        }
        /// <summary>
        /// Moves the ball, increments velocity based on gravity, and checks and responds to the ball hitting the bounds.
        /// </summary>
        /// <returns>An integer representing the result of the move. -1 for no collision or collision with top and bottom,
        /// 0 for collision with the left edge, and 1 for collision with the right edge.</returns>
        public int move()
        {
            Point previousLoc = myRectogram.Location;
            myDeltaY += myGravity;
            //Detects collision with bottom.
            if (myRectogram.Location.Y + myRectogram.Size.Height + myDeltaY > myBounds.Height)
            {
                changeDirection(1);
                myRectogram.Y = myBounds.Bottom - myRectogram.Height;
            }
            //Detects collision with top.
            if (myRectogram.Location.Y + myDeltaY < myBounds.Y)
            {
                changeDirection(1);
                myRectogram.Y = 0;
            }
            //Detects collision with right side.
            if (myRectogram.Location.X + myRectogram.Size.Width + myDeltaX > myBounds.Width) 
            {
                return 1;
            }
            //Detects collision with left side.
            if (myRectogram.Location.X + myDeltaX < myBounds.X)
            {
                return 0;
            }
            myRectogram.Offset(new Point(myDeltaX, (int)myDeltaY));
            for (int i = 1; i < myPreviousLocations.Length; i++)
            {
                myPreviousLocations[i - 1] = myPreviousLocations[i];
            }
            myPreviousLocations[myPreviousLocations.Length - 1] = previousLoc;
            return -1;
        }
        /// <summary>
        /// Changes the ball's direction in the specified dimension.
        /// </summary>
        /// <param name="dimension">An integer specifying the dimension which is to be reversed (0 for X, 1 for Y).</param>
        public void changeDirection(int dimension)
        {
            switch (dimension)
            {
                case 0: myDeltaX *= -1; break;
                case 1: myDeltaY *= -1; break;
                default: throw new ArgumentException();
            }
        }
        /// <summary>
        /// Returns a rectangle representing the ball.
        /// </summary>
        /// <returns>A rectangle representing the ball.</returns>
        public Rectangle acquireRectogram()
        {
            return myRectogram;
        }
        /// <summary>
        /// Gives the ball's velocity in the X direction.
        /// </summary>
        /// <returns>The ball's velocity in the X direction.</returns>
        public int getDeltaX()
        {
            return myDeltaX;
        }
        /// <summary>
        /// Assigns an image to the ball.
        /// </summary>
        /// <param name="newImage">The new image of the ball.</param>
        public void setImage(Image newImage)
        {
            myImage = newImage;
        }
        /// <summary>
        /// Clears the image so that the default graphic is used.
        /// </summary>
        public void resetGraphicalStyle()
        {
            myImage = null;
        }
        /// <summary>
        /// Increases the ball's X speed by one pixel.
        /// </summary>
        public void incrementDeltaX()
        {
            if (myDeltaX > 0)
                myDeltaX++;
            else myDeltaX--;
        }
        /// <summary>
        /// Increases the ball's Y speed by one pixel.
        /// </summary>
        public void incrementDeltaY()
        {
            if (myDeltaY > 0)
                myDeltaY++;
            else myDeltaY--;
        }
        /// <summary>
        /// Changes the acceleration due to gravity.
        /// </summary>
        /// <param name="newValue">The new acceleration of the ball.</param>
        public void setGravity(double newValue)
        {
            myGravity = newValue;
        }
        /// <summary>
        /// Changes whether the motion blur is on or not.
        /// </summary>
        /// <param name="newValue"></param>
        public void setBlur(bool newValue)
        {
            myBlur = newValue;
        }
    }
}
