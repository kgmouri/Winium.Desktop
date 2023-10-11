namespace WindowsFormsTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Winium;

    #endregion

    [Ignore("Action class cannot be used")]
    public class SendKeysToActiveElementTests : BaseForMainWindowTest
    {
        #region Public Methods and Operators

        [Test]
        public void SendKeysToActiveElement()
        {
            var textbox = this.MainWindow.FindElement(WiniumBy.AutomationId("TextBox1"));
            textbox.Click();

            var action = new Actions(this.Driver);
            action.SendKeys("test");

            Assert.AreEqual("TextBox1test", textbox.Text);
        }

        #endregion
    }
}
