namespace WindowsFormsTestApplication.Tests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;

    #endregion

    public class BaseForMainWindowTest : BaseTest
    {
        #region Public Properties

        public WiniumElement MainWindow { get; set; }

        #endregion

        #region Public Methods and Operators

        [SetUp]
        public void FindMainWindow()
        {
            this.MainWindow = this.Driver.FindElement(WiniumBy.XPath("/*[@AutomationId='Form1']"));
        }

        #endregion
    }
}
