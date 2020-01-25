using System;
using System.Collections.Generic;

namespace Sudoku.Engine
{
    public class History
    {
        public List<HistoryItem> Items { get; set; }

        public History()
        {
            Items = new List<HistoryItem>();
        }

        public void AddItem(int x, int y, int value)
        {
            HistoryItem historyItem = new HistoryItem();
            historyItem.AddDate = DateTime.Now;
            historyItem.Location = new SudokuSharp.Location(y, x);
            historyItem.Value = value;

            Items.Add(historyItem);
        }
    }
}
