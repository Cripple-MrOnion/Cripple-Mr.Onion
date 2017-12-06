using System.Windows;
using System.Windows.Controls;


namespace ProjectCmo
{

    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }

        public CardControl(ClassCards.Card card)
        {
            InitializeComponent();
            Card = card;
        }

        public static DependencyProperty SuitProperty = DependencyProperty.Register(
           "Suit",
           typeof(ClassCards.Suit),
           typeof(CardControl),
           new PropertyMetadata(ClassCards.Suit.Clubs,
    new PropertyChangedCallback(OnSuitChanged)));
        public static DependencyProperty RankProperty = DependencyProperty.Register(
           "Rank",
           typeof(ClassCards.Rank),
           typeof(CardControl),
           new PropertyMetadata(ClassCards.Rank.Ace));
        public static DependencyProperty IsFaceUpProperty = DependencyProperty.Register(
       "IsFaceUp",
       typeof(bool),
       typeof(CardControl),
       new PropertyMetadata(true, new PropertyChangedCallback(OnIsFaceUpChanged)));
        public bool IsFaceUp
        {
            get { return (bool)GetValue(IsFaceUpProperty); }
            set { SetValue(IsFaceUpProperty, value); }
        }
        public ClassCards.Suit Suit
        {
            get { return (ClassCards.Suit)GetValue(SuitProperty); }
            set { SetValue(SuitProperty, value); }
        }
        public ClassCards.Rank Rank
        {
            get { return (ClassCards.Rank)GetValue(RankProperty); }
            set { SetValue(RankProperty, value); }
        }

        public static void OnSuitChanged(DependencyObject source,
       DependencyPropertyChangedEventArgs args)
        {
            var control = source as CardControl;
            control.SetTextColor();
        }
        private static void OnIsFaceUpChanged(DependencyObject source,
                    DependencyPropertyChangedEventArgs args)
        {
            var control = source as CardControl;
            control.RankLabel.Visibility = control.SuitLabel.Visibility =
                        control.RankLabelInverted.Visibility =
      control.TopRightImage.Visibility =
      control.BottomLeftImage.Visibility = control.IsFaceUp ?
      Visibility.Visible : Visibility.Hidden;
        }

        private ClassCards.Card _card;
        public ClassCards.Card Card
        {
            get { return _card; }
            private set { _card = value; Suit = _card.suit; Rank = _card.rank; }
        }

        private void SetTextColor()
        {


        }
    }
}