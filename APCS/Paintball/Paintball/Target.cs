using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paintball
{
    class Target
    {
        public Direction currentDirection;
        public int moveProgress;
        public int moveGoal;
        private Rectangle myRectangle;
        private Image myImage;
        private Color myColor;
        private Rectangle myBounds;
        private int mySpeed;
        private DateTime myBirth;
        private DateTime myDeath;
        public enum Direction { Left, Right, Up, Down };
        private int myLives;
        private bool death = false;

        public Target(Rectangle size, Image image, Rectangle bounds, int speed, int lives)
        {
            myRectangle = size;
            myImage = image;
            myBounds = bounds;
            mySpeed = speed;
            myBirth = DateTime.Now;
            myLives = lives;
            moveGoal = 0;
            moveProgress = 0;
        }

        public Target(Rectangle size, Color color, Rectangle bounds, int speed, int lives)
        {
            myRectangle = size;
            myColor = color;
            myBounds = bounds;
            mySpeed = speed;
            myBirth = DateTime.Now;
            myLives = lives;
            moveProgress = 0;
            moveGoal = 0;
        }

        public void Paint(Graphics g)
        {
            if (myImage == null)
            {
                SolidBrush colorBrush = new SolidBrush(myColor);
                g.FillRectangle(colorBrush, myRectangle);
            }
            else
            {
                g.DrawImage(myImage, myRectangle);
            }
        }

        public void Move(Direction direction)
        {
            if (!death)
            {
                switch (direction)
                {
                    case Direction.Left:
                        if (myRectangle.X - mySpeed < myBounds.X) myRectangle.X = myBounds.X;
                        else myRectangle.Offset(-1 * mySpeed, 0);
                        break;
                    case Direction.Right:
                        if (myRectangle.X + mySpeed + myRectangle.Width > myBounds.X + myBounds.Width) myRectangle.X = myBounds.X + myBounds.Width - myRectangle.Width;
                        else myRectangle.Offset(mySpeed, 0);
                        break;
                    case Direction.Up:
                        if (myRectangle.Y - mySpeed < myBounds.Y)
                            myRectangle.Y = myBounds.Y;
                        else myRectangle.Offset(0, -1 * mySpeed);
                        break;
                    case Direction.Down:
                        if (myRectangle.Y + mySpeed + myRectangle.Height > myBounds.Y + myBounds.Height) myRectangle.Y = myBounds.Y + myBounds.Height - myRectangle.Height;
                        else myRectangle.Offset(0, mySpeed);
                        break;
                } 
            }
        }

        public bool ImHit(Point shot)
        {
            if (shot.X > myRectangle.X && shot.X < myRectangle.X + myRectangle.Width && shot.Y > myRectangle.Y && shot.Y < myRectangle.Y + myRectangle.Height)
            {
                myLives--;
                if (myLives == 0)
                {
                    myDeath = DateTime.Now;
                    death = true;
                    return true;
                }
            }
            return false;
        }

        public TimeSpan lifespan()
        {
            return myDeath - myBirth;
        }

        public Image targetImage
        {
            get
            {
                return myImage;
            }
            set
            {
                myImage = value;
            }
        }

        public int numberOfLives
        {
            get
            {
                return myLives;
            }
        }

        public int Speed
        {
            get
            {
                return mySpeed;
            }
            set
            {
                mySpeed = value;
            }
        }

        public Point Location
        {
            get
            {
                return myRectangle.Location;
            }
            set
            {
                myRectangle.Location = value;
            }
        }

        public Size Size
        {
            get
            {
                return myRectangle.Size;
            }
            set
            {
                myRectangle.Size = value;
            }
        }

        public Rectangle Rectangle
        {
            get
            {
                return myRectangle;
            }
        }
    }
}
