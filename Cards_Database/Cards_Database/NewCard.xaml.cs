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
using System.IO;
using System.Windows.Navigation;

namespace Cards_Database
{
    /// <summary>
    /// Interaction logic for NewCard.xaml
    /// </summary>
    public partial class NewCard : Window
    {
 
        private void GoToCardCollectionPage()
        {
            CardCollection cardCollectionPage = new CardCollection();
            
        }
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
                //Displaying the card
                imageDisplay.Source = new BitmapImage(new Uri(openExplorer.FileName));
 
                
            }
        }

        private byte[] ConvertImageToBytes(ImageSource imageSource)
        {
            if(imageSource is BitmapSource bitmapSource)
            {
                using(MemoryStream stream = new MemoryStream())
                {
                    PngBitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
                    encoder.Save(stream);

                    return stream.ToArray();
                }
            }

            return null;
        }

        private void addNewBtn_Click(object sender, RoutedEventArgs e)
        {

            //1. Address of SQL server and database 
            string connectionString = "Data Source=BATPC\\SQLEXPRESS;Initial Catalog=MTG_GATHERER;Integrated Security=True";
            //2. establish connection
            SqlConnection connectDb = new SqlConnection(connectionString);

            //3. Open Connection
            connectDb.Open();

            //4. Prepare Query
            string CardName = nameInput.Text;
            string CardType = cardType.Text;
            string CollectionSelect = collectionInput.Text;
            string MarketPlace = marketPlaceInput.Text;

            //Convert the image to a byte array
            byte[] imageByte = ConvertImageToBytes(imageDisplay.Source);

            /* string Query = "INSERT INTO CardsRegistered (CardName,CardType,CardCollection,CardLink,CardImg) VALUES ('" + CardName+"', '"+CardType+"', '"+CollectionSelect+"', '"+MarketPlace+"', '"+imageByte+"')   "; */
            string Query = "INSERT INTO CardsRegistered(CardName, CardType, CardCollection,CardLink,CardImg) VALUES(@CardName,@CardType, @CollectionSelect,@MarketPlace, @ImageData)";

            //5. Execute Query
            SqlCommand cmd = new SqlCommand(Query, connectDb);
              cmd.Parameters.Add(new SqlParameter("@CardName", CardName));
             cmd.Parameters.Add(new SqlParameter("@CardType", CardType));
             cmd.Parameters.Add(new SqlParameter("@CollectionSelect", CollectionSelect));
             cmd.Parameters.Add(new SqlParameter("@MarketPlace", MarketPlace));
             cmd.Parameters.Add(new SqlParameter("@ImageData", imageByte));
             cmd.ExecuteNonQuery();
          
            

            //Saving image

            //Fixed directory path for saving images
            string saveDirectory = @"D:\files\Coding_Projects\PersonalGatherer-main-20231101T205132Z-001\PersonalGatherer-main\Cards_Database\Media\collectionPageMedia\UploadedImages";

            //The file name is the name the user inserted in the nameInput field
            string fileName = nameInput.Text + ".png";

            string savePath = System.IO.Path.Combine(saveDirectory, fileName);


            //Saving the imageDisplay as a file
            BitmapSource bitmapSource = (BitmapSource)imageDisplay.Source;

            if(bitmapSource!= null)
            {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapSource));


                //Create the directory if it doesn't exist
                Directory.CreateDirectory(saveDirectory);
                using (FileStream stream = new FileStream(savePath, FileMode.Create))
                {
                    encoder.Save(stream);
                }
                MessageBox.Show("Data inserted, and the image is saved to " + savePath);
            }
            else
            {
                MessageBox.Show("No image inserted to save!");
            }

            //6. Close Connection
            connectDb.Close();

            MessageBox.Show("Data inserted");
        }
    }
}
