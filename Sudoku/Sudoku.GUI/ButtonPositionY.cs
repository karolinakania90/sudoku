using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.GUI
{
    public class ButtonPositionY
    {

        /// <summary>
        /// Chose positionY big squares
        /// </summary>
        public static int PositionY(int column)
        {
            int y = 0;

            if (column > -1 && column < 3)
            {
                y = 0;
            }

            if (column > 2 && column < 6)
            {
                y = 3;
            }

            if (column > 5 && column < 9)
            {
                y = 6;
            }

            return y;
        }
    }
}
