using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NumberSpirals
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readrar;
            bool done = false;
            do
            {
                try
                {
                    Console.Write("Enter a file name:  ");
                    string fileName = Console.ReadLine();
                    readrar = new StreamReader(fileName);
                    done = true;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Error: File not found!");
                    continue;
                }
                while (!readrar.EndOfStream)
                {
                    string[] numbrars = readrar.ReadLine().Split();
                    GridPoint gp = Grid.Spiral(int.Parse(numbrars[0].Trim()), int.Parse(numbrars[1].Trim()));
                    Console.WriteLine(gp.r + " " + gp.c);
                }
            } while (!done);

        }
    }
}
