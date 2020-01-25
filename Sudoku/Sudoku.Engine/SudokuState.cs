using System.Collections.Generic;

namespace Sudoku.Engine
{
    /// <summary>
    /// Information about Sudoku state. If it has duplicates 
    /// </summary>
    public class SudokuState
    {
        /// <summary>
        /// List of sudoku duplicates
        /// </summary>
        public List<int[]> Duplicates { get; set; }

        public SudokuState()
        {
            Duplicates = new List<int[]>();
        }
    }
}
