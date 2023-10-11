namespace WpfTestApplication.Tests
{
    #region using

    using System.Linq;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Winium;

    #endregion

    [TestFixture]
    public class ActionChainsTests : BaseForMainWindowTest
    {
        #region Public Methods and Operators

        [Test]
        public void KeyUpAndKeyDown()
        {
            var list = this.MainWindow.FindElement(WiniumBy.AutomationId("TextListBox"));
            var items = list.FindElements(WiniumBy.ClassName("ListBoxItem"));
            var first = items.First();
            var random = items.ElementAt(3);
            var actions = new Actions(this.Driver);

            actions.Click(first).KeyDown(Keys.Shift).Click(random).KeyUp(Keys.Shift).Perform();

            var selectedItemsCount = list.FindElements(WiniumBy.ClassName("ListBoxItem")).Count(item => item.Selected);

            Assert.AreEqual(4, selectedItemsCount);
        }

        #endregion
    }
}
