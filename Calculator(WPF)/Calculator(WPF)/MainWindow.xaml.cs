using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Calculator_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isFirstDigit = true;
        decimal firstNum, secondNum, curInput, result;
        NumberStyles style;
        CultureInfo culture;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateNumber(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            if (isFirstDigit)
            {
                txtResult.Text = b.Content.ToString();
                isFirstDigit = false;
            }
            else
            {
                txtResult.Text += b.Content.ToString();
            }

            Decimal.TryParse(txtResult.Text, style, culture, out firstNum);
        }

        private void PlusClick(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "+";
        }

        private void MinusClick(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "-";
        }
    }
}
