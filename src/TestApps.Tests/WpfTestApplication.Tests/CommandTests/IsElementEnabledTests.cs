namespace WpfTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;

    #endregion

    public class IsElementEnabledTests : BaseForMainWindowTest
    {
        #region Public Methods and Operators

        [Test]
        public void IsDisabledElement()
        {
            var list = this.MainWindow.FindElement(WiniumBy.AutomationId("TextListBox"));

            var disabledCheckBox = this.MainWindow.FindElement(WiniumBy.AutomationId("CheckBox1"));
            disabledCheckBox.Click();

            Assert.IsFalse(list.Enabled);
        }

        [Test]
        public void IsEnabledElement()
        {
            var list = this.MainWindow.FindElement(WiniumBy.AutomationId("TextListBox"));

            Assert.IsTrue(list.Enabled);
        }

        #endregion
    }
}
