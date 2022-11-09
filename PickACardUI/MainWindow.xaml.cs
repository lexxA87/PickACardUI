using System.Windows;

namespace PickACardUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] pickerCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            listOfCards.Items.Clear();
            foreach (var card in pickerCards)
            {
                listOfCards.Items.Add(card);
            }
        }
    }
}
