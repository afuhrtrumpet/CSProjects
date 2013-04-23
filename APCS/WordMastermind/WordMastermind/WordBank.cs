using System.IO;
using System.Collections.Generic;

/**
 * Summary description for WordBank.
 */
namespace WordMastermind
{
	public class WordBank
    {
        //Declare instance variables for file name, word list, and random generator.
        private string myFileName;
        private List<string> myWordList;
        private System.Random ranGen = new System.Random();

        public WordBank(string fileName)
        {
            //Assign file name and call the loadWords method.
            myFileName = fileName;
            loadWords(0);
        }

        public WordBank(string fileName, int wordSize)
        {
            //Assign file name and call the loadWords method.
            myFileName = fileName;
            loadWords(wordSize);
        }

        private void loadWords(int wordSize)
        {
            //Intialize myWordList and add words to it only if they are the specified word length.
            myWordList = new List<string>();
            //If wordSize is 0, every word will be added to the word list.
            bool any = wordSize == 0;
            StreamReader reader = new StreamReader(myFileName);
            string word;
            while ((word = reader.ReadLine()) != null)
            {
                if (!any)
                {
                    if (word.Length == wordSize)
                        myWordList.Add(word.ToLower());
                }
                else myWordList.Add(word.ToLower());
            }
        }

        public string getRandomWord()
        {
            //Return a randomly selected word from the list.
            int randomIndex = ranGen.Next(myWordList.Count);
            return myWordList[randomIndex];
        }

        public bool isWordInList(string word)
        {
            //Return true if myWordList contains the specified word.
            return myWordList.Contains(word.ToLower());
        }
    }

}