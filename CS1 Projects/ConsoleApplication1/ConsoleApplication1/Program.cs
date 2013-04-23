using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double divideByZero = 4;
            divideByZero = divideByZero / 0;
            Console.WriteLine("To " + divideByZero + " and beyond!");
            Console.Read();
        }
    }
}
