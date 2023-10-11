namespace WpfTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Winium;

    #endregion

    [TestFixture]
    public class FindTests : BaseTest<WiniumDriver>
    {
        #region Public Properties

        public IWebElement MainWindow
        {
            get
            {
                var mainWindowStrategy = WiniumBy.XPath("/*[@AutomationId='WpfTestApplicationMainWindow']");
                return this.Driver.FindElement(mainWindowStrategy);
            }
        }

        #endregion

        #region Public Methods and Operators

        [Test]
        public void FindChildElementByClassName()
        {
            var child = this.MainWindow.FindElement(WiniumBy.ClassName("TextBox"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindChildElementById()
        {
            var child = this.MainWindow.FindElement(WiniumBy.AutomationId("TextBox1"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindChildElementByName()
        {
            var child = this.MainWindow.FindElement(WiniumBy.Name("IsEnabledTextListBox"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindElementByClassName()
        {
            var element = this.Driver.FindElement(WiniumBy.ClassName("Window"));
            Assert.NotNull(element);
        }

        [Test]
        public void FindElementById()
        {
            var element = this.MainWindow;
            Assert.NotNull(element);
        }

        [Test]
        public void FindElementByName()
        {
            var element = this.Driver.FindElement(WiniumBy.Name("MainWindow"));
            Assert.NotNull(element);
        }

        [Test]
        public void FindElements()
        {
            var comboBox = this.MainWindow.FindElement(WiniumBy.AutomationId("TextComboBox"));
            comboBox.Click();

            var elements = comboBox.FindElements(WiniumBy.ClassName("ListBoxItem"));
            Assert.AreEqual(6, elements.Count);
        }

        [Test]
        public void FindNoElements()
        {
            var elements = this.MainWindow.FindElements(WiniumBy.AutomationId("UnexistId"));
            Assert.AreEqual(0, elements.Count);
        }

        #endregion
    }
}
