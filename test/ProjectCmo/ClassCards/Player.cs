using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClassCards
{
    [Serializable]
    public class Player : INotifyPropertyChanged
    {
        public int Index { get; set; }
        protected Cards Hand { get; set; }
        private string _name;
        private PlayerState _state;

        public event EventHandler<CardEventArgs> OnCardDiscarded;

        public PlayerState State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                OnPropertyChanged(nameof(State));
            }
        }

        public virtual string PlayerName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(PlayerName));
            }
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
            if (Hand.Count > 10)
                State = PlayerState.MustDiscard;
        }

        public void DrawCard(Deck deck)
        {
            AddCard(deck.Draw());
        }

        public void DiscardCard(Card card)
        {
            Hand.Remove(card);

            if (OnCardDiscarded != null)
                OnCardDiscarded(this, new CardEventArgs { Card = card });
        }

        public void DrawNewHand(Deck deck)
        {
            Hand = new Cards();
            for (int i = 0; i < 10; i++)
                Hand.Add(deck.Draw());
        }



        public Cards GetCards()
        {
            return Hand.Clone() as Cards;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
