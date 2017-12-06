using System;

namespace ClassCards
{
    public class Card : ICloneable
    {
        public readonly Rank rank;
        public readonly Suit suit;

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString() => "The " + rank + " of " + suit + "s";
    }
}
