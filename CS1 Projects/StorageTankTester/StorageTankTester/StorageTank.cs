using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageTankTester
{
    class StorageTank
    {
        private double myGallons;

        public StorageTank(double someGallons)
        {
            myGallons = someGallons;
        }

        public void changeLevel(double gallonsAdded)
        {
            myGallons += gallonsAdded;
        }

        public double getGallons()
        {
            return myGallons;
        }

        public double getLiters()
        {
            return myGallons * 3.785;
        }
    }
}
