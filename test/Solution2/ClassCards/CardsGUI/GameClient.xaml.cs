using System.Windows;
using System.Windows.Input;


namespace CardsGUI
{
    /// <summary>
    /// Interaction logic for GameClient.xaml
    /// </summary>
    public partial class GameClient : Window
    {
        public GameClient()
        {
            InitializeComponent();
        }

        private void CommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Close)
            {
                e.CanExecute = true;
            }
            e.Handled = true;
        }
    }
}
