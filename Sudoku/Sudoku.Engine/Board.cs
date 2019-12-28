using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Engine
{
    internal class Board
    {
        private int[,] sudokuFields;

        public Board()
        {
            sudokuFields = new int[9, 9];
        }

        public void SetField(int y, int x, int value)
        {
            sudokuFields[y, x] = value;
        }

        public int[,] GetCurrentFields()
        {
            return sudokuFields;
        }
    }
}
