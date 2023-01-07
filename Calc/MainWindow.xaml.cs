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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private const char DOT = ',';

        string firstNumber = "0";
        string secondNumber = "0";
        char choiseSimbol;
        bool result = false;

        public void Erese()
        {
            result = false;
            firstNumber = "0";
            secondNumber = "0";
            result = false;
            numbersText.Content = 0;
            choiseSimbol = '\0';
        }
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var number = button.Content.ToString();
            if (result)
            {
                Erese();
            }
            if (choiseSimbol == '\0')
            {
                firstNumber = firstNumber + number;
                if (firstNumber.Contains(DOT) & number == "0")
                {
                    numbersText.Content = firstNumber;
                }
                else
                {
                    numbersText.Content = Convert.ToDouble(firstNumber).ToString();
                }
            }
            else
            {
                secondNumber = secondNumber + number;
                if (firstNumber.Contains(DOT) & number == "0")
                {
                    numbersText.Content = Convert.ToDouble(firstNumber).ToString() + choiseSimbol + secondNumber;
                }
                else
                {
                    numbersText.Content = Convert.ToDouble(firstNumber).ToString() + choiseSimbol + Convert.ToDouble(secondNumber).ToString();
                }
            }

        }

        private void ProcessButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            choiseSimbol = button.Content.ToString()[0];
            numbersText.Content = Convert.ToDouble(firstNumber).ToString() + choiseSimbol + Convert.ToDouble(secondNumber).ToString();
        }


        private void equal_Click(object sender, RoutedEventArgs e)
        {
            if (choiseSimbol != '\0')
            {

                double nu1 = Convert.ToDouble(firstNumber);
                double nu2 = Convert.ToDouble(secondNumber);
                switch (choiseSimbol)
                {
                    case '+':
                        numbersText.Content = nu1 + nu2;
                        break;
                    case '*':
                        numbersText.Content = nu1 * nu2;
                        break;
                    case '-':
                        numbersText.Content = nu1 - nu2;
                        break;
                    case '/':
                        numbersText.Content = nu1 / nu2;
                        break;
                }
                result = true;
            }
            
        
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Erese();
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            if (choiseSimbol == '\0')
            {
                if (!firstNumber.Contains(DOT))
                {
                    firstNumber = Convert.ToDouble(firstNumber).ToString() + DOT;
                    numbersText.Content = firstNumber;
                }
            }
            else
            {
                if (!secondNumber.Contains(DOT))
                {
                    secondNumber = secondNumber + DOT;
                    numbersText.Content = Convert.ToDouble(firstNumber).ToString() + choiseSimbol + Convert.ToDouble(secondNumber).ToString();
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            numbersText.Content = 0;
        }
    }
}

