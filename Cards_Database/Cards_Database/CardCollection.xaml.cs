using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cards_Database
{
    /// <summary>
    /// Interaction logic for CardCollection.xaml
    /// </summary>
    public partial class CardCollection : Page
    {
        public CardCollection()
        {
            InitializeComponent();
        }

        private void AddCard_Click(object sender, RoutedEventArgs e)
        {
            NewCard newCard = new NewCard();
            newCard.Show();
        }

        private void DeckBuilding_Click(object sender, RoutedEventArgs e)
        {
            Deckbuilding newDeckBuilding = new Deckbuilding();
            NavigationService.Navigate(newDeckBuilding);
        }
    }
}
