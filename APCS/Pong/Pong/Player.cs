using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Pong
{
    class Player : Movable
    {
        /* Attributes:
         *      Score
         *      deltaY: negative up, positive down
         *      myRectogram
         *      myBounds
         *      
         * Behaviors:
         *      paint()
         *      getRectangle()
         *      move()
         *      addScore()
         *      changeDirection()
         *      getScore()
         */
        private Image myImage;
        private int myScore;
        private Rectangle myRectogram;
        private Rectangle myBounds;
        private int deltaY;
        /// <summary>
        /// Constructs the Player object.
        /// </summary>
        /// <param name="rectangle">A rectangle representing the player's location and size.</param>
        /// <param name="bounds">A rectangle representing the player's bounds.</param>
        public Player(Rectangle rectangle, Rectangle bounds)
        {
            myRectogram = rectangle;
            myBounds = bounds;
            myScore = 0;
            deltaY = 2;
        }
        /// <summary>
        /// Paints the player.
        /// </summary>
        /// <param name="g">The graphics object which the player is drawn on.</param>
        public void paint(Graphics g)
        {
            if (myImage == null)
                g.FillRectangle(Brushes.White, myRectogram);
            else g.DrawImage(myImage, myRectogram.Location);
        }
        /// <summary>
        /// Moves the player and detects collisions.
        /// </summary>
        /// <returns>Since no other class needs to know about collisions, this method just returns -1.</returns>
        public int move()
        {
            if (myRectogram.Location.Y + myRectogram.Size.Height + deltaY > myBounds.Height || myRectogram.Location.Y + deltaY < myBounds.Y)
            {
                changeDirection();
            }
            myRectogram.Offset(new Point(0, deltaY));
            return -1;
        }
        /// <summary>
        /// Returns a rectangle representing the player's location and size.
        /// </summary>
        /// <returns>A rectangle representing the player's location and size.</returns>
        public Rectangle acquireRectogram()
        {
            return myRectogram;
        }
        /// <summary>
        /// Changes the player's Y direction.
        /// </summary>
        public void changeDirection()
        {
            deltaY = -1 * deltaY;
        }
        /// <summary>
        /// Returns the player's score count.
        /// </summary>
        /// <returns>The player's score.</returns>
        public int getScore()
        {
            return myScore;
        }
        /// <summary>
        /// Increments the player's score.
        /// </summary>
        public void addScore()
        {
            myScore++;
        }
        /// <summary>
        /// Sets an image to represent the player.
        /// </summary>
        /// <param name="newImage">The new image to represent the player.</param>
        public void setImage(Image newImage)
        {
            myImage = newImage;
        }
        /// <summary>
        /// Clears the image so that the player's graphical style is reset.
        /// </summary>
        public void resetGraphicalStyle()
        {
            myImage = null;
        }
    }
}
