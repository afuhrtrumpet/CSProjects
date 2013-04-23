//Alex Fuhr

using System;
using CS1Library;

namespace NumberGame
{
    class NumberGuessingGame
    {
	    private int guessCount = 0;
	    private int secretNumber;
	    private int min;
	    private int max;

	    public const ConsoleColor PROMPT = ConsoleColor.Blue;
	    public const ConsoleColor INPUT = ConsoleColor.Green;
	    public const ConsoleColor ERROR = ConsoleColor.Red;
        public const ConsoleColor SECRET = ConsoleColor.Yellow;

	    public void playGame()
	    {
		    Console.Title = "Number Guessing Game";
		    Console.BackgroundColor = ConsoleColor.DarkGray;
		    Console.Clear();
		    Console.ForegroundColor = PROMPT;

		    Console.WriteLine(
			    "Welcome to the number guessing game!\n\n" +
			    "You give me a range of numbers and I'll choose a number in that range.\n" +
			    "Then you can guess the number and I'll count how many tries it takes.");

		    getMinMax();
    	
		    Console.WriteLine("\n\nI'm now thinking of a number between " + min +
			    " and " + max + ".  See if you can guess it!\n");

		    chooseSecretNumber();
#if DEBUG
            Console.ForegroundColor = SECRET;
            Console.WriteLine("Secret number = " + secretNumber + "\n");
            Console.ForegroundColor = PROMPT; 
#endif
		    getGuesses();

		    Console.WriteLine("\n\n" + getRating() + "\n\n");

	    }

	    private void getMinMax()
	    {
            max = Utilities.InputNumber("\nEnter a maximum value:  ", PROMPT, INPUT, ERROR); 
            min = Utilities.InputNumber("\nEnter a minimum value:  ", max, PROMPT, INPUT, ERROR);
	    }

	    private void chooseSecretNumber()
	    {
            Random secretGenerator = new Random();
            secretNumber = secretGenerator.Next(min, max + 1);
	    }

	    private void getGuesses()
	    {
            bool correct = false;
            while (!correct)
            {
                int guess = Utilities.InputNumber("Enter your guess:  ", max, min, PROMPT, INPUT, ERROR);
                guessCount++;
                if (guess == secretNumber) correct = true;
                else if (guess > secretNumber) Console.WriteLine("Too high!");
                else if (guess < secretNumber) Console.WriteLine("Too low!");
            }
	    }

	    private string getRating()
	    {
            string guessRating;
            string difficulty;
            int difference = max - min;
            if (guessCount == 1) guessRating = "You're a wizard! That or you should really go to Vegas.";
            else if (guessCount <= 5) guessRating = "Very respectable guesswork!";
            else if (guessCount <= 10) guessRating = "Pretty good, but nothing special.";
            else if (guessCount <= 15) guessRating = "That's just... average guesswork.";
            else if (guessCount <= 20) guessRating = "Borderline pathetic.";
            else guessRating = "Really now? How long does it have to take?";
            if (difference == 0) difficulty = "How could you not get it in one guess? Cheater...";
            else if (difference == 1) difficulty = "I take back anything good I said about you, actually. That's too easy.";
            else if (difference <= 10) difficulty = "Ok... Maybe try something a bit harder next time?";
            else if (difference <= 50) difficulty = "I know you can choose a harder range of numbers!";
            else if (difference <= 100) difficulty = "Good number choice! Keep striving for improvement!";
            else if (difference <= 1000) difficulty = "You chose a very difficult range of numbers. Good work!";
            else difficulty = "Wow. I am truly impressed. Even if you struggled, I am proud of you.";
            return guessCount + " guesses. " + guessRating + " " + difficulty;
	    }

    }
}

