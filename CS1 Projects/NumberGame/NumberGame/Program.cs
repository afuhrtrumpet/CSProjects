//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS1Library;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueGame = true;
            do
            {
                NumberGuessingGame numberGame = new NumberGuessingGame();
                numberGame.playGame();
                continueGame = Utilities.AskYesNo("Do you want to continue?  [y or n]  "); //Returns true if input is y, false if input is n.
            } while (continueGame);
        }
    }
}
