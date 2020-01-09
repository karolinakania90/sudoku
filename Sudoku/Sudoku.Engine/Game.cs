using SudokuSharp;
using System;
using System.Linq;

namespace Sudoku.Engine
{
    public class Game
    {
        private Board board;

        public Game()
        {
            board = Factory.Puzzle(0, 4, 30, 40);
        }


        /// <summary>
        /// Create game based on selected Game Level
        /// </summary>
        /// <param name="gameLevel"></param>
        public Game(GameLevel gameLevel)
        {
            switch (gameLevel)
            {
                case GameLevel.Easy:
                    board = Factory.Puzzle(0, 4, 30, 40);
                    break;
                case GameLevel.Medium:
                    board = Factory.Puzzle(0, 4, 60, 80);
                    break;
                case GameLevel.Hard:
                    board = Factory.Puzzle(7, 4, 80, 80);
                    break;
            }
        }

        /// <summary>
        /// Gets value of populated field
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int GetFieldValue(int x, int y)
        {
            var itemValue = board.GetCell(new Location(x, y));
            return itemValue;
        }

        /// <summary>
        /// Determinates if Sudoku game is solved
        /// </summary>
        /// <returns></returns>
        public bool IsSudokuSolved()
        {
            return board.ExistsUniqueSolution();
        }

        /// <summary>
        /// Set another item value on Sudoku board
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        public void SetField(string x, string y, int value)
        {
            board.PutCell(new Location(Int32.Parse(x), Int32.Parse(y)), value);
        }


        /// <summary>
        /// Returns information if Sudoku game is valid
        /// </summary>
        /// <returns></returns>
        public bool ValidateGame()
        {
            return board.IsValid;
        }


        /// <summary>
        /// Returns current game board with currently filled values
        /// </summary>
        /// <returns></returns>
        public int[,] CurrentGameBoard()
        {
            int[,] gameBoard = new int[9, 9];

            var boardString = board.ToString().Replace(" ", "").ToArray().Where(c => c != '\n').ToList();

            int row = 0;
            int column = 0;

            for (var i = 0; i < boardString.Count; i++)
            {
                if (i != 0 && i % 9 == 0)
                {
                    row++;
                    column = 0;
                }

                if (boardString[i] == '-')
                {
                    boardString[i] = '0';
                }

                gameBoard[row, column] = Int32.Parse(boardString[i].ToString());
                column++;

            }

            return gameBoard;
        }

        /// <summary>
        /// Returns current game board with currently filled values (string)
        /// </summary>
        /// <returns></returns>
        public string CurrentGameBoardString()
        {
            return this.board.ToString();
        }


        /// <summary>
        /// Check if changed value for item does not break Sudoku.
        /// Validates all in row, column and square.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public SelectedItemState ValidateCurrentItem(int x, int y)
        {
            // to be changed
            var state =  new SelectedItemState();
            state.IsRowOk = true;
            state.IsColumnOk = false;
            
            return state;
        }
    }
}
