using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCards
{
    public class Deck
    {

        private Cards cards = new Cards();
        private const int TotalCards = 52;
        private static int TotalSuit;
        private static int TotalRank;

        /// <summary>
        /// Creates and initialize all cards
        /// </summary>
        public Deck()
        {
            TotalSuit = Enum.GetValues(typeof(Suit)).Length;
            TotalRank = Enum.GetValues(typeof(Rank)).Length;

            for (int vSuit = 0; vSuit < TotalSuit; vSuit++)
            {
                for (int vRank = 1; vRank <= TotalRank; vRank++)
                {
                    cards.Add(new Card((Suit)vSuit, (Rank)vRank));
                }

            }

        } // end constructor 

        /// <summary>
        ///  
        /// </summary>
        /// <param name="nCard"></param>
        /// <returns>Return Card object with the specified index</returns>
        public Card GetCard(int nCard)
        {
            if (nCard >= 0 && nCard < TotalCards)
            {
                return cards[nCard];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("wrong value"));
            }
        } // end GetCard

        /// <summary>
        /// 
        /// </summary>
        public void Shuffle()
        {
            Random random = new Random();
            Cards tempDeck = new Cards();
            bool[] arrayBooleans = new bool[TotalCards];

            for (int i = 0; i < TotalCards; i++)
            {
                int randomCard = 0;
                bool uniqueCard = false;

                while (uniqueCard == false)
                {
                    // generate random number 
                    randomCard = random.Next(TotalCards);

                    if (arrayBooleans[randomCard] == false)
                    {
                        uniqueCard = true;
                    }

                }
                arrayBooleans[randomCard] = true;
                tempDeck.Add(cards[randomCard]);

            } // end for loop 

            // copy entire tempDeck into cards 
            tempDeck.CopyTo(cards);

        } // end Shuffle 

    } // end class Deck
}

