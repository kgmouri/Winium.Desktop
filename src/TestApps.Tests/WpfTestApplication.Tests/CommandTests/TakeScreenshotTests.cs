﻿namespace WpfTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Winium;

    #endregion

    public class TakeScreenshotTests : BaseTest<WiniumDriver>
    {
        #region Public Methods and Operators

        [Test]
        public void TakeScreenshotAfterStartApplication()
        {
            var screenshot = this.Driver.GetScreenshot().ToString();
            Assert.That(screenshot.Length, Is.GreaterThan(0));
        }

        #endregion
    }
}
