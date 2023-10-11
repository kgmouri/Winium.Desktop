namespace WpfTestApplication.Tests.CommandTests
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

        [Test]
        public void ClickByTwoElementsWithPressedControl()
        {
            var list = this.MainWindow.FindElement(WiniumBy.AutomationId("TextListBox"));

            var listItem1 = list.FindElement(WiniumBy.Name("March"));
            var listItem2 = list.FindElement(WiniumBy.Name("January"));
            var listItem3 = list.FindElement(WiniumBy.Name("February"));

            this.Driver.ExecuteScript("input: ctrl_click", listItem1);
            this.Driver.ExecuteScript("input: ctrl_click", listItem2);

            Assert.IsTrue(listItem1.Selected);
            Assert.IsTrue(listItem2.Selected);
            Assert.IsFalse(listItem3.Selected);
        }

        [Test]
        public void ClickByElementBoundingRecatngleCenter()
        {
            var list = this.MainWindow.FindElement(WiniumBy.AutomationId("TextListBox"));

            var listItem1 = list.FindElement(WiniumBy.Name("March"));

            this.Driver.ExecuteScript("input: brc_click", listItem1);

            Assert.IsTrue(listItem1.Selected);
        }

        #endregion
    }
}
