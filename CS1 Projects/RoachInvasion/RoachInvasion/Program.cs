using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoachInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            RoachPopulation testRoaches = new RoachPopulation(10);
            Console.WriteLine("My kitchen starts with " + testRoaches.getRoaches() + " roaches.");
            testRoaches.waitForDoubling();
            Console.WriteLine("\nThe roaches are multiplying...");
            testRoaches.spray();
            Console.WriteLine("I'm spraying the kitchen.");
            Console.WriteLine("Now there are " + testRoaches.getRoaches() + " roaches in my kitchen!");
            testRoaches.waitForDoubling();
            Console.WriteLine("\nThe roaches are multiplying...");
            testRoaches.spray();
            Console.WriteLine("I'm spraying the kitchen.");
            Console.WriteLine("Now there are " + testRoaches.getRoaches() + " roaches in my kitchen!");
            testRoaches.waitForDoubling();
            Console.WriteLine("\nThe roaches are multiplying...");
            testRoaches.spray();
            Console.WriteLine("I'm spraying the kitchen.");
            Console.WriteLine("Now there are " + testRoaches.getRoaches() + " roaches in my kitchen!");
            Console.WriteLine("\nRoaches win.\n");
        }
    }
}
