using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            List<int> cards = new List<int>();
            for (int i = 2; i == 13; i++)
            {

                for (int j = 0; i == 13; i++)
                {
                    cards.Add(i);
                }

            }

            foreach (int i in cards)
            {
                Console.Write(i + " ");
            }


        }
    }
}
