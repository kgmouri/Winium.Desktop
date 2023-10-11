namespace WpfTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;

    #endregion

    public class GetElementTextTests : BaseForMainWindowTest
    {
        #region Public Methods and Operators

        [Test]
        public void GetTextBoxText()
        {
            var textBox = this.MainWindow.FindElement(WiniumBy.AutomationId("TextBox1"));
            Assert.AreEqual("TextBox1", textBox.Text);
        }

        #endregion
    }
}
