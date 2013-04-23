using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paintball
{
    class BombTarget : Target
    {
        private int countdown = 8;
        public BombTarget(Rectangle size, Image image, Rectangle bounds, int speed, int lives)
            : base(size, image, bounds, speed, lives)
        {
        }
        public bool Tick()
        {
            if (countdown == 0)
                return true;
            countdown--;
            return false;
        }
        public int Countdown
        {
            get
            {
                return countdown;
            }
        }
    }
}
