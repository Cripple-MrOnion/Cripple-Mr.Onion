using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class1
{
    public class Card
    {
        public Rank rank;
        public Suit suit;

        public Card(Suit nSuit, Rank nRank)
        {

            suit = nSuit;
            rank = nRank;

        }

        
        /*public override string ToString()
        {
           
        }*/
        
        
    }
}