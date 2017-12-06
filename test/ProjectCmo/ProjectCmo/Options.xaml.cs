using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace ProjectCmo
{
    public partial class Options : Window
    {
        private GameOptions _gameOptions;

        public Options()
        {
            _gameOptions = GameOptions.Create();
            DataContext = _gameOptions;

            InitializeComponent();
        }
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            _gameOptions.Save();
            this.Close();
        }
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameOptions = null;
            Close();
        }
    }
}
