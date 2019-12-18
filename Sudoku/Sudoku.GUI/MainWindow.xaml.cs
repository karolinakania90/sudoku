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

namespace Sudoku.GUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int Plus(int Value)
        {
            Value++;
            if (Value > 9) {
                Value = 1;
            }
            return Value;
        }
        public string CheckString(string Value)
        {
            if (Value == "")
            {
                Value = "0";
                return Value;
            }
            return Value;
        }
        private void Button_0_0_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_0_0.Content.ToString()));
            Button_0_0.Content = Plus(number).ToString();
        }

        private void Button_1_0_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_1_0.Content.ToString()));
            Button_1_0.Content = Plus(number).ToString();
        }

        private void Button_2_0_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_2_0.Content.ToString()));
            Button_2_0.Content = Plus(number).ToString();
        }

        private void Button_3_0_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_3_0.Content.ToString()));
            Button_3_0.Content = Plus(number).ToString();
        }

        private void Button_4_0_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_4_0.Content.ToString()));
            Button_4_0.Content = Plus(number).ToString();
        }

        private void Button_5_0_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_5_0.Content.ToString()));
            Button_5_0.Content = Plus(number).ToString();
        }

        private void Button_6_0_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_6_0.Content.ToString()));
            Button_6_0.Content = Plus(number).ToString();
        }

        private void Button_7_0_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_7_0.Content.ToString()));
            Button_7_0.Content = Plus(number).ToString();
        }

        private void Button_8_0_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_8_0.Content.ToString()));
            Button_8_0.Content = Plus(number).ToString();
        }

        private void Button_0_1_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_0_1.Content.ToString()));
            Button_0_1.Content = Plus(number).ToString();
        }

        private void Button_1_1_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_1_1.Content.ToString()));
            Button_1_1.Content = Plus(number).ToString();
        }

        private void Button_2_1_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_2_1.Content.ToString()));
            Button_2_1.Content = Plus(number).ToString();
        }

        private void Button_3_1_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_3_1.Content.ToString()));
            Button_3_1.Content = Plus(number).ToString();
        }

        private void Button_4_1_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_4_1.Content.ToString()));
            Button_4_1.Content = Plus(number).ToString();
        }

        private void Button_5_1_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_5_1.Content.ToString()));
            Button_5_1.Content = Plus(number).ToString();
        }

        private void Button_6_1_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_6_1.Content.ToString()));
            Button_6_1.Content = Plus(number).ToString();
        }

        private void Button_7_1_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_7_1.Content.ToString()));
            Button_7_1.Content = Plus(number).ToString();
        }

        private void Button_8_1_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_8_1.Content.ToString()));
            Button_8_1.Content = Plus(number).ToString();
        }

        private void Button_0_2_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_0_2.Content.ToString()));
            Button_0_2.Content = Plus(number).ToString();
        }

        private void Button_1_2_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_1_2.Content.ToString()));
            Button_1_2.Content = Plus(number).ToString();
        }

        private void Button_2_2_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_2_2.Content.ToString()));
            Button_2_2.Content = Plus(number).ToString();
        }

        private void Button_3_2_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_3_2.Content.ToString()));
            Button_3_2.Content = Plus(number).ToString();
        }

        private void Button_4_2_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_4_2.Content.ToString()));
            Button_4_2.Content = Plus(number).ToString();
        }

        private void Button_5_2_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_5_2.Content.ToString()));
            Button_5_2.Content = Plus(number).ToString();
        }

        private void Button_6_2_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_6_2.Content.ToString()));
            Button_6_2.Content = Plus(number).ToString();
        }

        private void Button_7_2_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_7_2.Content.ToString()));
            Button_7_2.Content = Plus(number).ToString();
        }

        private void Button_8_2_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_8_2.Content.ToString()));
            Button_8_2.Content = Plus(number).ToString();
        }

        private void Button_0_3_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_0_3.Content.ToString()));
            Button_0_3.Content = Plus(number).ToString();
        }

        private void Button_1_3_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_1_3.Content.ToString()));
            Button_1_3.Content = Plus(number).ToString();
        }

        private void Button_2_3_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_2_3.Content.ToString()));
            Button_2_3.Content = Plus(number).ToString();
        }

        private void Button_3_3_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_3_3.Content.ToString()));
            Button_3_3.Content = Plus(number).ToString();
        }

        private void Button_4_3_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_4_3.Content.ToString()));
            Button_4_3.Content = Plus(number).ToString();
        }

        private void Button_5_3_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_5_3.Content.ToString()));
            Button_5_3.Content = Plus(number).ToString();
        }

        private void Button_6_3_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_6_3.Content.ToString()));
            Button_6_3.Content = Plus(number).ToString();
        }

        private void Button_7_3_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_7_3.Content.ToString()));
            Button_7_3.Content = Plus(number).ToString();
        }

        private void Button_8_3_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_8_3.Content.ToString()));
            Button_8_3.Content = Plus(number).ToString();
        }

        private void Button_0_4_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_0_4.Content.ToString()));
            Button_0_4.Content = Plus(number).ToString();
        }

        private void Button_1_4_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_1_4.Content.ToString()));
            Button_1_4.Content = Plus(number).ToString();
        }

        private void Button_2_4_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_2_4.Content.ToString()));
            Button_2_4.Content = Plus(number).ToString();
        }

        private void Button_3_4_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_3_4.Content.ToString()));
            Button_3_4.Content = Plus(number).ToString();
        }

        private void Button_4_4_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_4_4.Content.ToString()));
            Button_4_4.Content = Plus(number).ToString();
        }

        private void Button_5_4_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_5_4.Content.ToString()));
            Button_5_4.Content = Plus(number).ToString();
        }

        private void Button_6_4_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_6_4.Content.ToString()));
            Button_6_4.Content = Plus(number).ToString();
        }

        private void Button_7_4_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_7_4.Content.ToString()));
            Button_7_4.Content = Plus(number).ToString();
        }

        private void Button_8_4_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_8_4.Content.ToString()));
            Button_8_4.Content = Plus(number).ToString();
        }

        private void Button_0_5_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_0_5.Content.ToString()));
            Button_0_5.Content = Plus(number).ToString();
        }

        private void Button_1_5_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_1_5.Content.ToString()));
            Button_1_5.Content = Plus(number).ToString();
        }

        private void Button_2_5_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_2_5.Content.ToString()));
            Button_2_5.Content = Plus(number).ToString();
        }

        private void Button_3_5_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_3_5.Content.ToString()));
            Button_3_5.Content = Plus(number).ToString();
        }

        private void Button_4_5_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_4_5.Content.ToString()));
            Button_4_5.Content = Plus(number).ToString();
        }

        private void Button_5_5_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_5_5.Content.ToString()));
            Button_5_5.Content = Plus(number).ToString();
        }

        private void Button_6_5_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_6_5.Content.ToString()));
            Button_6_5.Content = Plus(number).ToString();
        }

        private void Button_7_5_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_7_5.Content.ToString()));
            Button_7_5.Content = Plus(number).ToString();
        }

        private void Button_8_5_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_8_5.Content.ToString()));
            Button_8_5.Content = Plus(number).ToString();
        }

        private void Button_0_6_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_0_6.Content.ToString()));
            Button_0_6.Content = Plus(number).ToString();
        }

        private void Button_1_6_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_1_6.Content.ToString()));
            Button_1_6.Content = Plus(number).ToString();
        }

        private void Button_2_6_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_2_6.Content.ToString()));
            Button_2_6.Content = Plus(number).ToString();
        }

        private void Button_3_6_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_3_6.Content.ToString()));
            Button_3_6.Content = Plus(number).ToString();
        }

        private void Button_4_6_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_4_6.Content.ToString()));
            Button_4_6.Content = Plus(number).ToString();
        }

        private void Button_5_6_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_5_6.Content.ToString()));
            Button_5_6.Content = Plus(number).ToString();
        }

        private void Button_6_6_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_6_6.Content.ToString()));
            Button_6_6.Content = Plus(number).ToString();
        }

        private void Button_7_6_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_7_6.Content.ToString()));
            Button_7_6.Content = Plus(number).ToString();
        }

        private void Button_8_6_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_8_6.Content.ToString()));
            Button_8_6.Content = Plus(number).ToString();
        }

        private void Button_0_7_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_0_7.Content.ToString()));
            Button_0_7.Content = Plus(number).ToString();
        }

        private void Button_1_7_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_1_7.Content.ToString()));
            Button_1_7.Content = Plus(number).ToString();
        }

        private void Button_2_7_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_2_7.Content.ToString()));
            Button_2_7.Content = Plus(number).ToString();
        }

        private void Button_3_7_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_3_7.Content.ToString()));
            Button_3_7.Content = Plus(number).ToString();
        }

        private void Button_4_7_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_4_7.Content.ToString()));
            Button_4_7.Content = Plus(number).ToString();
        }

        private void Button_5_7_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_5_7.Content.ToString()));
            Button_5_7.Content = Plus(number).ToString();
        }

        private void Button_6_7_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_6_7.Content.ToString()));
            Button_6_7.Content = Plus(number).ToString();
        }

        private void Button_7_7_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_7_7.Content.ToString()));
            Button_7_7.Content = Plus(number).ToString();
        }

        private void Button_8_7_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_8_7.Content.ToString()));
            Button_8_7.Content = Plus(number).ToString();
        }

        private void Button_0_8_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_0_8.Content.ToString()));
            Button_0_8.Content = Plus(number).ToString();
        }

        private void Button_1_8_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_1_8.Content.ToString()));
            Button_1_8.Content = Plus(number).ToString();
        }

        private void Button_2_8_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_2_8.Content.ToString()));
            Button_2_8.Content = Plus(number).ToString();
        }

        private void Button_3_8_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_3_8.Content.ToString()));
            Button_3_8.Content = Plus(number).ToString();
        }

        private void Button_4_8_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_4_8.Content.ToString()));
            Button_4_8.Content = Plus(number).ToString();
        }

        private void Button_5_8_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_5_8.Content.ToString()));
            Button_5_8.Content = Plus(number).ToString();
        }

        private void Button_6_8_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_6_8.Content.ToString()));
            Button_6_8.Content = Plus(number).ToString();
        }

        private void Button_7_8_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_7_8.Content.ToString()));
            Button_7_8.Content = Plus(number).ToString();
        }

        private void Button_8_8_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(CheckString(Button_8_8.Content.ToString()));
            Button_8_8.Content = Plus(number).ToString();
        }
    }
}
