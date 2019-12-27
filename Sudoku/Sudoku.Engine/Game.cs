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
            board = new Board();
        }

        public void StartGame()
        {

        }
        
        public void EndGame()
        {

        }

        public ZoneState SetField(int x, int y, int value)
        {

            return ZoneState.Ok;
        }

        public void ValidateGame()
        {

        }

        public Board GetCurrentBoard()
        {
            return null;
        }
    }
}
