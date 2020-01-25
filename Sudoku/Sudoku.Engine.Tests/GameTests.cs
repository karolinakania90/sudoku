using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sudoku.Engine.Tests
{
    [TestClass]
    public class GameTests
    {
        /// Checks if SudokuSharp Board is the some as visible board
        [TestMethod]
        public void GameBoardSameAsLibraryBoardEasy()
        {
            var game = new Game(GameLevel.Easy);

            var gameBoard = game.CurrentGameBoard();
            var gameBoardString = game.CurrentGameBoardString();


            int[,] tempBoard = new int[9, 9];

            var boardString = gameBoardString.ToString().Replace(" ", "").ToArray().Where(c => c != '\n').ToList();

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

                tempBoard[row, column] = Int32.Parse(boardString[i].ToString());
                column++;

            }

            // https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.collectionassert?view=mstest-net-1.2.0
            CollectionAssert.AreEqual(gameBoard, tempBoard);
        }


        /// <summary>
        /// checks if setting value to Board works
        /// </summary>
        [TestMethod]
        public void SetItemValueOnBoard_Valid()
        {
            var game = new Game(GameLevel.Easy);
            int expectedValue = 10;

            game.SetField(0, 1, expectedValue);

            var value = game.GetFieldValue(0, 1);

            Assert.IsTrue(value == expectedValue);
        }


        /// <summary>
        /// checks if getting value from Board works
        /// </summary>
        [TestMethod]
        public void GetItemValueOnBoard_Valid()
        {
            var game = new Game(GameLevel.Easy);

            game.SetField(1, 1, 10);

            var value = game.ValueIsSet(1, 1);

            Assert.IsTrue(value);
        }

        [TestMethod]
        public void BoardHasTwoOrMoreDuplicates_Valid()
        {
            var game = new Game(GameLevel.Easy);
            int duplicatedValue = 10;

            game.SetField(1, 1, duplicatedValue);
            game.SetField(1, 2, duplicatedValue);

            var result = game.ValidateCurrentItem(1, 1);

            Assert.IsTrue(result.Duplicates.Count >= 2);
        }

        [TestMethod]
        public void CheckHistoryItems()
        {
            var game = new Game(GameLevel.Easy);

            game.SetField(1, 1, 20);

            var items = game.GetHistoryItems();

            Assert.IsTrue(items.Count == 1);
            Assert.IsTrue(items[0].Value == 20);
        }
    }
}
