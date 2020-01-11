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

        [TestMethod]
        public void PlusValueButtons()
        {
            int value = PlusValue.Plus(2);
            Assert.IsTrue(value == 3);
        }

        [TestMethod]
        public void PlusValueButtonsCondition()
        {
            int value = PlusValue.Plus(9);
            Assert.IsTrue(value == 1);
        }
        
        [TestMethod]
        public void ButtonX()
        {
            int value = ButtonPositionX.PositionX(5);
            Assert.IsTrue(value == 3);
        }

        [TestMethod]
        public void ButtonY()
        {
            int value = ButtonPositionX.PositionX(1);
            Assert.IsTrue(value == 0);
        }
    }
}
