using Cards_Database;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CollectionBtn_Click(object sender, RoutedEventArgs e)
        {
            // MyCollection enterCollection = new MyCollection();
            //this.Content = enterCollection;
            CardCollection newCardCollection = new CardCollection();
            this.Content = newCardCollection;
             
        }

        private void DeckBuilder_Click(object sender, RoutedEventArgs e)
        {
            Deckbuilding newDeckBuilding = new Deckbuilding();
            this.Content = newDeckBuilding;
        }
    }
}
