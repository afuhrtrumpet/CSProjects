using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paintball
{
    class Powerup
    {
        private Point myLocation;
        private Size mySize;
        public enum Type { Shrink, Confusion, SpeedUp };
        private Type myType;

        public Powerup(Point location, Size size, Type powerupType)
        {
            myLocation = location;
            mySize = size;
            myType = powerupType;
        }

        public Point Location
        {
            get
            {
                return myLocation;
            }
        }

        public Size PowerupSize
        {
            get
            {
                return mySize;
            }
        }

        public Type PowerType
        {
            get
            {
                return myType;
            }
        }

        public void Paint(Graphics g)
        {
            switch (myType)
            {
                case Type.Shrink: g.DrawImage(Paintball.Properties.Resources.shrinkpower, new Rectangle (myLocation, mySize)); break;
                case Type.Confusion: g.DrawImage(Paintball.Properties.Resources.confusepower, new Rectangle (myLocation, mySize)); break;
                case Type.SpeedUp: g.DrawImage(Paintball.Properties.Resources.speedpower, new Rectangle(myLocation, mySize)); break;
            }
        }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(myLocation, mySize);
            }
        }
    }
}
