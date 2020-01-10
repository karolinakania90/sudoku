using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.GUI
{
    public class CheckString
    {
        /// <summary>
        /// Check button has a value
        /// </summary>
        public static string CheckStringValue(string value)
        {
            if (value == "")
            {
                value = "0";
                return value;
            }
            return value;
        }
    }
}
