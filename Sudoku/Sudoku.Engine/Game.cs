using SudokuSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Engine
{
    public class Game
    {
        private Board board;

        public Game()
        {
            board = Factory.Puzzle(0, 4, 30, 40);
        }

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

        public bool EndGame()
        {
            return board.ExistsUniqueSolution();
        }

        public void SetField(string x, string y, int value)
        {
            board.PutCell(new Location(Int32.Parse(x), Int32.Parse(y)), value);
        }

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
    }
}
