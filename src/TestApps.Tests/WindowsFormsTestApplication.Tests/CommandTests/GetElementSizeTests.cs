namespace WindowsFormsTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;

    #endregion

    public class GetElementSizeTests : BaseTest
    {
        #region Public Methods and Operators

        [TestCase("TextBox1", 200, 20)]
        [TestCase("TextListBox", 200, 95)]
        public void GetSizeOfElement(string elementId, int width, int height)
        {
            var mainWindowStrategy = WiniumBy.XPath("/*[@AutomationId='Form1']");
            var element = this.Driver.FindElement(mainWindowStrategy).FindElement(WiniumBy.AutomationId(elementId));

            var size = element.Size;

            Assert.AreEqual(width, size.Width);
            Assert.AreEqual(height, size.Height);
        }

        #endregion
    }
}
