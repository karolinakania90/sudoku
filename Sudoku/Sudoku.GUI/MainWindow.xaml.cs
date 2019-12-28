using Sudoku.Engine;
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
        Button[,] tableButtons;
        public MainWindow()
        {
            InitializeComponent();

            //---------------------
            tableButtons = new Button[9, 9];
            tableButtons[0, 0] = Button_0_0;
            tableButtons[0, 1] = Button_0_1;
            tableButtons[0, 2] = Button_0_2;
            tableButtons[0, 3] = Button_0_3;
            tableButtons[0, 4] = Button_0_4;
            tableButtons[0, 5] = Button_0_5;
            tableButtons[0, 6] = Button_0_6;
            tableButtons[0, 7] = Button_0_7;
            tableButtons[0, 8] = Button_0_8;
            tableButtons[1, 0] = Button_1_0;
            tableButtons[1, 1] = Button_1_1;
            tableButtons[1, 2] = Button_1_2;
            tableButtons[1, 3] = Button_1_3;
            tableButtons[1, 4] = Button_1_4;
            tableButtons[1, 5] = Button_1_5;
            tableButtons[1, 6] = Button_1_6;
            tableButtons[1, 7] = Button_1_7;
            tableButtons[1, 8] = Button_1_8;
            tableButtons[2, 0] = Button_2_0;
            tableButtons[2, 1] = Button_2_1;
            tableButtons[2, 2] = Button_2_2;
            tableButtons[2, 3] = Button_2_3;
            tableButtons[2, 4] = Button_2_4;
            tableButtons[2, 5] = Button_2_5;
            tableButtons[2, 6] = Button_2_6;
            tableButtons[2, 7] = Button_2_7;
            tableButtons[2, 8] = Button_2_8;
            tableButtons[3, 0] = Button_3_0;
            tableButtons[3, 1] = Button_3_1;
            tableButtons[3, 2] = Button_3_2;
            tableButtons[3, 3] = Button_3_3;
            tableButtons[3, 4] = Button_3_4;
            tableButtons[3, 5] = Button_3_5;
            tableButtons[3, 6] = Button_3_6;
            tableButtons[3, 7] = Button_3_7;
            tableButtons[3, 8] = Button_3_8;
            tableButtons[4, 0] = Button_4_0;
            tableButtons[4, 1] = Button_4_1;
            tableButtons[4, 2] = Button_4_2;
            tableButtons[4, 3] = Button_4_3;
            tableButtons[4, 4] = Button_4_4;
            tableButtons[4, 5] = Button_4_5;
            tableButtons[4, 6] = Button_4_6;
            tableButtons[4, 7] = Button_4_7;
            tableButtons[4, 8] = Button_4_8;
            tableButtons[5, 0] = Button_5_0;
            tableButtons[5, 1] = Button_5_1;
            tableButtons[5, 2] = Button_5_2;
            tableButtons[5, 3] = Button_5_3;
            tableButtons[5, 4] = Button_5_4;
            tableButtons[5, 5] = Button_5_5;
            tableButtons[5, 6] = Button_5_6;
            tableButtons[5, 7] = Button_5_7;
            tableButtons[5, 8] = Button_5_8;
            tableButtons[6, 0] = Button_6_0;
            tableButtons[6, 1] = Button_6_1;
            tableButtons[6, 2] = Button_6_2;
            tableButtons[6, 3] = Button_6_3;
            tableButtons[6, 4] = Button_6_4;
            tableButtons[6, 5] = Button_6_5;
            tableButtons[6, 6] = Button_6_6;
            tableButtons[6, 7] = Button_6_7;
            tableButtons[6, 8] = Button_6_8;
            tableButtons[7, 0] = Button_7_0;
            tableButtons[7, 1] = Button_7_1;
            tableButtons[7, 2] = Button_7_2;
            tableButtons[7, 3] = Button_7_3;
            tableButtons[7, 4] = Button_7_4;
            tableButtons[7, 5] = Button_7_5;
            tableButtons[7, 6] = Button_7_6;
            tableButtons[7, 7] = Button_7_7;
            tableButtons[7, 8] = Button_7_8;
            tableButtons[8, 0] = Button_8_0;
            tableButtons[8, 1] = Button_8_1;
            tableButtons[8, 2] = Button_8_2;
            tableButtons[8, 3] = Button_8_3;
            tableButtons[8, 4] = Button_8_4;
            tableButtons[8, 5] = Button_8_5;
            tableButtons[8, 6] = Button_8_6;
            tableButtons[8, 7] = Button_8_7;
            tableButtons[8, 8] = Button_8_8;
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

        // Paint squares
        public void Paint(int Column, int Poem)
        {
            //Button_0_0 -> Button_[kolumna]_[wiersz]
            // y -> kolumna
            // x -> wiersz
            for (int x = 0; x < tableButtons.Length - 72; x++)
            {
                for (int y = 0; y < tableButtons.Length - 72; y++)
                {
                    if (y == Column || x == Poem)
                    {
                        tableButtons[y,x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                    }
                }
            }
            for (int x = PositionX(Poem); x < (PositionX(Poem)+3); x++)
            {
                for (int y = PositionY(Column); y < (PositionY(Column)+3); y++)
                {
                     tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                }
            }
        }
        public void PaintInitial(int Column, int Poem)
        {
            //Button_0_0 -> Button_[kolumna]_[wiersz]
            // y -> kolumna
            // x -> wiersz
            for (int x = 0; x < tableButtons.Length - 72; x++)
            {
                for (int y= 0; y < tableButtons.Length - 72; y++)
                {
                    if (y == Column || x == Poem)
                    {
                        tableButtons[y,x].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                    }
                }
            }
            for (int x = PositionX(Poem); x < (PositionX(Poem) + 3); x++)
            {
                for (int y = PositionY(Column); y < (PositionY(Column) + 3); y++)
                {
                    tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                }
            }
        }
        public int PositionY(int Column)
        {
            int y = 0;
            if(Column > -1 && Column < 3)
            {
                y = 0;
            }
            if (Column > 2 && Column < 6)
            {
                y = 3;
            }
            if (Column > 5 && Column < 9)
            {
                y = 6;
            }
            return y;
        }
        public int PositionX(int Poem)
        {
            int x = 0;
            if (Poem > -1 && Poem < 3)
            {
                x = 0;
            }
            if (Poem > 2 && Poem < 6)
            {
                x = 3;
            }
            if (Poem > 5 && Poem < 9)
            {
                x = 6;
            }
            return x;
        }
        private void Button_0_0_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_0_0.Name.Split('_')[1]), Int32.Parse(Button_0_0.Name.Split('_')[2]));
        }

        private void Button_0_0_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_0_0.Name.Split('_')[1]), Int32.Parse(Button_0_0.Name.Split('_')[2]));
        }
        private void Button_1_0_MouseMove(object sender, MouseEventArgs e)
        {          
            Paint(Int32.Parse(Button_1_0.Name.Split('_')[1]), Int32.Parse(Button_1_0.Name.Split('_')[2]));
        }
        private void Button_1_0_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_1_0.Name.Split('_')[1]), Int32.Parse(Button_1_0.Name.Split('_')[2]));
        }
        private void Button_0_1_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_0_1.Name.Split('_')[1]), Int32.Parse(Button_0_1.Name.Split('_')[2]));
        }
        private void Button_0_1_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_0_1.Name.Split('_')[1]), Int32.Parse(Button_0_1.Name.Split('_')[2]));
        }
        private void Button_2_0_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_2_0.Name.Split('_')[1]), Int32.Parse(Button_2_0.Name.Split('_')[2]));
        }
        private void Button_2_0_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_2_0.Name.Split('_')[1]), Int32.Parse(Button_2_0.Name.Split('_')[2]));
        }
        private void Button_1_1_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_1_1.Name.Split('_')[1]), Int32.Parse(Button_1_1.Name.Split('_')[2]));
        }
        private void Button_1_1_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_1_1.Name.Split('_')[1]), Int32.Parse(Button_1_1.Name.Split('_')[2]));
        }
        private void Button_2_1_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_2_1.Name.Split('_')[1]), Int32.Parse(Button_2_1.Name.Split('_')[2]));
        }
        private void Button_2_1_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_2_1.Name.Split('_')[1]), Int32.Parse(Button_2_1.Name.Split('_')[2]));
        }
        private void Button_0_2_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_0_2.Name.Split('_')[1]), Int32.Parse(Button_0_2.Name.Split('_')[2]));
        }
        private void Button_0_2_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_0_2.Name.Split('_')[1]), Int32.Parse(Button_0_2.Name.Split('_')[2]));
        }
        private void Button_1_2_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_1_2.Name.Split('_')[1]), Int32.Parse(Button_1_2.Name.Split('_')[2]));
        }
        private void Button_1_2_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_1_2.Name.Split('_')[1]), Int32.Parse(Button_1_2.Name.Split('_')[2]));
        }
        private void Button_2_2_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_2_2.Name.Split('_')[1]), Int32.Parse(Button_2_2.Name.Split('_')[2]));
        }
        private void Button_2_2_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_2_2.Name.Split('_')[1]), Int32.Parse(Button_2_2.Name.Split('_')[2]));
        }
        private void Button_3_0_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_3_0.Name.Split('_')[1]), Int32.Parse(Button_3_0.Name.Split('_')[2]));
        }
        private void Button_3_0_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_3_0.Name.Split('_')[1]), Int32.Parse(Button_3_0.Name.Split('_')[2]));
        }
        private void Button_4_0_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_4_0.Name.Split('_')[1]), Int32.Parse(Button_4_0.Name.Split('_')[2]));
        }
        private void Button_4_0_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_4_0.Name.Split('_')[1]), Int32.Parse(Button_4_0.Name.Split('_')[2]));
        }
        private void Button_3_1_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_3_1.Name.Split('_')[1]), Int32.Parse(Button_3_1.Name.Split('_')[2]));
        }
        private void Button_3_1_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_3_1.Name.Split('_')[1]), Int32.Parse(Button_3_1.Name.Split('_')[2]));
        }
        private void Button_5_0_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_5_0.Name.Split('_')[1]), Int32.Parse(Button_5_0.Name.Split('_')[2]));
        }
        private void Button_5_0_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_5_0.Name.Split('_')[1]), Int32.Parse(Button_5_0.Name.Split('_')[2]));
        }
        private void Button_4_1_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_4_1.Name.Split('_')[1]), Int32.Parse(Button_4_1.Name.Split('_')[2]));
        }
        private void Button_4_1_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_4_1.Name.Split('_')[1]), Int32.Parse(Button_4_1.Name.Split('_')[2]));
        }
        private void Button_5_1_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_5_1.Name.Split('_')[1]), Int32.Parse(Button_5_1.Name.Split('_')[2]));
        }
        private void Button_5_1_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_5_1.Name.Split('_')[1]), Int32.Parse(Button_5_1.Name.Split('_')[2]));
        }
        private void Button_3_2_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_3_2.Name.Split('_')[1]), Int32.Parse(Button_3_2.Name.Split('_')[2]));
        }
        private void Button_3_2_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_3_2.Name.Split('_')[1]), Int32.Parse(Button_3_2.Name.Split('_')[2]));
        }
        private void Button_4_2_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_4_2.Name.Split('_')[1]), Int32.Parse(Button_4_2.Name.Split('_')[2]));
        }
        private void Button_4_2_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_4_2.Name.Split('_')[1]), Int32.Parse(Button_4_2.Name.Split('_')[2]));
        }
        private void Button_5_2_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_5_2.Name.Split('_')[1]), Int32.Parse(Button_5_2.Name.Split('_')[2]));
        }
        private void Button_5_2_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_5_2.Name.Split('_')[1]), Int32.Parse(Button_5_2.Name.Split('_')[2]));
        }
        private void Button_6_0_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_6_0.Name.Split('_')[1]), Int32.Parse(Button_6_0.Name.Split('_')[2]));
        }
        private void Button_6_0_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_6_0.Name.Split('_')[1]), Int32.Parse(Button_6_0.Name.Split('_')[2]));
        }
        private void Button_7_0_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_7_0.Name.Split('_')[1]), Int32.Parse(Button_7_0.Name.Split('_')[2]));
        }
        private void Button_7_0_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_7_0.Name.Split('_')[1]), Int32.Parse(Button_7_0.Name.Split('_')[2]));
        }
        private void Button_6_1_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_6_1.Name.Split('_')[1]), Int32.Parse(Button_6_1.Name.Split('_')[2]));
        }
        private void Button_6_1_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_6_1.Name.Split('_')[1]), Int32.Parse(Button_6_1.Name.Split('_')[2]));
        }
        private void Button_8_0_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_8_0.Name.Split('_')[1]), Int32.Parse(Button_8_0.Name.Split('_')[2]));
        }
        private void Button_8_0_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_8_0.Name.Split('_')[1]), Int32.Parse(Button_8_0.Name.Split('_')[2]));
        }
        private void Button_7_1_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_7_1.Name.Split('_')[1]), Int32.Parse(Button_7_1.Name.Split('_')[2]));
        }
        private void Button_7_1_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_7_1.Name.Split('_')[1]), Int32.Parse(Button_7_1.Name.Split('_')[2]));
        }
        private void Button_8_1_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_8_1.Name.Split('_')[1]), Int32.Parse(Button_8_1.Name.Split('_')[2]));
        }
        private void Button_8_1_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_8_1.Name.Split('_')[1]), Int32.Parse(Button_8_1.Name.Split('_')[2]));
        }
        private void Button_6_2_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_6_2.Name.Split('_')[1]), Int32.Parse(Button_6_2.Name.Split('_')[2]));
        }
        private void Button_6_2_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_6_2.Name.Split('_')[1]), Int32.Parse(Button_6_2.Name.Split('_')[2]));
        }
        private void Button_7_2_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_7_2.Name.Split('_')[1]), Int32.Parse(Button_7_2.Name.Split('_')[2]));
        }
        private void Button_7_2_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_7_2.Name.Split('_')[1]), Int32.Parse(Button_7_2.Name.Split('_')[2]));
        }
        private void Button_8_2_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_8_2.Name.Split('_')[1]), Int32.Parse(Button_8_2.Name.Split('_')[2]));
        }
        private void Button_8_2_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_8_2.Name.Split('_')[1]), Int32.Parse(Button_8_2.Name.Split('_')[2]));
        }
        private void Button_0_3_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_0_3.Name.Split('_')[1]), Int32.Parse(Button_0_3.Name.Split('_')[2]));
        }
        private void Button_0_3_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_0_3.Name.Split('_')[1]), Int32.Parse(Button_0_3.Name.Split('_')[2]));
        }
        private void Button_1_3_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_1_3.Name.Split('_')[1]), Int32.Parse(Button_1_3.Name.Split('_')[2]));
        }
        private void Button_1_3_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_1_3.Name.Split('_')[1]), Int32.Parse(Button_1_3.Name.Split('_')[2]));
        }
        private void Button_0_4_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_0_4.Name.Split('_')[1]), Int32.Parse(Button_0_4.Name.Split('_')[2]));
        }
        private void Button_0_4_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_0_4.Name.Split('_')[1]), Int32.Parse(Button_0_4.Name.Split('_')[2]));
        }
        private void Button_2_3_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_2_3.Name.Split('_')[1]), Int32.Parse(Button_2_3.Name.Split('_')[2]));
        }
        private void Button_2_3_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_2_3.Name.Split('_')[1]), Int32.Parse(Button_2_3.Name.Split('_')[2]));
        }
        private void Button_1_4_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_1_4.Name.Split('_')[1]), Int32.Parse(Button_1_4.Name.Split('_')[2]));
        }
        private void Button_1_4_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_1_4.Name.Split('_')[1]), Int32.Parse(Button_1_4.Name.Split('_')[2]));
        }
        private void Button_2_4_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_2_4.Name.Split('_')[1]), Int32.Parse(Button_2_4.Name.Split('_')[2]));
        }
        private void Button_2_4_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_2_4.Name.Split('_')[1]), Int32.Parse(Button_2_4.Name.Split('_')[2]));
        }
        private void Button_0_5_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_0_5.Name.Split('_')[1]), Int32.Parse(Button_0_5.Name.Split('_')[2]));
        }
        private void Button_0_5_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_0_5.Name.Split('_')[1]), Int32.Parse(Button_0_5.Name.Split('_')[2]));
        }
        private void Button_1_5_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_1_5.Name.Split('_')[1]), Int32.Parse(Button_1_5.Name.Split('_')[2]));
        }
        private void Button_1_5_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_1_5.Name.Split('_')[1]), Int32.Parse(Button_1_5.Name.Split('_')[2]));
        }
        private void Button_2_5_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_2_5.Name.Split('_')[1]), Int32.Parse(Button_2_5.Name.Split('_')[2]));
        }
        private void Button_2_5_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_2_5.Name.Split('_')[1]), Int32.Parse(Button_2_5.Name.Split('_')[2]));
        }
        private void Button_3_3_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_3_3.Name.Split('_')[1]), Int32.Parse(Button_3_3.Name.Split('_')[2]));
        }
        private void Button_3_3_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_3_3.Name.Split('_')[1]), Int32.Parse(Button_3_3.Name.Split('_')[2]));
        }
        private void Button_4_3_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_4_3.Name.Split('_')[1]), Int32.Parse(Button_4_3.Name.Split('_')[2]));
        }
        private void Button_4_3_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_4_3.Name.Split('_')[1]), Int32.Parse(Button_4_3.Name.Split('_')[2]));
        }
        private void Button_3_4_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_3_4.Name.Split('_')[1]), Int32.Parse(Button_3_4.Name.Split('_')[2]));
        }
        private void Button_3_4_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_3_4.Name.Split('_')[1]), Int32.Parse(Button_3_4.Name.Split('_')[2]));
        }
        private void Button_5_3_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_5_3.Name.Split('_')[1]), Int32.Parse(Button_5_3.Name.Split('_')[2]));
        }
        private void Button_5_3_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_5_3.Name.Split('_')[1]), Int32.Parse(Button_5_3.Name.Split('_')[2]));
        }
        private void Button_4_4_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_4_4.Name.Split('_')[1]), Int32.Parse(Button_4_4.Name.Split('_')[2]));
        }
        private void Button_4_4_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_4_4.Name.Split('_')[1]), Int32.Parse(Button_4_4.Name.Split('_')[2]));
        }
        private void Button_5_4_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_5_4.Name.Split('_')[1]), Int32.Parse(Button_5_4.Name.Split('_')[2]));
        }
        private void Button_5_4_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_5_4.Name.Split('_')[1]), Int32.Parse(Button_5_4.Name.Split('_')[2]));
        }
        private void Button_3_5_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_3_5.Name.Split('_')[1]), Int32.Parse(Button_3_5.Name.Split('_')[2]));
        }
        private void Button_3_5_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_3_5.Name.Split('_')[1]), Int32.Parse(Button_3_5.Name.Split('_')[2]));
        }
        private void Button_4_5_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_4_5.Name.Split('_')[1]), Int32.Parse(Button_4_5.Name.Split('_')[2]));
        }
        private void Button_4_5_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_4_5.Name.Split('_')[1]), Int32.Parse(Button_4_5.Name.Split('_')[2]));
        }
        private void Button_5_5_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_5_5.Name.Split('_')[1]), Int32.Parse(Button_5_5.Name.Split('_')[2]));
        }
        private void Button_5_5_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_5_5.Name.Split('_')[1]), Int32.Parse(Button_5_5.Name.Split('_')[2]));
        }
        private void Button_6_3_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_6_3.Name.Split('_')[1]), Int32.Parse(Button_6_3.Name.Split('_')[2]));
        }
        private void Button_6_3_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_6_3.Name.Split('_')[1]), Int32.Parse(Button_6_3.Name.Split('_')[2]));
        }
        private void Button_7_3_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_7_3.Name.Split('_')[1]), Int32.Parse(Button_7_3.Name.Split('_')[2]));
        }
        private void Button_7_3_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_7_3.Name.Split('_')[1]), Int32.Parse(Button_7_3.Name.Split('_')[2]));
        }
        private void Button_6_4_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_6_4.Name.Split('_')[1]), Int32.Parse(Button_6_4.Name.Split('_')[2]));
        }
        private void Button_6_4_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_6_4.Name.Split('_')[1]), Int32.Parse(Button_6_4.Name.Split('_')[2]));
        }
        private void Button_8_3_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_8_3.Name.Split('_')[1]), Int32.Parse(Button_8_3.Name.Split('_')[2]));
        }
        private void Button_8_3_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_8_3.Name.Split('_')[1]), Int32.Parse(Button_8_3.Name.Split('_')[2]));
        }
        private void Button_7_4_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_7_4.Name.Split('_')[1]), Int32.Parse(Button_7_4.Name.Split('_')[2]));
        }
        private void Button_7_4_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_7_4.Name.Split('_')[1]), Int32.Parse(Button_7_4.Name.Split('_')[2]));
        }
        private void Button_8_4_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_8_4.Name.Split('_')[1]), Int32.Parse(Button_8_4.Name.Split('_')[2]));
        }
        private void Button_8_4_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_8_4.Name.Split('_')[1]), Int32.Parse(Button_8_4.Name.Split('_')[2]));
        }
        private void Button_6_5_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_6_5.Name.Split('_')[1]), Int32.Parse(Button_6_5.Name.Split('_')[2]));
        }
        private void Button_6_5_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_6_5.Name.Split('_')[1]), Int32.Parse(Button_6_5.Name.Split('_')[2]));
        }
        private void Button_7_5_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_7_5.Name.Split('_')[1]), Int32.Parse(Button_7_5.Name.Split('_')[2]));
        }
        private void Button_7_5_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_7_5.Name.Split('_')[1]), Int32.Parse(Button_7_5.Name.Split('_')[2]));
        }
        private void Button_8_5_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_8_5.Name.Split('_')[1]), Int32.Parse(Button_8_5.Name.Split('_')[2]));
        }
        private void Button_8_5_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_8_5.Name.Split('_')[1]), Int32.Parse(Button_8_5.Name.Split('_')[2]));
        }
        private void Button_0_6_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_0_6.Name.Split('_')[1]), Int32.Parse(Button_0_6.Name.Split('_')[2]));
        }
        private void Button_0_6_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_0_6.Name.Split('_')[1]), Int32.Parse(Button_0_6.Name.Split('_')[2]));
        }
        private void Button_1_6_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_1_6.Name.Split('_')[1]), Int32.Parse(Button_1_6.Name.Split('_')[2]));
        }
        private void Button_1_6_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_1_6.Name.Split('_')[1]), Int32.Parse(Button_1_6.Name.Split('_')[2]));
        }
        private void Button_0_7_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_0_7.Name.Split('_')[1]), Int32.Parse(Button_0_7.Name.Split('_')[2]));
        }
        private void Button_0_7_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_0_7.Name.Split('_')[1]), Int32.Parse(Button_0_7.Name.Split('_')[2]));
        }
        private void Button_2_6_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_2_6.Name.Split('_')[1]), Int32.Parse(Button_2_6.Name.Split('_')[2]));
        }
        private void Button_2_6_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_2_6.Name.Split('_')[1]), Int32.Parse(Button_2_6.Name.Split('_')[2]));
        }
        private void Button_1_7_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_1_7.Name.Split('_')[1]), Int32.Parse(Button_1_7.Name.Split('_')[2]));
        }
        private void Button_1_7_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_1_7.Name.Split('_')[1]), Int32.Parse(Button_1_7.Name.Split('_')[2]));
        }
        private void Button_2_7_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_2_7.Name.Split('_')[1]), Int32.Parse(Button_2_7.Name.Split('_')[2]));
        }
        private void Button_2_7_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_2_7.Name.Split('_')[1]), Int32.Parse(Button_2_7.Name.Split('_')[2]));
        }
        private void Button_0_8_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_0_8.Name.Split('_')[1]), Int32.Parse(Button_0_8.Name.Split('_')[2]));
        }
        private void Button_0_8_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_0_8.Name.Split('_')[1]), Int32.Parse(Button_0_8.Name.Split('_')[2]));
        }
        private void Button_1_8_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_1_8.Name.Split('_')[1]), Int32.Parse(Button_1_8.Name.Split('_')[2]));
        }
        private void Button_1_8_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_1_8.Name.Split('_')[1]), Int32.Parse(Button_1_8.Name.Split('_')[2]));
        }
        private void Button_2_8_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_2_8.Name.Split('_')[1]), Int32.Parse(Button_2_8.Name.Split('_')[2]));
        }
        private void Button_2_8_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_2_8.Name.Split('_')[1]), Int32.Parse(Button_2_8.Name.Split('_')[2]));
        }
        private void Button_3_6_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_3_6.Name.Split('_')[1]), Int32.Parse(Button_3_6.Name.Split('_')[2]));
        }
        private void Button_3_6_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_3_6.Name.Split('_')[1]), Int32.Parse(Button_3_6.Name.Split('_')[2]));
        }
        private void Button_4_6_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_4_6.Name.Split('_')[1]), Int32.Parse(Button_4_6.Name.Split('_')[2]));
        }
        private void Button_4_6_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_4_6.Name.Split('_')[1]), Int32.Parse(Button_4_6.Name.Split('_')[2]));
        }
        private void Button_3_7_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_3_7.Name.Split('_')[1]), Int32.Parse(Button_3_7.Name.Split('_')[2]));
        }
        private void Button_3_7_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_3_7.Name.Split('_')[1]), Int32.Parse(Button_3_7.Name.Split('_')[2]));
        }
        private void Button_5_6_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_5_6.Name.Split('_')[1]), Int32.Parse(Button_5_6.Name.Split('_')[2]));
        }
        private void Button_5_6_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_5_6.Name.Split('_')[1]), Int32.Parse(Button_5_6.Name.Split('_')[2]));
        }
        private void Button_4_7_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_4_7.Name.Split('_')[1]), Int32.Parse(Button_4_7.Name.Split('_')[2]));
        }
        private void Button_4_7_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_4_7.Name.Split('_')[1]), Int32.Parse(Button_4_7.Name.Split('_')[2]));
        }
        private void Button_5_7_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_5_7.Name.Split('_')[1]), Int32.Parse(Button_5_7.Name.Split('_')[2]));
        }
        private void Button_5_7_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_5_7.Name.Split('_')[1]), Int32.Parse(Button_5_7.Name.Split('_')[2]));
        }
        private void Button_3_8_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_3_8.Name.Split('_')[1]), Int32.Parse(Button_3_8.Name.Split('_')[2]));
        }
        private void Button_3_8_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_3_8.Name.Split('_')[1]), Int32.Parse(Button_3_8.Name.Split('_')[2]));
        }
        private void Button_4_8_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_4_8.Name.Split('_')[1]), Int32.Parse(Button_4_8.Name.Split('_')[2]));
        }
        private void Button_4_8_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_4_8.Name.Split('_')[1]), Int32.Parse(Button_4_8.Name.Split('_')[2]));
        }
        private void Button_5_8_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_5_8.Name.Split('_')[1]), Int32.Parse(Button_5_8.Name.Split('_')[2]));
        }
        private void Button_5_8_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_5_8.Name.Split('_')[1]), Int32.Parse(Button_5_8.Name.Split('_')[2]));
        }
        private void Button_6_6_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_6_6.Name.Split('_')[1]), Int32.Parse(Button_6_6.Name.Split('_')[2]));
        }
        private void Button_6_6_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_6_6.Name.Split('_')[1]), Int32.Parse(Button_6_6.Name.Split('_')[2]));
        }
        private void Button_7_6_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_7_6.Name.Split('_')[1]), Int32.Parse(Button_7_6.Name.Split('_')[2]));
        }
        private void Button_7_6_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_7_6.Name.Split('_')[1]), Int32.Parse(Button_7_6.Name.Split('_')[2]));
        }
        private void Button_6_7_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_6_7.Name.Split('_')[1]), Int32.Parse(Button_6_7.Name.Split('_')[2]));
        }
        private void Button_6_7_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_6_7.Name.Split('_')[1]), Int32.Parse(Button_6_7.Name.Split('_')[2]));
        }
        private void Button_8_6_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_8_6.Name.Split('_')[1]), Int32.Parse(Button_8_6.Name.Split('_')[2]));
        }
        private void Button_8_6_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_8_6.Name.Split('_')[1]), Int32.Parse(Button_8_6.Name.Split('_')[2]));
        }
        private void Button_7_7_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_7_7.Name.Split('_')[1]), Int32.Parse(Button_7_7.Name.Split('_')[2]));
        }
        private void Button_7_7_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_7_7.Name.Split('_')[1]), Int32.Parse(Button_7_7.Name.Split('_')[2]));
        }
        private void Button_8_7_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_8_7.Name.Split('_')[1]), Int32.Parse(Button_8_7.Name.Split('_')[2]));
        }
        private void Button_8_7_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_8_7.Name.Split('_')[1]), Int32.Parse(Button_8_7.Name.Split('_')[2]));
        }
        private void Button_6_8_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_6_8.Name.Split('_')[1]), Int32.Parse(Button_6_8.Name.Split('_')[2]));
        }
        private void Button_6_8_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_6_8.Name.Split('_')[1]), Int32.Parse(Button_6_8.Name.Split('_')[2]));
        }
        private void Button_7_8_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_7_8.Name.Split('_')[1]), Int32.Parse(Button_7_8.Name.Split('_')[2]));
        }
        private void Button_7_8_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_7_8.Name.Split('_')[1]), Int32.Parse(Button_7_8.Name.Split('_')[2]));
        }
        private void Button_8_8_MouseMove(object sender, MouseEventArgs e)
        {
            Paint(Int32.Parse(Button_8_8.Name.Split('_')[1]), Int32.Parse(Button_8_8.Name.Split('_')[2]));
        }
        private void Button_8_8_MouseLeave(object sender, MouseEventArgs e)
        {
            PaintInitial(Int32.Parse(Button_8_8.Name.Split('_')[1]), Int32.Parse(Button_8_8.Name.Split('_')[2]));
        }
        //NewGame

        private int hours = 0;
        private int minutes = 0;
        private int sekends = 0;

        //private Game Game = new Game();

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            if ((string)NewGame.Content == "New Game")
            {
                NewGame.Content = "End Game";
                Curtain.Visibility = Visibility.Hidden;
                TimeSekends();

                // Engine.StartGame
                //Game.StartGame();
            }
            else
            {
                Curtain.Visibility = Visibility.Visible;
                Text.Visibility = Visibility.Visible;
                Information.Visibility = Visibility.Visible;
                YourTime.Visibility = Visibility.Visible;
                Information.Content = "Tu informacja";
                YourTime.Content = $"{hours:D2}" + " : " + $"{minutes:D2}" + " : " + $"{sekends:D2}";
                NewGame.Visibility = Visibility.Hidden;

                // Engine.EndGame
                //Game.StartGame();
            }
        }

        //Timer

        private async void TimeSekends()
        {
            while (sekends < 59)
            {
                await Task.Delay(1000);
                sekends++;
                Sekends.Content = $"{sekends:D2}";
            }
            sekends = 0;
            TimeMinutes();
        }
        private void TimeMinutes()
        {
            minutes++;
            Minutes.Content = $"{minutes:D2}";
            TimeSekends();
        }

        private void TimeHours()
        {
            hours++;
            Hours.Content = $"{hours:D2}";
            TimeSekends();
        }
    }
}
