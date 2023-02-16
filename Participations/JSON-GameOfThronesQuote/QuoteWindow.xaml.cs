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

namespace JSON_GameOfThronesQuote
{
    /// <summary>
    /// Interaction logic for QuoteWindow.xaml
    /// </summary>
    public partial class QuoteWindow : Window
    {
        public QuoteWindow()
        {
            InitializeComponent();
        }

        public void SetData(GOTAPI api)
        {
            lblQuote.Content = $"{api.sentence} - {api.character.name}";

            switch (api.character.name)
            {
                case "Jon Snow":
                    imgBackground.Source = new BitmapImage(new Uri("https://i.insider.com/56e33c1edd089557478b48b7?width=1000&format=jpeg&auto=webp"));
                    break;
                case "Sansa Stark":
                    imgBackground.Source = new BitmapImage(new Uri("https://static.wikia.nocookie.net/gameofthrones/images/6/63/QueenSansa.PNG/revision/latest?cb=20210215100224"));
                    break;
                case "Tyrion Lannister":
                    imgBackground.Source = new BitmapImage(new Uri("https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/peter-dinklage-game-of-thrones-tyrion-lannister-1554188996.jpg"));
                    break;
                case "Daenerys Targaryen":
                    imgBackground.Source = new BitmapImage(new Uri("https://media.gq.com/photos/5cdeca27b41d09adcdcd77ee/1:1/w_1295,h_1295,c_limit/Antiheroism-Of-Daenerys-Targaryen-gq-1-game-of-thrones.jpg"));
                    break;
                default:
                    imgBackground.Source = new BitmapImage(new Uri("https://assets-prd.ignimgs.com/2022/01/14/gameofthrones-allseasons-sq-1642120207458.jpg"));
                    break;
            }
        }

    }
}
