using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a card number from 0 to 51:  ");
            int cardNumber = Convert.ToInt32(Console.ReadLine());
            while (cardNumber < 0 | cardNumber > 51)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPlease enter a valid number:  ");
                Console.ForegroundColor = ConsoleColor.Gray;
                cardNumber = Convert.ToInt32(Console.ReadLine());
            }
            PlayingCards testCards = new PlayingCards(cardNumber);
            Console.WriteLine("\n\nCard Rank = " + testCards.getRank());
            Console.WriteLine("\nCard Suit = " + testCards.getSuit());
            Console.WriteLine("\n\nYour card is the " + testCards.ToString() + ".\n");
            Console.Read();
        }
    }
}
