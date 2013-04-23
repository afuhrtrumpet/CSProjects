using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardTester
{
    class PlayingCards
    {
        private int mySuit;
        private int myRank;
        static string[] suitNames = { "Diamonds", "Clubs", "Hearts", "Spades" };
        static string[] rankNames = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        public PlayingCards(int aCardNumber)
        {
            mySuit = aCardNumber / 13;
            myRank = aCardNumber - mySuit * 13;
        }

        public int getSuit()
        {
            return mySuit;
        }

        public int getRank()
        {
            return myRank;
        }

        public override string ToString()
        {
            return rankNames[myRank] + " of " + suitNames[mySuit];
        }
    }
}
