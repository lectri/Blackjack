using System;
using System.Collections.Generic;
using System.Linq;


namespace Blackjack 
    {
        class Game
        {
            // Properties
            private int limit;
            private List<Object> deck;
            private int dealerAmount;
            private int[] dealerCards;


            // Fields
            public int Limit
            {
                get {return this.limit;}
                set {this.limit = 21;}
            }
            public List<Object> Deck 
            {
                    get { return this.deck; }
                    set { this.deck = CreateDeck(); }
            }

            public int DealerAmount 
            {
                get { return this.dealerAmount; }
                set 
                {
                        Random random = new Random();
                        int amount = random.Next(1,4);
                        this.dealerAmount = amount; 
                }
            }

            public int[] DealerCards 
            {
                    get { return this.dealerCards; }
                    set {   
                            int[] dealerCards = new int[dealerAmount];
                            Random random = new Random();
                            for (int i = 0; i == dealerAmount; i++)
                            {
                                int randInt = random.Next(0, 52);
                                this.dealerCards[i] = randInt;
                            }
                            
                            
                        }
            }
            


            // Methods 
            private List<Object> CreateDeck() 
            {

                List<Object> deck = new List<Object>();
                
                // Numbers 2 - 10
                
                foreach (int i in Enumerable.Range(2, 10))
                {
                    foreach (int j in Enumerable.Range(0,4)) 
                    {
                        deck.Add(i);
                    }
                }

                // Jack to Queen
                foreach (int i in Enumerable.Range(10, 13))

                {
                    foreach (int j in Enumerable.Range(0, 4)) 
                    {
                    deck.Add(10);
                    }
                }

                // Ace, not a number since it can be either 1 or 3.
                foreach (int i in Enumerable.Range(1, 4)) 
                {
                    deck.Add("A");
                }
                
                return deck;
            }
    
    }

}