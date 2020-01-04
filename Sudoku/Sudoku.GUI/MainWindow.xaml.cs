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
using System.Windows.Threading;

namespace Sudoku.GUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] tableButtons;
        private Border[,] tableBorders;
        private int[,] sudoku;
        private int hours = 0;
        private int minutes = 0;
        private int sekends = 0;
        private DispatcherTimer timer;
        private Game game;
        private string level;

        public MainWindow()
        {
            InitializeComponent();


            //---------------------

            tableBorders = new Border[9, 9];
            tableBorders[0, 0] = Border_0_0;
            tableBorders[3, 0] = Border_3_0;
            tableBorders[6, 0] = Border_6_0;
            tableBorders[0, 3] = Border_0_3;
            tableBorders[3, 3] = Border_3_3;
            tableBorders[6, 3] = Border_6_3;
            tableBorders[0, 6] = Border_0_6;
            tableBorders[3, 6] = Border_3_6;
            tableBorders[6, 6] = Border_6_6;

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

            //-----------------------
            
            Collapsed_Buttons();
        }

        /// <summary>
        /// StartGame
        /// </summary
        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            if ((string)StartGame.Content == "Start")
            {
                StartGame.Content = "Pauza";
                Show_Buttons();
                Text.Visibility = Visibility.Collapsed;
                Information.Visibility = Visibility.Collapsed;
                YourTime.Visibility = Visibility.Collapsed;

                level = Level.Text;

                switch (level)
                {
                    case "Easy":
                        game = new Game(GameLevel.Easy);
                        break;
                    case "Medium":
                        game = new Game(GameLevel.Medium);
                        break;
                    case "Hard":
                        game = new Game(GameLevel.Hard);
                        break;
                }

                Level.IsEnabled = false;

                Loading_Board_Start();

                //Timer start
                Start();
            }
            else
            {
                StartGame.Content = "Start";
                Text.Visibility = Visibility.Visible;
                Information.Visibility = Visibility.Visible;
                YourTime.Visibility = Visibility.Visible;
                Information.Content = "Pauza";
                YourTime.Content = $"{hours:D2}" + " : " + $"{minutes:D2}" + " : " + $"{sekends:D2}";

                Collapsed_Buttons();

                //Timer start
                timer.Stop();
            }
        }

        /// <summary>
        /// Increase in value button
        /// </summary>
        private void Increase_In_Value(object sender, RoutedEventArgs e)
        {
            Button button_click = sender as Button;

            if (!(button_click.BorderBrush == Brushes.Blue))
            {
                int number = Int32.Parse(CheckString(button_click.Content.ToString()));
                button_click.Content = Plus(number).ToString();

                // Check Value
                //Check_Value_Buttons_Of_Click(Int32.Parse(button_click.Name.Split('_')[1]), Int32.Parse(button_click.Name.Split('_')[2]), button_click);
            }

        }

        /*private void Paint_For_Click(int column, int row)
        {
            //Button_0_0 -> Button_[kolumna]_[wiersz]
            // y -> kolumna
            // x -> wiersz

            for (int x = 0; x < (tableButtons.Length / 9); x++)
            {
                for (int y = 0; y < (tableButtons.Length / 9); y++)
                {
                    if (y == column || x == row)
                    {
                        tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                    }
                }
            }

            for (int x = PositionX(row); x < (PositionX(row) + 3); x++)
            {
                for (int y = PositionY(column); y < (PositionY(column) + 3); y++)
                {
                    tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                }
            }

        }*/

        /// <summary>
        /// Check Value Buttons of Click
        /// </summary>
        /*private void Check_Value_Buttons_Of_Click(int column, int row, Button value)
        {

            //Button_0_0 -> Button_[kolumna]_[wiersz]
            // y -> kolumna
            // x -> wiersz

            //Paint_for_click(Int32.Parse(Value.Name.Split('_')[1]), Int32.Parse(Value.Name.Split('_')[2]));
        }*/

        /// <summary>
        /// Change BackGroud Buttons For Muve Mouse
        /// </summary>
        private void Change_Background_Color_MouseMove(object sender, MouseEventArgs e)
        {
            Button button_click = sender as Button;
            Paint(Int32.Parse(button_click.Name.Split('_')[1]), Int32.Parse(button_click.Name.Split('_')[2]));
        }

        /// <summary>
        /// Change BackGroud Buttons For Leave Mouse
        /// </summary>
        private void Change_Background_Color_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button_click = sender as Button;
            PaintDefault(Int32.Parse(button_click.Name.Split('_')[1]), Int32.Parse(button_click.Name.Split('_')[2]));
        }

        /// <summary>
        /// Loading values
        /// </summary>
        private void Loading_Board_Start()
        {
            sudoku = game.CurrentGameBoard();

            for (int x = 0; x < (tableButtons.Length / 9 ); x++)
            {
                for (int y = 0; y < (tableButtons.Length / 9); y++)
                {
                    if(sudoku[x, y] > 0)
                    {
                        tableButtons[y, x].Content = sudoku[x, y].ToString();
                        tableButtons[y, x].BorderBrush = Brushes.Blue;
                    }
                }
            }

        }
        
        /// <summary>
        /// Increase in value button
        /// </summary>
        private int Plus(int value)
        {
            value++;
            if (value > 9)
            {
                value = 1;
            }
            return value;
        }

        /// <summary>
        /// Check button has a value
        /// </summary>
        private string CheckString(string value)
        {
            if (value == "")
            {
                value = "0";
                return value;
            }
            return value;
        }
        
        /// <summary>
        /// Paint squares
        /// </summary>
        private void Paint(int column, int row)
        {
            //Button_0_0 -> Button_[kolumna]_[wiersz]
            // y -> kolumna
            // x -> wiersz

            for (int x = 0; x < (tableButtons.Length / 9); x++)
            {
                for (int y = 0; y < (tableButtons.Length / 9); y++)
                {
                    if (y == column || x == row)
                    {
                        tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                    }
                }
            }

            for (int x = PositionX(row); x < (PositionX(row) + 3); x++)
            {
                for (int y = PositionY(column); y < (PositionY(column) + 3); y++)
                {
                    tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                }
            }

        }

        /// <summary>
        /// Paint squares for default color
        /// </summary>
        private void PaintDefault(int column, int row)
        {
            //Button_0_0 -> Button_[kolumna]_[wiersz]
            // y -> kolumna
            // x -> wiersz

            for (int x = 0; x < (tableButtons.Length / 9); x++)
            {
                for (int y = 0; y < (tableButtons.Length / 9); y++)
                {
                    if (y == column || x == row)
                    {
                        tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                    }
                }
            }

            for (int x = PositionX(row); x < (PositionX(row) + 3); x++)
            {
                for (int y = PositionY(column); y < (PositionY(column) + 3); y++)
                {
                    tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                }
            }

        }

        /// <summary>
        /// Chose positionY big squares
        /// </summary>
        private int PositionY(int column)
        {
            int y = 0;

            if (column > -1 && column < 3)
            {
                y = 0;
            }

            if (column > 2 && column < 6)
            {
                y = 3;
            }

            if (column > 5 && column < 9)
            {
                y = 6;
            }

            return y;
        }

        /// <summary>
        /// Chose positionX big squares
        /// </summary>
        private int PositionX(int row)
        {
            int x = 0;

            if (row > -1 && row < 3)
            {
                x = 0;
            }

            if (row > 2 && row < 6)
            {
                x = 3;
            }

            if (row > 5 && row < 9)
            {
                x = 6;
            }

            return x;
        }

        /// <summary>
        /// Show buttons for Window
        /// </summary>
        private void Show_Buttons()
        {
            //Button_0_0 -> Button_[kolumna]_[wiersz]
            // y -> kolumna
            // x -> wiersz

            for (int x = 0; x < (tableButtons.Length / 9); x++)
            {
                for (int y = 0; y < (tableButtons.Length / 9); y++)
                {
                    tableButtons[y, x].Visibility = Visibility.Visible;
                }
            }
        }

        /// <summary>
        /// Collapsed buttons for Window
        /// </summary>
        private void Collapsed_Buttons()
        {
            //Button_0_0 -> Button_[kolumna]_[wiersz]
            // y -> kolumna
            // x -> wiersz

            for (int x = 0; x < (tableButtons.Length / 9); x++)
            {
                for (int y = 0; y < (tableButtons.Length / 9); y++)
                {
                    tableButtons[y, x].Visibility = Visibility.Collapsed;
                }
            }
        }

        /// <summary>
        /// Start Timer
        /// </summary>
        private void Start()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimeSekends;
            timer.Start();
        }

        /// <summary>
        /// Change value timer
        /// </summary>
        private void TimeSekends(object sender, EventArgs e)
        {
            if (sekends < 59)
            {
                sekends++;
                Seconds.Content = $"{sekends:D2}";
            }
            else
            {
                if (minutes < 59)
                {
                    sekends = 0;
                    Seconds.Content = $"{sekends:D2}";
                    minutes++;
                    Minutes.Content = $"{minutes:D2}";
                }
                else
                {
                    sekends = 0;
                    Seconds.Content = $"{sekends:D2}";
                    minutes = 0;
                    Minutes.Content = $"{minutes:D2}";
                    hours++;
                    Hours.Content = $"{hours:D2}";
                }
            }
        }
    }
}
