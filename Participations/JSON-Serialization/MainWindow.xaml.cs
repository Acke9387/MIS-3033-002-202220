using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

namespace JSON_Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Game> Data = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();

            string[] linesOfFile = File.ReadAllLines("all_games.csv");

            //for (int i = 1; i < linesOfFile.Length; i++)
            //{

            //}


            foreach (var game in linesOfFile.Skip(1))
            {
                Game g = new Game(game);

                if (!cboPlatform.Items.Contains(g.platform))
                {
                    cboPlatform.Items.Add(g.platform); 
                }

                Data.Add(g);
                lstData.Items.Add(g);
            }
        }

        private void cboPlatform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPlatform = cboPlatform.SelectedItem.ToString();

            lstData.Items.Clear();
            foreach (var item in Data)
            {
                if (item.platform == selectedPlatform)
                {
                    lstData.Items.Add(item);
                }
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string jsonOutput = JsonConvert.SerializeObject(lstData.Items);
            //List<Game> games = JsonConvert.DeserializeObject<List<Game>>(jsonOutput);

            File.WriteAllText($"{cboPlatform.SelectedItem.ToString()}_Games.json", jsonOutput);

            MessageBox.Show("Saved successfully");
        }
    }
}
