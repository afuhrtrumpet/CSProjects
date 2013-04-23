using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoachInvasion
{
    class RoachPopulation
    {
        private double roachPopulationSize;

        public RoachPopulation(double aNumberOfRoaches)
        {
            roachPopulationSize = aNumberOfRoaches;
        }

        public void waitForDoubling()
        {
            roachPopulationSize *= 2;
        }

        public void spray()
        {
            roachPopulationSize -= .1 * roachPopulationSize;
        }

        public double getRoaches()
        {
            return roachPopulationSize;
        }
    }
}
