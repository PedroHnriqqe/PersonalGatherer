using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Dynamic;
using System.IO;
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
using System.Diagnostics;

namespace Cards_Database
{
    /// <summary>
    /// Interaction logic for CardCollection.xaml
    /// </summary>
    public partial class CardCollection : Page
    {
        private DataTable dataTable;
        string connectionString = "Data Source=BATPC\\SQLEXPRESS;Initial Catalog=MTG_GATHERER;Integrated Security=True";

        public CardCollection()
        {
      
                InitializeComponent();

                

                using (SqlConnection connectionDb = new SqlConnection(connectionString))
                {
                    connectionDb.Open();

                    using (SqlDataAdapter adapt = new SqlDataAdapter("Select CardName, CardImg From CardsRegistered", connectionDb))
                    {
                        dataTable = new DataTable();
                        adapt.Fill(dataTable);
                    }
                }

                // Convert the image data to ImageSource and add it to the DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    byte[] imageData = row.Field<byte[]>("CardImg");
                    if (imageData != null)
                    {
                        BitmapImage imageSource = new BitmapImage();
                        imageSource.BeginInit();
                        imageSource.StreamSource = new MemoryStream(imageData);
                        imageSource.EndInit();

                        // Converting the BitmapImage to a byte array
                        byte[] imageBytes;
                        JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(imageSource));
                        using (MemoryStream stream = new MemoryStream())
                        {
                            encoder.Save(stream);
                            imageBytes = stream.ToArray();
                        }

                        row["CardImg"] = imageBytes;
                    }
                }

            // Set the ItemsSource after populating the DataTable
            CardPanel.ItemsSource = dataTable.DefaultView;
            }
        //Refresh the page without having to restart the program
        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            dataTable.Clear(); //Clear the existing data
            using (SqlConnection connectionDB = new SqlConnection(connectionString))
            {
                connectionDB.Open();
                using(SqlDataAdapter adapt = new SqlDataAdapter("Select CardName, CardImg From CardsRegistered", connectionDB))
                {
                    adapt.Fill(dataTable);
                }
            }

            //Convert the image data to ImageSource and update the DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                byte[] imageData = row.Field<byte[]>("CardImg");
                if(imageData != null)
                {
                    BitmapImage imageSource = new BitmapImage();
                    imageSource.BeginInit();
                    imageSource.StreamSource = new MemoryStream(imageData);
                    imageSource.EndInit();

                    //Converting the BitMapImage to a byteArray
                    byte[] imageBytes;
                    JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(imageSource));
                    using(MemoryStream stream = new MemoryStream())
                    {
                        encoder.Save(stream);
                        imageBytes = stream.ToArray();
                    }
                    row["CardImg"] = imageBytes;
                }
            }

            //Set the ItemsSource after updating the DataTable
            CardPanel.ItemsSource = dataTable.DefaultView;

            MessageBox.Show("Data refreshed successfully.");
        }





        //Getting the images from the folder

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
