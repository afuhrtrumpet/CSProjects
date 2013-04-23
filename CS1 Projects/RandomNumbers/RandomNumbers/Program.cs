//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.Title = "RAAAAAAAAANNNNNNNNNNNNNNNNNDDDDDDDDDDDDOOOOOOOOOOOOMMMMMMMMMM!!!!!!!!!!!!!!";
            const ConsoleColor DESCRIPTION_COLOR = ConsoleColor.Gray;
            const ConsoleColor NUMBER_COLOR = ConsoleColor.DarkBlue;
            Console.Write("Random Integer:  ");
            Random generator = new Random();
            Console.ForegroundColor = NUMBER_COLOR;
            int firstRandom = generator.Next();
            Console.WriteLine(firstRandom);
            Console.WriteLine();
            Console.ForegroundColor = DESCRIPTION_COLOR;
            Console.Write("Random Integer Less Than 100:  ");
            Console.ForegroundColor = NUMBER_COLOR;
            int random100 = generator.Next(100);
            Console.WriteLine(random100);
            Console.WriteLine();
            Console.ForegroundColor = DESCRIPTION_COLOR;
            Console.Write("Random Integer Between 10 and 20:  ");
            Console.ForegroundColor = NUMBER_COLOR;
            int random1020 = generator.Next(10,20);
            Console.WriteLine(random1020);
            Console.WriteLine();
            Console.ForegroundColor = DESCRIPTION_COLOR;
            Console.Write("Random Double Between 0 and 1:  ");
            Console.ForegroundColor = NUMBER_COLOR;
            double randomDouble = generator.NextDouble();
            Console.WriteLine(randomDouble);
            Console.ForegroundColor = DESCRIPTION_COLOR;
            Console.WriteLine();
        }
    }
}
