namespace WindowsFormsTestApplication.Tests
{
    #region using

    using System;
    using System.IO;

    using NUnit.Framework;

    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Winium;

    #endregion

    public class BaseTest
    {
        #region Public Properties

        public WiniumDriver Driver { get; set; }

        #endregion

        #region Public Methods and Operators

        [SetUp]
        public void SetUp()
        {
            var dc = new DesktopOptions();
            dc.ApplicationPath = Path.Combine(Environment.CurrentDirectory, "WindowsFormsTestApplication.exe");
            dc.LaunchDelay = 2;
            this.Driver = new WiniumDriver(new Uri("http://localhost:9999"), dc);
        }

        [TearDown]
        public void TearDown()
        {
            this.Driver.Close();
        }

        #endregion
    }
}
