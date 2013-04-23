using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayDemo
{
    class RainChart
    {
        private double[] inches;

        public RainChart(int numberOMonths)
        {
            if (numberOMonths < 1)
                numberOMonths = 1;
            inches = new double[numberOMonths];
        }

        public void getInput()
        {
            Console.WriteLine("Enter the rainfall values for each month.");
            for (int i = 0; i < inches.Length; i++)
            {
                inches[i] = Convert.ToDouble(Console.ReadLine());

            }
        }
    }
}
