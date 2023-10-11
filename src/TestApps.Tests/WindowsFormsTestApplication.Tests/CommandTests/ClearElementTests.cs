namespace WindowsFormsTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;

    #endregion

    public class ClearElementTests : BaseForMainWindowTest
    {

        #region Public Methods and Operators

        [Test]
        public void ClearTextBox()
        {
            var textBox = this.MainWindow.FindElement(WiniumBy.AutomationId("TextBox1"));
            textBox.Clear();

            Assert.AreEqual(string.Empty, textBox.Text);
        }

        #endregion
    }
}
