using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickHouse
{
    class Smoke
    {
        //Declare instance fields.
        private Rectangle myCloud;
        private int myDarkness;
        public Smoke(Rectangle cloud, int darkness)
        {
            //Assign construction parameters to instance fields.
            myCloud = cloud;
            myDarkness = darkness;
        }
        public void Paint(Graphics g)
        {
            //Initialize brush based on darkness and paint.
            SolidBrush cloudBrush = new SolidBrush(Color.FromArgb(myDarkness, myDarkness, myDarkness));
            g.FillEllipse(cloudBrush, myCloud);
        }
        public void Move(int x, int y)
        {
            //Offset cloud based on specified values.
            myCloud.Offset(x, y);
        }
        public void Reset(int x, int y)
        {
            //Set cloud to a specific location.
            myCloud.Location = new Point(x, y);
        }
        public int GetY()
        {
            return myCloud.Y;
        }
        public int CloudDarkness
        {
            //Get or get the cloud darkness.
            get
            {
                return myDarkness;
            }
            set
            {
                myDarkness = value;
            }
        }
    }
}
