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

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtBirthdate.Text = "";
            txtName.Text = string.Empty;
            txtName.Clear();

            wndMain.Background = Brushes.Firebrick;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string bdate = txtBirthdate.Text;

            DateTime birthdate = Convert.ToDateTime(bdate);

            var age = DateTime.Now - birthdate;

            lstOutput.Items.Add((age.TotalDays / 365).ToString("N0"));
            //MessageBox.Show($"You are {(age.TotalDays / 365).ToString("N0")} years old");
        }

        private void btnCalculate_MouseEnter(object sender, MouseEventArgs e)
        {
            wndMain.Background = Brushes.Magenta;
        }

        private void btnCalculate_MouseLeave(object sender, MouseEventArgs e)
        {
            wndMain.Background = Brushes.Firebrick;
        }
    }
}
