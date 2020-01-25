using SudokuSharp;
using System;

namespace Sudoku.Engine
{
    public class HistoryItem
    {
        /// <summary>
        /// Field Location
        /// </summary>
        public Location Location{ get; set; }

        /// <summary>
        /// Field value
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Information when field value was added
        /// </summary>
        public DateTime AddDate { get; set; }
    }
}
