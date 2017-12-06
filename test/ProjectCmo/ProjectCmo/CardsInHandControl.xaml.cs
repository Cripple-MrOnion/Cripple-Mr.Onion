using ClassCards;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace ProjectCmo
{
    /// <summary>
    /// Interaction logic for CardsInHandControl.xaml
    /// </summary>
    public partial class CardsInHandControl : UserControl
    {
        public CardsInHandControl()
        {
            InitializeComponent();
        }



        public Player Owner
        {
            get { return (Player)GetValue(OwnerProperty); }
            set { SetValue(OwnerProperty, value); }
        }

        public static readonly DependencyProperty OwnerProperty =
          DependencyProperty.Register("Owner", typeof(Player), typeof(CardsInHandControl), new PropertyMetadata(null, new PropertyChangedCallback(OnOwnerChanged)));




        public GameViewModel Game
        {
            get { return (GameViewModel)GetValue(GameProperty); }
            set { SetValue(GameProperty, value); }
        }

        public static readonly DependencyProperty GameProperty =
            DependencyProperty.Register("Game", typeof(GameViewModel), typeof(CardsInHandControl), null);



        public PlayerState PlayerState
        {
            get { return (PlayerState)GetValue(PlayerStateProperty); }
            set { SetValue(PlayerStateProperty, value); }
        }

        public static readonly DependencyProperty PlayerStateProperty =
            DependencyProperty.Register("PlayerState", typeof(PlayerState), typeof(CardsInHandControl), new PropertyMetadata(PlayerState.Inactive, new PropertyChangedCallback(OnPlayerStateChanged)));



        public Orientation PlayerOrientation
        {
            get { return (Orientation)GetValue(PlayerOrientationProperty); }
            set { SetValue(PlayerOrientationProperty, value); }
        }

        public static readonly DependencyProperty PlayerOrientationProperty =
            DependencyProperty.Register("PlayerOrientation", typeof(Orientation), typeof(CardsInHandControl), new PropertyMetadata(Orientation.Horizontal, new PropertyChangedCallback(OnPlayerOrientationChanged)));

        private static void OnOwnerChanged(DependencyObject source,
    DependencyPropertyChangedEventArgs e)
        {
            var control = source as CardsInHandControl;
            control.RedrawCards();
        }
        private static void OnPlayerStateChanged(DependencyObject source,
    DependencyPropertyChangedEventArgs e)
        {
            var control = source as CardsInHandControl;
            control.RedrawCards();
        }
        private static void OnPlayerOrientationChanged(DependencyObject source,
    DependencyPropertyChangedEventArgs args)
        {
            var control = source as CardsInHandControl;
            control.RedrawCards();
        }

        private class Payload
        {
            public Deck Deck { get; set; }
            public Card AvailableCard { get; set; }
        }


        private void RedrawCards()
        {
            CardSurface.Children.Clear();
            if (Owner == null)
            {
                PlayerNameLabel.Content = string.Empty;
                return;
            }
            DrawPlayerName();
            DrawCards();
        }
        private void DrawCards()
        {
            bool isFaceup = (Owner.State != PlayerState.Inactive);

            var cards = Owner.GetCards();
            if (cards == null || cards.Count == 0)
                return;
            for (var i = 0; i < cards.Count; i++)
            {
                var cardControl = new CardControl(cards[i]);
                if (PlayerOrientation == Orientation.Horizontal)
                    cardControl.Margin = new Thickness(i * 35, 35, 0, 0);
                else
                    cardControl.Margin = new Thickness(5, 35 + i * 30, 0, 0);
                cardControl.MouseDoubleClick += cardControl_MouseDoubleClick;
                cardControl.IsFaceUp = isFaceup;
                CardSurface.Children.Add(cardControl);
            }
        }
        private void DrawPlayerName()
        {
            if (Owner.State == PlayerState.Winner || Owner.State == PlayerState.Loser)
                PlayerNameLabel.Content = Owner.PlayerName +
        (Owner.State == PlayerState.Winner ?
        " is the WINNER" : " has LOST");
            else
                PlayerNameLabel.Content = Owner.PlayerName;
            var isActivePlayer = (Owner.State == PlayerState.Active ||
      Owner.State == PlayerState.MustDiscard);
            PlayerNameLabel.FontSize = isActivePlayer ? 18 : 14;
            PlayerNameLabel.Foreground = isActivePlayer ?
      new SolidColorBrush(Colors.Gold) :
      new SolidColorBrush(Colors.White);
        }

        private void cardControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedCard = sender as CardControl;
            if (Owner == null)
                return;
            if (Owner.State == PlayerState.MustDiscard)
                Owner.DiscardCard(selectedCard.Card);
            RedrawCards();
        }

    }
}
