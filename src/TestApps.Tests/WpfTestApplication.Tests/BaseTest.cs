namespace WpfTestApplication.Tests
{
    #region using

    using System;
    using System.IO;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Winium;

    #endregion

    public class BaseTest<TDriver>
        where TDriver : class, IWebDriver
    {
        #region Public Properties

        public TDriver Driver { get; set; }

        #endregion

        #region Public Methods and Operators

        [SetUp]
        public void SetUp()
        {
            var dc = new DesktopOptions();
            dc.ApplicationPath = Path.Combine(Environment.CurrentDirectory, "WpfTestApplication.exe");
            dc.LaunchDelay = 2;
            this.Driver = Activator.CreateInstance(typeof(TDriver), new Uri("http://localhost:9999"), dc) as TDriver;
        }

        [TearDown]
        public void TearDown()
        {
            this.Driver.Close();
        }

        #endregion
    }
}
