using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sudoku.GUI.Tests
{
    [TestClass]
    public class GUI
    {
        [TestMethod]
        public void CheckStringValue()
        {
            string value = CheckString.CheckStringValue("2");
            Assert.IsTrue(value == "2");
        }


        [TestMethod]
        public void CheckStringValueEmpty()
        {
            string value = CheckString.CheckStringValue("");
            Assert.IsTrue(value == "0");
        }
    }
}
