using SudokuSharp;
using System;

namespace Sudoku.Engine
{
    public class HistoryItem
    {
        public Location Location{ get; set; }

        public int Value { get; set; }

        public DateTime AddDate { get; set; }
    }
}
