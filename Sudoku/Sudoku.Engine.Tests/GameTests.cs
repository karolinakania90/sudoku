using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sudoku.Engine.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        /// to implement
        public void GameBoardSameAsLibraryBoardEasy()
        {
            var game = new Game(GameLevel.Easy);

            var gameBoard = game.CurrentGameBoard();

            var gameBoardString = game.CurrentGameBoardString();

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void SetItemValueOnBoard_Valid()
        {
            var game = new Game(GameLevel.Easy);
            int expectedValue = 10;

            game.SetField(0, 1, expectedValue);

            var value = game.GetFieldValue(0, 1);

            Assert.IsTrue(value == expectedValue);
        }
    }
}
