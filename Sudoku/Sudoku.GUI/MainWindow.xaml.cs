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
        Button[,] tableButtons;
        Border[,] tableBorders;
        int[,] Sudoku;

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

            //---------------------

            //Sudoku = new int[9, 9];
            //Sudoku[0, 0] = 1;
            //Sudoku[0, 1] = 2;
            //Sudoku[0, 2] = 6;
            //Sudoku[0, 3] = 9;
            //Sudoku[0, 4] = 4;
            //Sudoku[0, 5] = 5;
            //Sudoku[0, 6] = 8;
            //Sudoku[0, 7] = 7;
            //Sudoku[0, 8] = 3;
            //Sudoku[1, 0] = 8;
            //Sudoku[1, 1] = 5;
            //Sudoku[1, 2] = 9;
            //Sudoku[1, 3] = 7;
            //Sudoku[1, 4] = 6;
            //Sudoku[1, 5] = 3;
            //Sudoku[1, 6] = 4;
            //Sudoku[1, 7] = 2;
            //Sudoku[1, 8] = 1;
            //Sudoku[2, 0] = 7;
            //Sudoku[2, 1] = 4;
            //Sudoku[2, 2] = 3;
            //Sudoku[2, 3] = 1;
            //Sudoku[2, 4] = 8;
            //Sudoku[2, 5] = 2;
            //Sudoku[2, 6] = 5;
            //Sudoku[2, 7] = 6;
            //Sudoku[2, 8] = 9;
            //Sudoku[3, 0] = 6;
            //Sudoku[3, 1] = 7;
            //Sudoku[3, 2] = 8;
            //Sudoku[3, 3] = 5;
            //Sudoku[3, 4] = 1;
            //Sudoku[3, 5] = 9;
            //Sudoku[3, 6] = 2;
            //Sudoku[3, 7] = 3;
            //Sudoku[3, 8] = 4;
            //Sudoku[4, 0] = 3;
            //Sudoku[4, 1] = 9;
            //Sudoku[4, 2] = 4;
            //Sudoku[4, 3] = 2;
            //Sudoku[4, 4] = 7;
            //Sudoku[4, 5] = 8;
            //Sudoku[4, 6] = 6;
            //Sudoku[4, 7] = 1;
            //Sudoku[4, 8] = 5;
            //Sudoku[5, 0] = 2;
            //Sudoku[5, 1] = 1;
            //Sudoku[5, 2] = 5;
            //Sudoku[5, 3] = 6;
            //Sudoku[5, 4] = 3;
            //Sudoku[5, 5] = 4;
            //Sudoku[5, 6] = 7;
            //Sudoku[5, 7] = 9;
            //Sudoku[5, 8] = 8;
            //Sudoku[6, 0] = 9;
            //Sudoku[6, 1] = 6;
            //Sudoku[6, 2] = 2;
            //Sudoku[6, 3] = 8;
            //Sudoku[6, 4] = 5;
            //Sudoku[6, 5] = 1;
            //Sudoku[6, 6] = 3;
            //Sudoku[6, 7] = 4;
            //Sudoku[6, 8] = 7;
            //Sudoku[7, 0] = 5;
            //Sudoku[7, 1] = 3;
            //Sudoku[7, 2] = 1;
            //Sudoku[7, 3] = 4;
            //Sudoku[7, 4] = 2;
            //Sudoku[7, 5] = 7;
            //Sudoku[7, 6] = 9;
            //Sudoku[7, 7] = 8;
            //Sudoku[7, 8] = 6;
            //Sudoku[8, 0] = 4;
            //Sudoku[8, 1] = 8;
            //Sudoku[8, 2] = 7;
            //Sudoku[8, 3] = 3;
            //Sudoku[8, 4] = 9;
            //Sudoku[8, 5] = 6;
            //Sudoku[8, 6] = 1;
            //Sudoku[8, 7] = 5;
            //Sudoku[8, 8] = 2;
        }

        // Loading values


        private void StartGame_Board()
        {
            Sudoku = Game.CurrentGameBoard();
            for (int x = 0; x < tableButtons.Length - 72; x++)
            {
                for (int y = 0; y < tableButtons.Length - 72; y++)
                {
                    tableButtons[y, x].Content = Sudoku[x, y].ToString();
                    tableButtons[y, x].BorderBrush = Brushes.Blue;
                }
            }
            for (int x = 0; x < tableButtons.Length - 72; x++)
            {
                for (int i = 0; i < 5; i++)
                {
                    RandomY[i] = 0;
                }
                Random_Y_Posicion();
                for (int y = 0; y < 5; y++)
                {
                    tableButtons[RandomY[y], x].Content = "";
                    tableButtons[RandomY[y], x].BorderBrush = Brushes.Gray;
                }
            }
        }

        int[] RandomY = new int[5];
        bool the_value_is = true;

        private void Random_Y_Posicion()
        {
            int counter = 0;
            while (RandomY[4] == 0)
            {
                int randomY = new Random().Next(0, 9);
                for (int i = 0; i < 5; i++)
                {
                    if (randomY == RandomY[i])
                    {
                        the_value_is = false;
                    }
                }
                if (the_value_is == true)
                {
                    RandomY[counter] = randomY;
                    counter++;
                }
                the_value_is = true;
            }
        }

        // Increase_in_value_button

        public int Plus(int Value)
        {
            Value++;
            if (Value > 9)
            {
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

        private void Increase_in_value(object sender, RoutedEventArgs e)
        {
            Button ButtonClick = sender as Button;
            if (!(ButtonClick.BorderBrush == Brushes.Blue))
            {
                int number = Int32.Parse(CheckString(ButtonClick.Content.ToString()));
                ButtonClick.Content = Plus(number).ToString();

                // Check Value
                Check_Value_Buttons_of_Click(Int32.Parse(ButtonClick.Name.Split('_')[1]), Int32.Parse(ButtonClick.Name.Split('_')[2]), ButtonClick);
            }
        }

        // Check Value Buttons of Click

        public void Paint_for_click(int Column, int Poem)
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
                        tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                    }
                }
            }
            for (int x = PositionX(Poem); x < (PositionX(Poem) + 3); x++)
            {
                for (int y = PositionY(Column); y < (PositionY(Column) + 3); y++)
                {
                    tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                }
            }
        }

        bool can;

        public void Check_Value_Buttons_of_Click(int Column, int Poem, Button Value)
        {
            can = true;

            //Button_0_0 -> Button_[kolumna]_[wiersz]
            // y -> kolumna
            // x -> wiersz
            Paint_for_click(Int32.Parse(Value.Name.Split('_')[1]), Int32.Parse(Value.Name.Split('_')[2]));

            for (int x = 0; x < tableButtons.Length - 72; x++)
            {
                for (int y = 0; y < tableButtons.Length - 72; y++)
                {
                    if (y == Column || x == Poem)
                    {
                        if (Value.Content.ToString() == tableButtons[y, x].Content.ToString() && Value != tableButtons[y, x])
                        {
                            tableBorders[PositionY(Column), PositionX(Poem)].Visibility = Visibility.Visible;
                            tableBorders[PositionY(Column), PositionX(Poem)].BorderBrush = Brushes.Red;
                            tableButtons[y, x].Background = Brushes.Red;
                            can = false;
                        }
                        else
                        {
                            if (can == true)
                            {
                                tableBorders[PositionY(Column), PositionX(Poem)].Visibility = Visibility.Visible;
                                tableBorders[PositionY(Column), PositionX(Poem)].BorderBrush = Brushes.Green;
                            }
                        }
                    }
                }
            }
            for (int x = PositionX(Poem); x < (PositionX(Poem) + 3); x++)
            {
                for (int y = PositionY(Column); y < (PositionY(Column) + 3); y++)
                {
                    if (Value.Content.ToString() == tableButtons[y, x].Content.ToString() && Value != tableButtons[y, x])
                    {
                        tableBorders[PositionY(Column), PositionX(Poem)].Visibility = Visibility.Visible;
                        tableBorders[PositionY(Column), PositionX(Poem)].BorderBrush = Brushes.Red;
                        tableButtons[y, x].Background = Brushes.Red;
                        can = false;
                    }
                    else
                    {
                        if (can == true)
                        {
                            tableBorders[PositionY(Column), PositionX(Poem)].Visibility = Visibility.Visible;
                            tableBorders[PositionY(Column), PositionX(Poem)].BorderBrush = Brushes.Green;
                        }
                    }
                }
            }
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
                        tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                    }
                }
            }
            for (int x = PositionX(Poem); x < (PositionX(Poem) + 3); x++)
            {
                for (int y = PositionY(Column); y < (PositionY(Column) + 3); y++)
                {
                    tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(255, 253, 178));
                }
            }
        }

        public void PaintDefault(int Column, int Poem)
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
                        tableButtons[y, x].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
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
            if (Column > -1 && Column < 3)
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

        private void Change_background_color_MouseMove(object sender, MouseEventArgs e)
        {
            Button ButtonClick = sender as Button;
            Paint(Int32.Parse(ButtonClick.Name.Split('_')[1]), Int32.Parse(ButtonClick.Name.Split('_')[2]));
        }

        private void Change_background_color_MouseLeave(object sender, MouseEventArgs e)
        {
            Button ButtonClick = sender as Button;
            PaintDefault(Int32.Parse(ButtonClick.Name.Split('_')[1]), Int32.Parse(ButtonClick.Name.Split('_')[2]));
        }

        //NewGame

        private int hours = 0;
        private int minutes = 0;
        private int sekends = 0;

        DispatcherTimer timer;

        private Game Game;

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            if ((string)NewGame.Content == "New Game")
            {
                NewGame.Content = "End Game";
                StartGame.IsEnabled = true;

                Game = new Game(GameLevel.Hard);
                // Engine.StartGame
                //Game.StartGame();
                StartGame_Board();
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
                StartGame.Visibility = Visibility.Hidden;

                // Engine.EndGame
                Game.EndGame();

                //Timer start
                timer.Stop();
            }
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            if ((string)StartGame.Content == "Start")
            {
                StartGame.Content = "Pauza";
                Curtain.Visibility = Visibility.Hidden;
                Information.Visibility = Visibility.Hidden;
                Information.Content = "";

                //Timer start
                Start();
            }
            else
            {
                StartGame.Content = "Start";
                Curtain.Visibility = Visibility.Visible;
                Information.Visibility = Visibility.Visible;
                Information.Content = "Przerwa w grze";

                //Timer Stop
                timer.Stop();
            }
        }

        //Timer
        private void Start()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimeSekends;
            timer.Start();
        }
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
