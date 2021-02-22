using System;
using System.Collections.Generic;



namespace Blackjack
{
    class Game 
    {
        

        static void Main()
        {
            List<int> deck = CreateDeck();

            Console.WriteLine(deck.Count);
        }
        
        private static List<int, string> CreateDeck() 
        {

            String<int, string> deck = new List<int>();
            
            // Numbers 2 - 10
            int i = 2;
            while (i != 10 )
            {
                deck.Add(i);
                deck.Add(i);
                deck.Add(i);
                deck.Add(i);
                i++;
            }
            // Jack to Queen
            while (i != 13)

            {
                deck.Add(10);
                deck.Add(10);
                deck.Add(10);
                deck.Add(10);
                i++;
            }

            // Ace, not a number since it can be either 1 or 3.
            deck.Add("A");
            deck.Add("A");
            deck.Add("A");
            deck.Add("A");
            
            return deck;
        }
    }
}
