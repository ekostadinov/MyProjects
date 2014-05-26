using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using WebDriverQaExamI.Pages;
using OpenQA.Selenium.Support.UI;

namespace WebDriverQaExamI.BugTrackerTests
{
    [TestClass]
    public class AddBugProjectSpecific
    {
        [TestMethod]
        public void AddProject()
        {
            BaseTest.BaseUrl = BugTrackerPage.HomePageUrl;
            BaseTest.Setup(BaseTest.BaseUrl);

            WebDriverWait wait = new WebDriverWait(BaseTest.BaseDriver, TimeSpan.FromSeconds(5));
            wait.Until((d) => { return d.Title.StartsWith("BugTracker"); });

            BugTrackerPage.AreAllElementShown();


            Assert.AreEqual("BugTracker.NET - bugs", BaseTest.BaseDriver.Title);
            // add new bug
            BugTrackerPage.AddNewBugBtn.Click();

            wait.Until((d) => { return d.Title.StartsWith("BugTracker.NET - Create Bug"); });
 
            try
            {
                Assert.AreEqual("Project:", BugTrackerPage.ProjectTextLabel.Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Assert.IsTrue(BugTrackerPage.ProjectSelect.Displayed);
            var select = new SelectElement(BugTrackerPage.ProjectSelect); 
            select.SelectByText("HasCustomFieldsProject");
            //BaseTest.BaseDriver.FindElement(By.XPath("//option[@value='3']")).Click();
            Assert.AreEqual("Project-specific", BugTrackerPage.ProjectSpecificLabel.Text);
            Assert.IsTrue(BugTrackerPage.ProjectSpecificSelect.Displayed);
        
            BaseTest.TearDown();
        }
    }
}
