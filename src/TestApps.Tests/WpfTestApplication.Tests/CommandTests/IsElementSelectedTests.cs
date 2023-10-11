namespace WpfTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;

    #endregion

    public class IsElementSelectedTests : BaseForMainWindowTest
    {
        #region Public Methods and Operators

        [Test]
        public void IsSelectedCheckBox()
        {
            var checkbox = this.MainWindow.FindElement(WiniumBy.AutomationId("CheckBox1"));

            Assert.IsTrue(checkbox.Selected);
        }

        [Test]
        public void IsSelectedListItem()
        {
            var list = this.MainWindow.FindElement(WiniumBy.AutomationId("TextListBox"));
            var listItem = list.FindElement(WiniumBy.Name("May"));

            listItem.Click();

            Assert.IsTrue(listItem.Selected);
        }

        [Test]
        public void IsSelectedTab()
        {
            var tab = this.MainWindow.FindElement(WiniumBy.Name("TabItem1"));

            Assert.IsTrue(tab.Selected);
        }

        [Test]
        public void IsUnselectedCheckBox()
        {
            var checkbox = this.MainWindow.FindElement(WiniumBy.AutomationId("CheckBox1"));

            checkbox.Click();

            Assert.IsFalse(checkbox.Selected);
        }

        [Test]
        public void IsUnselectedListItem()
        {
            var list = this.MainWindow.FindElement(WiniumBy.AutomationId("TextListBox"));
            var listItem = list.FindElement(WiniumBy.Name("May"));

            Assert.IsFalse(listItem.Selected);
        }

        [Test]
        public void IsUnselectedTab()
        {
            var tab = this.MainWindow.FindElement(WiniumBy.Name("TabItem2"));

            Assert.IsFalse(tab.Selected);
        }

        #endregion
    }
}
