using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.IO;
using System.Text.RegularExpressions;

namespace Cards_Database
{
    /// <summary>
    /// Interaction logic for Deckbuilding.xaml
    /// </summary>
    public partial class Deckbuilding : Page
    {
        public ObservableCollection<CardDeckBuilding> myCards { get; set; }
        public Deckbuilding()
        {
            InitializeComponent();
            myCards = new ObservableCollection<CardDeckBuilding>();
            DataGrid.ItemsSource = myCards;

        }

       

        private void AddCardBtn_Click(object sender, RoutedEventArgs e)
        {
  
            //Getting the CardName  TextBox and adding to a variable
            string dataGridCardName = DataCardName.Text;
            string deckName = DeckNameInput.Text;
            string deckFormat = DeckFormatInput.Text;
            int cardValue; 

            if(int.TryParse(CardValue.Text,out cardValue))
            { 

                //Now, cardValue holds the integer value
               
            }
            else if(cardValue < 0 )
            {
                MessageBox.Show("Please provide the mana cost (example: numbers 1-10)","Add the mana cost",MessageBoxButton.OK,MessageBoxImage.Information);
            }

   


            // checks if the quantity is not empty
            if ( CardQtd.SelectedItem != null)
            {
               
                 int dataGridCardQtd = Convert.ToInt32((CardQtd.SelectedItem as ComboBoxItem).Content);
               
                if(string.IsNullOrEmpty(dataGridCardName))
                {
                    MessageBox.Show("Field is empty, please provide the card name!");
                } else if(dataGridCardQtd < 1 )
                {
                    MessageBox.Show("The quantity of cards in the deck must be greater than or equal to 1!");
                }
                else
                {
                    //input fields in the UI are inserted to the properties
                    myCards.Add(new CardDeckBuilding { CardName = dataGridCardName, CardQuantity = dataGridCardQtd, ManaValue = cardValue });
                    DataCardName.Clear();
                    dataGridCardQtd = 1;

                }
            } else
            {
                MessageBox.Show("Please provide the deck details!");
            }
         
        }
         
     



        private void ExportTxt_Btn(object sender, RoutedEventArgs e)
        {
            //Setting the datagrid created as the source of information
            var data = DataGrid.ItemsSource as IEnumerable<CardDeckBuilding>;

            string deckName = DeckNameInput.Text;
            string deckFormat = DeckFormatInput.Text;

            //Check if the deckName or deckFormat are empty, if so throws a error
            if(string.IsNullOrWhiteSpace(deckName) || string.IsNullOrEmpty(deckFormat))
            {

                MessageBox.Show("please check if the fields \"Deck Name\" or \"Deck Format\" are empty and try again!", "Fields empty", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else if(data != null && data.Any())
            {
                try
                {
                    var saveFileDialog = new Microsoft.Win32.SaveFileDialog
                    {
                        Filter = "Text Files (*.txt)|*.txt|All Files (*.*)| *.*", FileName = $"{DeckNameInput.Text}.txt"
                    };

                    if(saveFileDialog.ShowDialog()== true)
                    {
                        string filePath = saveFileDialog.FileName;

                        using(StreamWriter writer = new StreamWriter(filePath))
                        {
                            
                            writer.WriteLine($"Deck Name: {DeckNameInput.Text}, Format: {DeckFormatInput.Text}");
                            foreach (var item in data)
                            {
                                writer.WriteLine($"{item.CardName} Mana Cost:{item.ManaValue} x{item.CardQuantity}");
                            }
                        }

                        MessageBox.Show("Deck data exported successfully!", "Export Complete", MessageBoxButton.OK, MessageBoxImage.Information);

                    }  
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"An error ocurred: {ex.Message}", "Error", MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
            else  
            {
                MessageBox.Show("No cards entered, please add the cards name and quantity", "No cards entered", MessageBoxButton.OK,MessageBoxImage.Information);
            }

        }

        
        private void AcceptOnlyNumbers(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void DeleteCardBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItem = DataGrid.SelectedItem as CardDeckBuilding;
                if(selectedItem != null)
                {
                   var showInfo = MessageBox.Show("Are you sure you want to delete this row? ","Delete selected row",MessageBoxButton.YesNo,MessageBoxImage.Warning);
                    if( showInfo == MessageBoxResult.Yes)
                    {
                        myCards.Remove(selectedItem);
                        MessageBox.Show("Row successfully deleted!", "Deleted row",MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Could not delete row! Please check if row is selected!");
                    }
                } else
                {
                    MessageBox.Show("Please select a row before deleting it!");
                }
               
            } catch(Exception ex)
            {
                MessageBox.Show("Please  check if row is selected" + ex.Message);
            }
        }
    }
}
