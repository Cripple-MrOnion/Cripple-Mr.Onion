using System;

namespace ClassCards
{
    public class CardOutOfRangeException : Exception
    {
        private Cards deckContents;

        public Cards DeckContents
        {
            get { return deckContents; }
        }

        public CardOutOfRangeException(Cards sourceDeckContents)
            : base("wrong value")
        {
            deckContents = sourceDeckContents;
        }
    }
}
