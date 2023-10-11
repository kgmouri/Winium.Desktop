namespace WpfTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Winium;

    #endregion

    public class GetElementSizeTests : BaseTest<WiniumDriver>
    {
        #region Public Methods and Operators

        [TestCase("TextBox1", 200, 23)]
        [TestCase("TextListBox", 200, 100)]
        public void GetSizeOfElement(string elementId, int width, int height)
        {
            var mainWindowStrategy = WiniumBy.XPath("/*[@AutomationId='WpfTestApplicationMainWindow']");
            var element = this.Driver.FindElement(mainWindowStrategy).FindElement(WiniumBy.AutomationId(elementId));

            var size = element.Size;

            Assert.AreEqual(width, size.Width);
            Assert.AreEqual(height, size.Height);
        }

        #endregion
    }
}
