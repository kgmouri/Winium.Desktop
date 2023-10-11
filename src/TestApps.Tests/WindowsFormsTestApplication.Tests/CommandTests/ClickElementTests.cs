namespace WindowsFormsTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;

    #endregion

    [TestFixture]
    public class ClickElementTests : BaseForMainWindowTest
    {
        #region Public Methods and Operators

        [Test]
        public void ClickButtonWhichSetsText()
        {
            this.MainWindow.FindElement(WiniumBy.AutomationId("SetTextButton")).Click();

            Assert.AreEqual("CARAMBA", this.MainWindow.FindElement(WiniumBy.AutomationId("TextBox1")).Text);
        }

        #endregion
    }
}
