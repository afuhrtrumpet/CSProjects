using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS1Library;

namespace LoopDemoAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Utilities.InputNumber("Enter a number from 1 to 100.  ", 100,1, ConsoleColor.Cyan, ConsoleColor.Green, ConsoleColor.DarkRed);
            Console.WriteLine(number);
            var simpnum = Utilities.InputNumber();
            Console.WriteLine(simpnum);
        }
    }
}
