using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCards
{
    public class Card
    {
        public Suit suit;
        public Rank rank;

        public Card(Suit nSuit, Rank nRank)
        {
            suit = nSuit;
            rank = nRank;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return rank.ToString() + " of " + suit.ToString();

        }


    } // end class Card
}