using Microsoft.Win32;
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
using System.Windows.Shapes;
using System.Data.SqlClient;


namespace Cards_Database
{
    /// <summary>
    /// Interaction logic for NewCard.xaml
    /// </summary>
    public partial class NewCard : Window
    {
        public NewCard()
        {
            InitializeComponent();
 
        }

        private void InsertImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openExplorer = new OpenFileDialog();
            openExplorer.Filter = "Image Files | *.jpg; *.jpeg;*.png;";
            openExplorer.FilterIndex = 1;

            if(openExplorer.ShowDialog() == true)
            {
                imageDisplay.Source = new BitmapImage(new Uri(openExplorer.FileName));
            }
        }

        private void addNewBtn_Click(object sender, RoutedEventArgs e)
        {

            //1. Adress of SQL server and database 
            string connectionString = "Data Source=DESKTOP-CSEFJTJ\\SQLEXPRESS;Initial Catalog=MTG_GATHERER;Integrated Security=True";
            //2. establish connection
            SqlConnection connectDb = new SqlConnection(connectionString);

            //3. Open Connection
            connectDb.Open();

            //4. Prepare Query
            string CardName = nameInput.Text;
            string CardType = cardType.Text;
            string CollectionSelect = collectionInput.Text;
            string MarketPlace = marketPlaceInput.Text;

            string Query = "INSERT INTO CardsRegistered (CardName,CardType,CardCollection,CardLink) VALUES ('" + CardName+"', '"+CardType+"', '"+CollectionSelect+"', '"+MarketPlace+"')   ";

            //5. Execute Query
            SqlCommand cmd = new SqlCommand(Query, connectDb);
            cmd.ExecuteNonQuery();


            //6. Close Connection
            connectDb.Close();

            MessageBox.Show("Data inserted");
        }
    }
}
