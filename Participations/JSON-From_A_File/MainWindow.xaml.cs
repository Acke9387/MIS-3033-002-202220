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

namespace JSON_From_A_File
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<CarOwner> data = new List<CarOwner>();

        public MainWindow()
        {
            InitializeComponent();

            string json = File.ReadAllText("Mock_Data_Car_Owners.json");


            data = JsonConvert.DeserializeObject<List<CarOwner>>(json);

            cboColors.Items.Add("All");
            cboColors.SelectedIndex = 0;

            foreach (var item in data)
            {
                string answer = "";
                if (cboColors.Items.Contains(item.Color) == false)
                {
                    cboColors.Items.Add(item.Color); 
                }

                lstData.Items.Add(item);
            }

        }

        private void cboColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedColor = (string)cboColors.SelectedItem;

            lstData.Items.Clear();
            foreach (var item in data)
            {
                if (item.Color == selectedColor)
                {
                    lstData.Items.Add(item);
                }
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string dataASJSON = JsonConvert.SerializeObject(lstData.Items);

            File.WriteAllText($"{cboColors.SelectedItem.ToString()}_Filtered_Car_Owner.json", dataASJSON);

            MessageBox.Show("Successfully Saved");

        }
    }
}
