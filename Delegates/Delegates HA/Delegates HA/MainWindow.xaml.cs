using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace Delegates_HA
{
    public partial class MainWindow : Window
    {

 
        Func<int, int, int> Calculation;

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
          return x * y;
        }

        public int Addition(int x, int y)
        {
            return x + y;
        }

        public int Moudulu(int x, int y)
        {
            return x % y;
        }

        public int Power(int x, int power)
        {
            int number = 0;
            for (int i = 0; i < power; i++)
            {
                number += (x * x);
            }

            return number;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

   
        public MainWindow()
        {
            InitializeComponent();
            
           

        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int index = Combobox.SelectedIndex;

            switch (index)
            {

                case 0:
                    Calculation = Subtract;
                    break;
                case 1:
                    Calculation = Multiply;
                    break;
                case 2:
                    Calculation = Addition;
                    break;
                case 3:
                    Calculation = Moudulu;
                    break;
                case 4:
                    Calculation = Power;
                    break;
                case 5:
                    Calculation = Divide;
                    break;


            }

            int num1 = int.Parse(NumberX.Text);
            int num2 = int.Parse(NumberY.Text);
            Result.Content = Calculation(num1, num2).ToString();


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }

        private void NumberX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NumberY_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
