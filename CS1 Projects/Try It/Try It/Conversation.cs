//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryIt
{
    class Conversation
    {
        //Declare constants that define the input range.
        private const int MIN = -1;
        private const int MAX = 4;

        //Declare constants for the colors to be used.
        private const ConsoleColor INPUT_COLOR = ConsoleColor.Green;
        private const ConsoleColor PROMPT_COLOR = ConsoleColor.Blue;
        private const ConsoleColor ERROR_COLOR = ConsoleColor.Red;
        private const ConsoleColor MESSAGE_COLOR = ConsoleColor.DarkGreen;
        private const ConsoleColor BACKGROUND_COLOR = ConsoleColor.DarkGray;

        private String name;

        public Conversation()
        {
            Console.Title = "Ready to discover your true self?";
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.Clear();
        }

        public void go()
        {
            getName();
            int number = getNumber();
            displayMessage(number);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }

        private void getName()
        {
            Console.ForegroundColor = PROMPT_COLOR;
            Console.Write("Enter your name.  ");
            Console.ForegroundColor = INPUT_COLOR;

            // Read the text that the user input.
            name = Console.ReadLine();
        }

        private int getNumber()
        {
            int input;

            // Prompt user for a number.
            do
            {
                Console.ForegroundColor = PROMPT_COLOR;
                Console.Write("\nEnter a number from 1 to 4.  ");
                Console.ForegroundColor = INPUT_COLOR;

                // Convert number input to an signed integer.
                input = Convert.ToInt16(System.Console.ReadLine());

                // Check if input number is within the constraints and display error message if it is less than the minimum or greater than the maximum number.
                if (input < MIN || input > MAX)
                {
                    Console.ForegroundColor = ERROR_COLOR;
                    Console.WriteLine("Invalid number!");
                }
            } while (input < MIN || input > MAX);

            return input;
        }

        private void displayMessage(int choice)
        {

            String phrase = "";

            // Choose a phrase depending on the number selected.
            switch (choice)
            {
                case -1: Console.WriteLine("");
                    Console.ForegroundColor = PROMPT_COLOR;
                    Console.Write("Enter a phrase.  ");
                    Console.ForegroundColor = INPUT_COLOR;

                    phrase = Console.ReadLine(); break;
                case 0: phrase = "found a secret phrase!"; break;
                case 1: phrase = "wins at life."; break;
                case 2: phrase = "can't even use Alice correctly."; break;
                case 3: phrase = "just lost the game."; break;
                case 4: phrase = "is materialistic for choosing the highest number."; break;
            }

            Console.WriteLine();
            Console.ForegroundColor = MESSAGE_COLOR;

            // Compile the name and phrase into one message which is repeated 10 times.
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter + ")  " + name + " " + phrase);
            }
        }
    }
}
