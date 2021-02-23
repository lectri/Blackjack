using System;
using System.Collections.Generic;
namespace Blackjack
{
    class Run
    { 
        static void Main()
        {
            Game Blackjack = new Game();
            List<object> deck = Blackjack.Deck;
            Console.WriteLine(deck.Count);
        }
        
       
    }
}

