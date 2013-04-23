using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Pong
{
    class PongGame
    {
        /*
         * Attributes:
         *      List of players
         *      List of balls
         *      List of movables (reference same object)
         *      
         * Behaviors:
         *      newGame()
         *      move()
         *      paint()
         *      changePlayerDirection(int playerNumber)
         *      getScore(int playerNumber)
         */
        bool blur = false;
        bool gravity = false;
        int moveCount = 0;
        private Image ballImage;
        private Rectangle myBounds;
        private Random randGen;
        private Player[] myPlayas;
        private List<Ball> balls;
        private List<Movable> movables;
        private const double GRAVITY = .98;
        /// <summary>
        /// Constructs a pong game.
        /// </summary>
        /// <param name="playerNumber">Number of players.</param>
        /// <param name="bounds">A rectangle representing the game's bounds.</param>
        public PongGame(int playerNumber, Rectangle bounds)
        {
            myBounds = bounds;
            balls = new List<Ball>();
            movables = new List<Movable>();
            randGen = new Random();
            myPlayas = new Player[playerNumber];
            for (int i = 0; i < playerNumber; i++)
            {
                switch (i)
                {
                    case 0: myPlayas[i] = new Player(new Rectangle(bounds.Location.X + 5, bounds.Location.Y, 10, 40), bounds); break;
                    case 1: myPlayas[i] = new Player(new Rectangle(bounds.Location.X + bounds.Width - 15, bounds.Location.Y, 10, 40), bounds); break;
                    default: throw new ArgumentException();
                }
            }
            addBall();
            foreach (Player playa in myPlayas)
                movables.Add(playa);
            foreach (Ball ball in balls)
                movables.Add(ball);
        }
        /// <summary>
        /// Paints all components of the game.
        /// </summary>
        /// <param name="g">The graphics object which the components are painted on.</param>
        public void Paint(Graphics g)
        {
            foreach (Movable movable in movables)
                movable.paint(g);
        }
        /// <summary>
        /// Moves all components of the game and detects if the balls have gone out of bounds.
        /// Also adds new balls depending on move count.
        /// </summary>
        public void Move()
        {
            List<int> removeIndexes = new List<int>();
            for (int i = 0; i < movables.Count; i++)
            {
                if (movables[i] is Ball)
                {
                    Ball tempBall = (Ball)movables[i];
                    Rectangle tempRectogram = tempBall.acquireRectogram();
                    //Check for collision with paddles.
                    if (new Rectangle(new Point(tempRectogram.X + tempBall.getDeltaX(), tempRectogram.Y), tempRectogram.Size).IntersectsWith(myPlayas[0].acquireRectogram()) ||
                        new Rectangle(new Point(tempRectogram.X + tempBall.getDeltaX(), tempRectogram.Y), tempRectogram.Size).IntersectsWith(myPlayas[1].acquireRectogram()))
                        tempBall.changeDirection(0);
                    //Handles collisions with the left or right bounds.
                    int result = movables[i].move();
                    if (result != -1)
                    {
                        myPlayas[result].addScore();
                        removeIndexes.Add(i);
                    }
                }
                else movables[i].move();
            }
            moveCount++;
            //Removes indexes of movable selected for removal and adds new balls to take their place.
            foreach (int index in removeIndexes)
            {
                if (movables[index] is Ball)
                    balls.Remove((Ball)movables[index]);
                movables.Remove(movables[index]);
                addBall();
                movables.Add(balls[balls.Count - 1]);
            }
            //Adds a new ball every 3000 moves.
            if (moveCount % 3000 == 0)
            {
                addBall();
                movables.Add(balls[balls.Count - 1]);
            }
        }
        /// <summary>
        /// Changes the direction of the specified player.
        /// </summary>
        /// <param name="playerNumber">The index of the player that is to be changed.</param>
        public void ChangePlayaDirection(int playerNumber)
        {
            myPlayas[playerNumber].changeDirection();
        }
        /// <summary>
        /// Returns the score of the specified player.
        /// </summary>
        /// <param name="playerNumber">The index of the specified player.</param>
        /// <returns>The score of the specified player.</returns>
        public int getScore(int playerNumber)
        {
            return myPlayas[playerNumber].getScore();
        }
        /// <summary>
        /// Adds a ball to the game.
        /// </summary>
        private void addBall()
        {
            int deltaX, deltaY;
            while ((deltaX = randGen.Next(-2, 3)) == 0);
            while ((deltaY = randGen.Next(-2, 3)) == 0);
            balls.Add(new Ball(new Rectangle((myBounds.X + myBounds.Size.Width) / 2, (myBounds.Y + myBounds.Size.Height) / 2, 10, 10), myBounds,
                deltaX, deltaY, gravityLevel(), blur));
            if (ballImage != null)
                balls[balls.Count - 1].setImage(ballImage);
        }
        /// <summary>
        /// Sets images for all balls and players.
        /// </summary>
        /// <param name="newPlayaImage">The image that will represent the player.</param>
        /// <param name="newBallImage">The image that will represent the ball.</param>
        public void changeGraphicalStyle(Image newPlayaImage, Image newBallImage)
        {
            ballImage = newBallImage;
            foreach (Ball ball in balls)
                ball.setImage(ballImage);
            foreach (Player playa in myPlayas)
                playa.setImage(newPlayaImage);
        }
        /// <summary>
        /// Clears the image of all components, setting the graphical style to default.
        /// </summary>
        public void resetGraphicalStyle()
        {
            ballImage = null;
            foreach (Ball ball in balls)
                ball.resetGraphicalStyle();
            foreach (Player playa in myPlayas)
                playa.resetGraphicalStyle();
        }
        /// <summary>
        /// Turns gravity on or off.
        /// </summary>
        /// <param name="gravityValue">True if gravity is to be added.</param>
        public void setGravity(bool gravityValue)
        {
            gravity = gravityValue;
            foreach (Ball ball in balls)
                ball.setGravity(gravityLevel());
        }
        /// <summary>
        /// Returns the gravitational acceleration of the ball.
        /// </summary>
        /// <returns>The gravity constant if gravity is on, 0 if gravity is off.</returns>
        private double gravityLevel()
        {
            if (gravity)
                return GRAVITY;
            else return 0;
        }
        /// <summary>
        /// Turns motion blur on or off.
        /// </summary>
        /// <param name="blurValue">True if motion blur will be turned on.</param>
        public void setMotionBlur(bool blurValue)
        {
            blur = blurValue;
            foreach (Ball ball in balls)
                ball.setBlur(blurValue);
        }
    }
}
