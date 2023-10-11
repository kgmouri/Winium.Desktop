﻿namespace WindowsFormsTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Winium;

    #endregion

    [Ignore("Action class cannot be used")]
    public class MouseClickTests : BaseForMainWindowTest
    {
        #region Fields

        private Actions action;

        private IWebElement button;

        private IWebElement textBox;

        #endregion

        #region Public Methods and Operators

        [Test]
        public void ClickToButton()
        {
            this.action.MoveToElement(this.button, 1, 1);
            this.action.Click();
            this.action.Perform();

            Assert.AreEqual("CARAMBA", this.textBox.Text);
        }

        [SetUp]
        public void SetUpForFindElementsAndCreateActionsClass()
        {
            this.textBox = this.MainWindow.FindElement(WiniumBy.AutomationId("TextBox1"));
            this.button = this.MainWindow.FindElement(WiniumBy.AutomationId("SetTextButton"));

            this.action = new Actions(this.Driver);
        }

        #endregion
    }
}
