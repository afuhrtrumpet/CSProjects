using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageTankTester
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageTank testTank = new StorageTank(500);
            Console.WriteLine("A tank starts out with " + testTank.getGallons() + " gallons.");
            testTank.changeLevel(-300);
            Console.WriteLine("\nAfter removing 300 gallons from the tank, it now has " + testTank.getGallons() + " gallons.");
            Console.WriteLine("\nThat is equivalent to " + testTank.getLiters() + " liters.\n");
        }
    }
}
