using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car testCar = new Car(30);
            testCar.addGas(30.5);
            Console.WriteLine(testCar.getGasInTank());
            testCar.addGas(.5);
            Console.WriteLine (testCar.getGasInTank());
            testCar.drive(30);
            Console.WriteLine(testCar.getGasInTank());
            testCar.drive(901);
            Console.WriteLine(testCar.getGasInTank());
            Console.Read();
        }
    }
}
