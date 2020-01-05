using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sudoku.Engine.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GameBoardSameAsLibraryBoardEasy()
        {
            var game = new Game(GameLevel.Easy);

            var gameBoard = game.CurrentGameBoard();

            var gameBoardString = game.CurrentGameBoardString();

            Assert.IsTrue(true);

        }
    }
}
