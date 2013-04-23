using System.IO;

/**
 * Summary description for WordMastermind.
 */
namespace WordMastermind
{
	public class WordMastermindGame
    {
        //Declare instance variagles for maximum guesses, word size, file name, guess number, word bank, and secret word.
	    private int myMaxGuesses;
	    private int myWordSize;
	    private string myWordFileName;
        private int myGuessNumber;
	    private WordBank myWordBank;

	    private string mySecretWord;

	    public WordMastermindGame(string fileName, int maxGuesses, int wordSize)
	    {
            //Initialize the instance variables.
            myWordSize = wordSize;
            myWordFileName = fileName;
            myWordBank = new WordBank(fileName, wordSize);
            myMaxGuesses = maxGuesses;
	    }

	    public void newGame()
	    {
            //Set guess number to 0 and choose secret word.
            myGuessNumber = 0;
            mySecretWord = myWordBank.getRandomWord();
	    }

	    public int[] makeGuess(string guess)
	    {
            //Return an int array with 0 for no match, 1 for match but in the wrong spot, and 2 for right spot match.
            int[] returnArray = new int[myWordSize];
            char[] guessCharmander = guess.ToCharArray();
            char[] secretCharmander = mySecretWord.ToCharArray();
            //Find exact matches and set matched secret character array members to 0 to avoid duplicates.
            for (int i = 0; i < myWordSize; i++)
            {
                if (guessCharmander[i] == secretCharmander[i])
                {
                    returnArray[i] = 2;
                    secretCharmander[i] = '0';
                }
            }
            //Find wrong spot matches and set matched secret character array members to 0 to avoid duplicates.
            for (int i = 0; i < myWordSize; i++)
            {
                if (returnArray[i] == 0)
                {
                    for (int j = 0; j < myWordSize; j++)
                    {
                        if (guessCharmander[i] == secretCharmander[j])
                        {
                            returnArray[i] = 1;
                            secretCharmander[j] = '0';
                            break;
                        }
                    }
                }
            }
            myGuessNumber++;
            return returnArray;
	    }

        public string getSecretWord()
	    {
            //Return secret word.
            return mySecretWord;
        }

	    public bool isValidWord(string word)
	    {
            //Returns true if word is valid.
            return myWordBank.isWordInList(word);
        }

        public bool outOfGuesses()
        {
            //Returns true if the guess number has reached the max number of guesses.
            return myGuessNumber >= myMaxGuesses;
        }
    }

}