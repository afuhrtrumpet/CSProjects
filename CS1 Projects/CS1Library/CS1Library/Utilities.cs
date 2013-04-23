using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS1Library
{
    public class Utilities
    {
        public static int InputNumber()
        {
            return InputNumber("Enter a number.  ", int.MaxValue, int.MinValue, Console.ForegroundColor, Console.ForegroundColor, Console.ForegroundColor);
        }
        public static int InputNumber(string prompt)
        {
            return InputNumber(prompt, int.MaxValue, int.MinValue, Console.ForegroundColor, Console.ForegroundColor, Console.ForegroundColor);
        }
        public static int InputNumber(string prompt, int max)
        {
            return InputNumber(prompt, max, int.MinValue, Console.ForegroundColor, Console.ForegroundColor, Console.ForegroundColor);
        }
        public static int InputNumber(string prompt, int max, int min)
        {
            return InputNumber(prompt, max, min, Console.ForegroundColor, Console.ForegroundColor, Console.ForegroundColor);
        }
        public static int InputNumber(ConsoleColor promptColor, ConsoleColor inputColor, ConsoleColor errorColor)
        {
            return InputNumber("Enter a number.  ", int.MaxValue, int.MinValue, promptColor, inputColor, errorColor);
        }
        public static int InputNumber(string prompt, ConsoleColor promptColor, ConsoleColor inputColor, ConsoleColor errorColor)
        {
            return InputNumber(prompt, int.MaxValue, int.MinValue, promptColor, inputColor, errorColor);
        }
        public static int InputNumber(string prompt, int max, ConsoleColor promptColor, ConsoleColor inputColor, ConsoleColor errorColor)
        {
            return InputNumber(prompt, max, int.MinValue, promptColor, inputColor, errorColor);
        }
        public static int InputNumber(string prompt, int max, int min, ConsoleColor promptColor, ConsoleColor inputColor, ConsoleColor errorColor)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            int input = 0;
            bool done = false;
            do
            {
                Console.ForegroundColor = promptColor;
                Console.Write(prompt);
                Console.ForegroundColor = inputColor;
                string inputText = Console.ReadLine();
                if (inputText == null)
                {
                    Console.ForegroundColor = errorColor;
                    Console.WriteLine("That's not an integer!");
                }
                else
                {
                    try
                    {
                        input = int.Parse(inputText);
                        if (input <= max && input >= min)
                        {
                            done = true;
                        }
                        else
                        {
                            Console.ForegroundColor = errorColor;
                            Console.WriteLine("Input number must be within specified range. " + min + "-" + max);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = errorColor;
                        Console.WriteLine("That's not an integer!");
                    }
                    catch (OverflowException)
                    {
                        Console.ForegroundColor = errorColor;
                        Console.WriteLine("Too long!");
                    } 
                }
            } while (!done);
            Console.ForegroundColor = previousColor;
            return input;
        }
        public static bool AskYesNo(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                string input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "Y": return true;
                    case "N": return false;
                    default: Console.Write("Please enter valid input y or n.  "); break;
                } 
            }
        }
    }
}
