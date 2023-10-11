namespace WindowsFormsTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;

    #endregion

    [TestFixture]
    public class FindTests : BaseTest
    {
        #region Public Properties

        public IWebElement MainWindow
        {
            get
            {
                var mainWindowStrategy = WiniumBy.XPath("/*[@AutomationId='Form1']");
                return this.Driver.FindElement(mainWindowStrategy);
            }
        }

        #endregion

        #region Public Methods and Operators

        [Test]
        public void FindChildElementById()
        {
            var child = Driver.FindElement(WiniumBy.AutomationId("TextBox1"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindChildElementByName()
        {
            var child = Driver.FindElement(WiniumBy.Name("TextBox1"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindElementById()
        {
            var element = Driver.FindElement(WiniumBy.AutomationId("TextBox1"));
            Assert.NotNull(element);
        }

        [Test]
        public void FindElementByName()
        {
            var element = Driver.FindElement(WiniumBy.Name("TextBox1"));
            Assert.NotNull(element);
        }

        [Test]
        public void FindElements()
        {
            var comboBox = this.MainWindow.FindElement(WiniumBy.AutomationId("TextComboBox"));
            var elements = comboBox.FindElements(WiniumBy.AutomationId(""));
            Assert.AreEqual(6, elements.Count);
        }

        [Test]
        public void FindNoElements()
        {
            var elements = Driver.FindElements(WiniumBy.AutomationId("UnexistId"));
            Assert.AreEqual(0, elements.Count);
        }

        #endregion
    }
}
