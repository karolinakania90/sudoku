using System.Collections.Generic;

namespace Sudoku.Engine
{
    public class SelectedItemState
    {
        public List<int[]> Duplicates { get; set; }

        public SelectedItemState()
        {
            Duplicates = new List<int[]>();
        }
    }
}
