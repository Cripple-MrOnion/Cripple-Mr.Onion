using System.Windows;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Windows.Controls;

namespace CardsGUI
{
    /// <summary>
    /// Interaction logic for StartGame.xaml
    /// </summary>
    public partial class StartGame : Window
    {
        private GameOptions _gameOptions;
        public StartGame()
        {

            DataContext = _gameOptions;
            InitializeComponent();
        }



        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (string item in playerNamesListBox.SelectedItems)
            {
                _gameOptions.SelectedPlayers.Add(item);
            }

            using (var stream = File.Open("GameOptions.xml", FileMode.Create))
            {

                var serialize = new XmlSerializer(typeof(GameOptions));
                serialize.Serialize(stream, _gameOptions);
            }
            Close();

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameOptions = null;
            Close();
        }

        private void addNewPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newPlayerTextBox.Text))
                _gameOptions.AddPlayer(newPlayerTextBox.Text);
            newPlayerTextBox.Text = string.Empty;
        }
    }
}
