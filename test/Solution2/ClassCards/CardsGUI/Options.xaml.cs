using System.Windows;
using System.IO;
using System.Xml.Serialization;

namespace CardsGUI
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {

        private GameOptions _gameOptions;
        public Options()
        {

            DataContext = _gameOptions;
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
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
    }
}
