using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a new employee name.   ");
            string aName = Console.ReadLine();
            Console.Write("\nNow enter the starting salary for this employee.   ");
            double aSalary = Convert.ToDouble(Console.ReadLine());
            while (aSalary < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPlease enter a valid number.   ");
                Console.ForegroundColor = ConsoleColor.Gray;
                aSalary = Convert.ToDouble(Console.ReadLine());
            }
            Employee testEmployee = new Employee(aName, aSalary);
            Console.Write("\nNow enter a raise % from 0.0 to 1.0    ");
            double aRaise = Convert.ToDouble(Console.ReadLine());
            while (aRaise < 0.0 | aRaise > 1.0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPlease enter a valid number.   ");
                Console.ForegroundColor = ConsoleColor.Gray;
                aRaise = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("\nNow enter a new name for your employee:  ");
            string anotherName = Console.ReadLine();
            Console.Write("Enter a new salary:   ");
            double anotherSalary = Convert.ToDouble(Console.ReadLine());
            while (anotherSalary < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPlease enter a valid number.   ");
                Console.ForegroundColor = ConsoleColor.Gray;
                anotherSalary = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Here is your employee's information:");
            Console.WriteLine("Name = " + testEmployee.getName() + "  Salary = " + testEmployee.getSalary());
            testEmployee.raiseSalary(aRaise);
            Console.WriteLine("\nAfter giving your employee a " + aRaise * 100 + "% raise, his salary is now this:  " + testEmployee.getSalary());
            testEmployee.setName(anotherName);
            testEmployee.setSalary(anotherSalary);
            Console.WriteLine("\nAfter your employee's name and salary have been changed, he/she looks like this:");
            Console.WriteLine("Name = " + testEmployee.getName() + "     Salary = " + testEmployee.getSalary() + "\n");
            Console.Read();
        }
    }
}
