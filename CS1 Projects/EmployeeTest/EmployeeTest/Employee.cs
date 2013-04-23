using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeTest
{
    class Employee
    {
        private string myName;
        private double mySalary;

        public Employee(string aName, double aSalary)
        {
            myName = aName;
            mySalary = aSalary;
        }

        public string getName()
        {
            return myName;
        }

        public double getSalary()
        {
            return mySalary;
        }

        public void setName(string aName)
        {
            myName = aName;
        }

        public void setSalary(double aSalary)
        {
            mySalary = aSalary;
        }

        public void raiseSalary(double raisePercentage)
        {
            mySalary += mySalary * raisePercentage;
        }
    }
}
