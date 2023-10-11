namespace WindowsFormsTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;

    #endregion

    using OpenQA.Selenium.Winium;
    public class IsElementDisplayedTests : BaseForMainWindowTest
    {
        #region Public Methods and Operators

        [Test]
        public void IsDisplaydVisibleElement()
        {
            var element = this.MainWindow.FindElement(WiniumBy.AutomationId("TextBox1"));

            Assert.IsTrue(element.Displayed);
        }

        #endregion
    }
}
