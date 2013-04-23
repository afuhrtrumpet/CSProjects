using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, number, count;
            //for (i = 1; i <= 5; i++);
            //    Console.WriteLine("To be, or not to be ...\n");

            //for (j = 1; j < 3; j = j + 2)
            //    Console.WriteLine(j + " Good Morning");

            //number = 3;
            //for (count = 1; count <= number; count++)
            //{
            //    k = count * number;
            //    Console.WriteLine(count + " " + k);
            //}

            //number = 3;
            //for (count = 1; count <= number; count++)
            //    Console.WriteLine(count + " " + (count + 1));
            //    Console.WriteLine("STOP");

            //for (j = 0; j < 4; j++)
            //{
            //    for (k = 0; k < j; k++)
            //        Console.Write(" ");
            //    Console.WriteLine("X");
            //}

            //for (i = 3; i <= 5; i++)
            //    for (j = 4; j <= 6; j++)
            //        Console.WriteLine(i + " " + j);

            number = 20;
            for (count = 1; count <= number; count++)
                Console.Write(count / 10);
            Console.WriteLine();
            for (count = 1; count <= number; count++)
                Console.Write(count % 10);
        }
    }
}
