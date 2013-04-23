using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SlidePuzzle
{
    class Tile
    {
        /*
         * Attributes:
         *      Size
         *      Location
         *      Image
         *      int myValue;
         * Behaviors:
         *      paint (Graphics g)
         *      setLocation (Location newLoc)
         *      getValue()
         */
        private Size mySize;
        private Location myLocation;
        private Image myImage;
        private int myValue;

        public Tile(Size size, Location location, Image tileImage, int value)
        {
            //Initialize instance variables.
            mySize = size;
            myLocation = location;
            myImage = tileImage;
            myValue = value;
        }

        public void Paint(Graphics g)
        {
            //Draw tile.
            g.DrawImage(myImage, new Point(mySize.Width * myLocation.getRow(), mySize.Height * myLocation.getCol()));
        }

        public int getValue()
        {
            //Return tile value.
            return myValue;
        }

        public void setLocation(Location newLoc)
        {
            //Set location to parameter.
            myLocation = newLoc;
        }
    }
}
