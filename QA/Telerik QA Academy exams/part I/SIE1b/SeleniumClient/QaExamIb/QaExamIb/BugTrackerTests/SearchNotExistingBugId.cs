using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using QaExamIb;
using WebDriverQaExamI.Pages;
using OpenQA.Selenium.Support.UI;

namespace WebDriverQaExamI.BugTrackerTests
{
    [TestClass]
    public class SearchNotExistingBugId
    {
        [TestMethod]
        public void SearchNotExistingBug()
        {
            BaseTest.BaseUrl = BugTrackerPage.HomePageUrl;
            BaseTest.Setup(BaseTest.BaseUrl);

            WebDriverWait wait = new WebDriverWait(BaseTest.BaseDriver, TimeSpan.FromSeconds(5));
            wait.Until((d) => { return d.Title.StartsWith("BugTracker"); });
 
            BugTrackerPage.AreAllElementShown();                
           
            BugTrackerPage.BugIdTextInput.Clear();
            BugTrackerPage.BugIdTextInput.SendKeys("123abc");
            BugTrackerPage.GotoIdBtn.Click();

            try
            {
                Assert.IsTrue(BugTrackerPage.ErrorMsgLabel.Displayed);
            }
            catch (NoSuchElementException nsee)
            {
                Thread.Sleep(1500);
                Assert.IsTrue(BugTrackerPage.ErrorMsgLabel.Displayed);
            }
            
            string expectedErrMsg = "Error: Bug ID must be an integer.";
            Assert.AreEqual(expectedErrMsg, BugTrackerPage.ErrorMsgLabel.Text);

            BaseTest.TearDown();
        }
    }
}
