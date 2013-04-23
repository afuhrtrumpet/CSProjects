using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDemo
{
    class Car
    {
        private double myGasTank;
        private double myMPG;

        public Car(double anMPG)
        {
            myMPG = anMPG;
        }

        public double getGasInTank()
        {
            return myGasTank;
        }

        public void addGas(double amountOfGas)
        {
            myGasTank += amountOfGas;
        }

        public void drive(double miles)
        {
            myGasTank -= miles / myMPG;
            if (myGasTank < 0)
            {
                Console.WriteLine("Your car ran out of gas, therefore you had to be towed. Drive wisely next time!");
                myGasTank = 0;
            }
        }
    }
}
