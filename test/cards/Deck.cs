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

        /// <summary>Creates and initialize all cards</summary>
        public Deck()
        {
            TotalSuit = Enum.GetValues(typeof(Suit)).Length;
            TotalRank = Enum.GetValues(typeof(Rank)).Length;

            for (int suit = 0; suit < TotalSuit; suit++)
            {
                for (int rank = 1; rank <= TotalRank; rank++)
                {
                    cards.Add(new Card((Suit)suit, (Rank)rank));
                }
            }
        } // end constructor 

        /// <summary>Return Card object with the specified index</summary>
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
        } // end method GetCard

        /// <summary>Shuffle method</summary>
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
                    randomCard = random.Next(TotalCards);
                    if (arrayBooleans[randomCard] == false)
                        uniqueCard = true;
                }

                arrayBooleans[randomCard] = true;
                tempDeck.Add(cards[randomCard]);
            }
            // copy entire tempDeck into cards 
            tempDeck.CopyTo(cards);

        } // end method Shuffle 

    } // end class Deck


    /// <summary> Add method </summary>
    // add()


    /// <summary>Deal method</summary>
    // deal()


    /// <summary>Get Card Names</summary>
    // getCardNames()


    /// <summary>Reset Deck</summary>
    // resetDeck()


    /// <summary>peek</summary>
    // peek()

    /// <summary>Contains certain value</summary>
    // contains()


} // namespace ClassCards 

