using SudokuSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Engine
{
    public class Game
    {
        private Board board;
        private History BoardHistory;

        public Game()
        {
            board = Factory.Puzzle(0, 4, 30, 40);
            BoardHistory = new History();
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
                    board = Factory.Puzzle(2, 34, 0, 0);
                    break;
            }

            BoardHistory = new History();
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
        /// Check if sudoku value is set != 0
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool ValueIsSet(int x, int y)
        {
            var itemValue = board.GetCell(new Location(x, y));
            return itemValue != 0;
        }

        /// <summary>
        /// Determinates if Sudoku game is solved
        /// </summary>
        /// <returns></returns>
        public bool IsSudokuSolved()
        {
            return board.IsSolved;
        }

        /// <summary>
        /// Set another item value on Sudoku board
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        public void SetField(int y, int x, int value)
        {
            board.PutCell(new Location(y, x), value);
            BoardHistory.AddItem(y, x, value);
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

            // remove new lines and spaces
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
        /// returns history of inputs;
        /// </summary>
        /// <returns></returns>
        public List<HistoryItem> GetHistoryItems()
        {
            return BoardHistory.Items;
        }

        /// <summary>
        /// Check if changed value for item does not break Sudoku.
        /// Validates all in row, column and square.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public SudokuState ValidateCurrentItem(int x, int y)
        {
            var state = new SudokuState();

            CheckRow(x, state);
            CheckColumn(y, state);
            return state;
        }


        /// <summary>
        /// Check for duplicates in column
        /// </summary>
        /// <param name="y"></param>
        /// <param name="state"></param>
        private void CheckColumn(int y, SudokuState state)
        {
            var filledRow = board.Find.FilledLocations().Where(c => c.Column == y);

            var columns = new Dictionary<Location, int>();

            foreach (var column in filledRow)
            {
                columns[column] = board.GetCell(column.Index);
            }

            foreach (var column in columns)
            {
                var duplicates = columns.Where(c => c.Value == column.Value);
                if (duplicates.Count() > 1)
                {
                    foreach (var duplicate in duplicates)
                    {
                        state.Duplicates.Add(new int[2] { duplicate.Key.Row, duplicate.Key.Column });
                    }
                }
            }
        }

        /// <summary>
        /// Check for duplicates in row
        /// </summary>
        /// <param name="x"></param>
        /// <param name="state"></param>
        public void CheckRow(int x, SudokuState state)
        {
            var filledRow = board.Find.FilledLocations().Where(c => c.Row == x);

            var rowValues = new Dictionary<Location, int>();

            foreach (var row in filledRow)
            {
                rowValues[row] = board.GetCell(row.Index);
            }

            foreach (var row in rowValues)
            {
                var duplicates = rowValues.Where(c => c.Value == row.Value);
                if (duplicates.Count() > 1)
                {
                    foreach (var duplicate in duplicates)
                    {
                        state.Duplicates.Add(new int[2] { duplicate.Key.Row, duplicate.Key.Column });
                    }
                }
            }
        }
    }
}
