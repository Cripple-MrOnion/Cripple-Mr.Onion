﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCards
{
    public class Card
    {
        public SuitCmo suit;
        public Rank rank;

        public Card(SuitCmo nSuit, Rank nRank)
        {
            suit = nSuit;
            rank = nRank;
        } // end constructor

        /// <summary>toString method</summary>
        public override string ToString()
        {
            return rank.ToString() + " of " + suit.ToString();
        }
    } // end class Card
} // namespace ClassCards 