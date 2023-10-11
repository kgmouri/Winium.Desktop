﻿namespace WpfTestApplication.Tests.CommandTests
{
    #region using

    using System.Diagnostics;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;

    #endregion

    [TestFixture]
    public class QuitTests
    {
        #region Fields

        private Process appProcess;

        private BaseForMainWindowTest baseForMainWindowTest;

        #endregion

        #region Public Methods and Operators

        [Test]
        public void CloseApplication()
        {
            this.baseForMainWindowTest.Driver.Quit();

            Assert.IsTrue(this.appProcess.HasExited);
        }

        [Test]
        public void CloseApplicationWithOpenedDialogWindow()
        {
            this.baseForMainWindowTest.FindMainWindow();
            var tabItem3 = this.baseForMainWindowTest.MainWindow.FindElement(WiniumBy.AutomationId("TabItem3"));
            tabItem3.Click();
            tabItem3.FindElement(WiniumBy.AutomationId("OpenFileDialogButton")).Click();

            this.baseForMainWindowTest.Driver.Quit();

            Assert.IsTrue(this.appProcess.HasExited);
        }

        [SetUp]
        public void SetUp()
        {
            this.baseForMainWindowTest = new BaseForMainWindowTest();
            this.baseForMainWindowTest.SetUp();

            this.appProcess = Process.GetProcessesByName("WpfTestApplication")[0];
        }

        #endregion
    }
}
