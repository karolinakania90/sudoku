using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.GUI
{
    public class PlusValue
    {
        /// <summary>
        /// Increase in value button
        /// </summary>
        public static int Plus(int value)
        {
            value++;
            if (value > 9)
            {
                value = 1;
            }
            return value;
        }
    }
}
