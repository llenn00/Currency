using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CurrencyApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CurrencyController
            currencyController;
        public MainWindow()
        {
            InitializeComponent();
            currencyController = new CurrencyController();
        }

        private void Button_Hitung_Click(object sender, RoutedEventArgs e)
        {
            //Pelatihan 1
            /*var nominalString = InputTextBox.Text;
            resultLabel.Content = nominalString;*/

            //Pelatihan 2
            /*var nominalString = InputTextBox.Text;
            var nominalDouble = Convert.ToDouble(nominalString);
            resultLabel.Content = Convert.ToString(nominalDouble * 10000);*/

            //pelatihan 3
            /*var nominalString = InputTextBox.Text;
            Regex regex = new Regex("[^0-9.-]+");
            if (!regex.IsMatch(nominalString))
            {
                var nominalDouble = Convert.ToDouble(nominalString);
                resultLabel.Content = Convert.ToString(nominalDouble * 4);
            }
            else
            {
                resultLabel.Content = "Invalid";
            }*/
            //pakai currency controller
            var nominalInput = InputTextBox.Text;
            var result = "invalid";
            if (currencyController.isAllowed(nominalInput))
            {
                result = currencyController.usdToIdr(nominalInput);
            }
            resultLabel.Content = result;

        }
    }
}
