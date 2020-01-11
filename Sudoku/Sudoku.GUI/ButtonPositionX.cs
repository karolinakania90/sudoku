using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.GUI
{
    public class ButtonPositionX
    {

        /// <summary>
        /// Chose positionX big squares
        /// </summary>
        public static int PositionX(int row)
        {
            int x = 0;

            if (row > -1 && row < 3)
            {
                x = 0;
            }

            if (row > 2 && row < 6)
            {
                x = 3;
            }

            if (row > 5 && row < 9)
            {
                x = 6;
            }

            return x;
        }
    }
}
