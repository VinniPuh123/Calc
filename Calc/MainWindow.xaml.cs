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
        double nu1, nu2;
        int choise = 0;
        string bn1 = "0", bn2 = "0", choiseSimbol;
        bool newCalc1 = true, newCalc2 = true, isInput = false, dot1 = false, dot2 = false, result = false, firstZero = true, secondZero = true;

        public void Erese()
        {
            result = false;
            choise = 0;
            bn1 = "0";
            bn2 = "0";
            newCalc1 = true;
            newCalc2 = true;
            isInput = false;
            dot1 = false;
            dot2 = false;
            result = false;
            numbersText.Content = 0;
        }
        private void n2_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
            if (!isInput)
            {
                if (newCalc1)
                {
                    bn1 = "2";
                    newCalc1 = false;
                }
                else
                {
                    bn1 = bn1 + "2";
                }

                numbersText.Content = bn1;
            }
            else
            {
                if (newCalc2)
                {
                    bn2 = "2";
                    newCalc2 = false;
                }
                else
                {
                    bn2 = bn2 + "2";
                }

                numbersText.Content = bn1 + choiseSimbol + bn2;
            }

        }

        private void n3_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
            if (!isInput)
            {
                if (newCalc1)
                {
                    bn1 = "3";
                    newCalc1 = false;
                }
                else
                {
                    bn1 = bn1 + "3";
                }

                numbersText.Content = bn1;
            }
            else
            {
                if (newCalc2)
                {
                    bn2 = "3";
                    newCalc2 = false;
                }
                else
                {
                    bn2 = bn2 + "3";
                }

                numbersText.Content = bn1 + choiseSimbol + bn2;
            }

        }

        private void n4_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
            if (!isInput)
            {
                if (newCalc1)
                {
                    bn1 = "4";
                    newCalc1 = false;
                }
                else
                {
                    bn1 = bn1 + "4";
                }

                numbersText.Content = bn1;
            }
            else
            {
                if (newCalc2)
                {
                    bn2 = "4";
                    newCalc2 = false;
                }
                else
                {
                    bn2 = bn2 + "4";
                }

                numbersText.Content = bn1 + choiseSimbol + bn2;
            }

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            choise = 1;
            choiseSimbol= "+";
            numbersText.Content = bn1 + choiseSimbol + bn2;
            isInput = true;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            choise= 2;
            choiseSimbol= "-";
            numbersText.Content = bn1 + choiseSimbol + bn2;
            isInput = true;
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            choise= 3;
            choiseSimbol= "x";
            numbersText.Content = bn1 + choiseSimbol + bn2;
            isInput = true;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            choise= 4;
            choiseSimbol= "/";
            numbersText.Content = bn1 + choiseSimbol + bn2;
            isInput = true;
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            if (bn1 != null & bn2 != null & choise != 0)
            {
                nu1 = Convert.ToDouble(bn1);
                nu2 = Convert.ToDouble(bn2);
                if (choise == 1)
                {
                    numbersText.Content = nu1 + nu2;
                }
                if (choise == 2)
                {
                    numbersText.Content = nu1 - nu2;
                }
                if (choise == 3)
                {
                    numbersText.Content = nu1 * nu2;
                }
                if (choise == 4)
                {
                    if (nu2 == 0)
                    {
                        numbersText.Content = "Error";
                    }
                    else
                    {
                        numbersText.Content = nu1 / nu2;
                    }
                }
                result = true;
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Erese();
        }

        private void n5_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
            if (!isInput)
            {
                if (newCalc1)
                {
                    bn1 = "5";
                    newCalc1 = false;
                }
                else
                {
                    bn1 = bn1 + "5";
                }

                numbersText.Content = bn1;
            }
            else
            {
                if (newCalc2)
                {
                    bn2 = "5";
                    newCalc2 = false;
                }
                else
                {
                    bn2 = bn2 + "5";
                }

                numbersText.Content = bn1 + choiseSimbol + bn2;
            }

        }

        private void n6_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
            if (!isInput)
            {
                if (newCalc1)
                {
                    bn1 = "6";
                    newCalc1 = false;
                }
                else
                {
                    bn1 = bn1 + "6";
                }

                numbersText.Content = bn1;
            }
            else
            {
                if (newCalc2)
                {
                    bn2 = "6";
                    newCalc2 = false;
                }
                else
                {
                    bn2 = bn2 + "6";
                }

                numbersText.Content = bn1 + choiseSimbol + bn2;
            }

        }

        private void n7_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
            if (!isInput)
            {
                if (newCalc1)
                {
                    bn1 = "7";
                    newCalc1 = false;
                }
                else
                {
                    bn1 = bn1 + "7";
                }

                numbersText.Content = bn1;
            }
            else
            {
                if (newCalc2)
                {
                    bn2 = "7";
                    newCalc2 = false;
                }
                else
                {
                    bn2 = bn2 + "7";
                }

                numbersText.Content = bn1 + choiseSimbol + bn2;
            }

        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            if (!isInput)
            {
                if (dot1 == false)
                {
                    bn1 = bn1 + ",";
                    numbersText.Content = bn1;
                    dot1= true;
                    newCalc1= false;
                }
            }
            else
            {
                if (dot2 == false)
                {
                    bn2 = bn2 + ",";
                    numbersText.Content = bn1 + choiseSimbol + bn2;
                    dot2 = true;
                    newCalc2= false;
                }
            }
        }

        private void n8_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
            if (!isInput)
            {
                if (newCalc1)
                {
                    bn1 = "8";
                    newCalc1 = false;
                }
                else
                {
                    bn1 = bn1 + "8";
                }

                numbersText.Content = bn1;
            }
            else
            {
                if (newCalc2)
                {
                    bn2 = "8";
                    newCalc2 = false;
                }
                else
                {
                    bn2 = bn2 + "8";
                }

                numbersText.Content = bn1 + choiseSimbol + bn2;
            }

        }

        private void n9_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
                if (!isInput)
                {
                    if (newCalc1)
                {
                    bn1 = "9";
                    newCalc1= false;
                }
                else
                {
                    bn1 = bn1 + "9";
                }
                    
                    numbersText.Content = bn1;
                }
                else
                {
                if (newCalc2)
                {
                    bn2 = "9";
                    newCalc2 = false;
                } else
                {
                    bn2 = bn2 + "9";
                }

                    numbersText.Content = bn1 + choiseSimbol + bn2;
                }
            
        }

        private void n1_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
            if (!isInput)
            {
                if (newCalc1)
                {
                    bn1 = "1";
                    newCalc1 = false;
                }
                else
                {
                    bn1 = bn1 + "1";
                }
                numbersText.Content = bn1;
            }
            else
            {
                if (newCalc2)
                {
                    bn2 = "1";
                    newCalc2 = false;
                } else
                {
                    bn2 = bn2 + "1";
                }
                numbersText.Content = bn1 + choiseSimbol + bn2;
            }
            
        }
        public MainWindow()
        {
            InitializeComponent();
            numbersText.Content = 0;
        }

        private void n0_Click(object sender, RoutedEventArgs e)
        {
            if (result)
            {
                Erese();
            }
            if (!isInput)
            {
                if (newCalc1)
                {
                    numbersText.Content = bn1;
                }
                else
                {
                    numbersText.Content = bn1 + "0";
                    bn1 = bn1 + "0";
                }
            }
            else
            {
                if (!newCalc2)
                {
                    bn2 = bn2 + "0";
                    numbersText.Content = bn1 + choiseSimbol + bn2;
                }
            }
        }
    }   
}

