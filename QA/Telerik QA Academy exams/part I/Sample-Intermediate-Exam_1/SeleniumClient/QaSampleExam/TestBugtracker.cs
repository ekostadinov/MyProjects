using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Text;
using System.Threading;

namespace QaSampleExam
{
    /// <summary>
    /// Second task for the exam. Test the Bugtracker web-site functionality.
    /// </summary>
    [TestClass]
    public class TestBugtracker
    {
        [TestMethod]
        public void NoSuchBugYetTest()
        {
            IWebDriver driver = new FirefoxDriver();
            string baseURL = "http://ifdefined.com/";
            StringBuilder verificationErrors = new StringBuilder();



            driver.Navigate().GoToUrl(baseURL + "/btnet/bugs.aspx");
            try
            {
                Assert.AreEqual("BugTracker.NET - bugs", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("lucene_input")).Clear();
            driver.FindElement(By.Id("lucene_input")).SendKeys("21213221");
            driver.FindElement(By.XPath("//input[@value='search text']")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("No bugs yet." == driver.FindElement(By.CssSelector("p")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("No bugs yet.", driver.FindElement(By.CssSelector("p")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }



            driver.Quit();
        }

        [TestMethod]
        public void CreateBugTest()
        {
            IWebDriver driver = new FirefoxDriver();
            string baseURL = "http://ifdefined.com/btnet/bugs.aspx";
            StringBuilder verificationErrors = new StringBuilder();


            driver.Navigate().GoToUrl(baseURL);
            try
            {
                Assert.AreEqual("BugTracker.NET - bugs", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//div[contains(@class, 'align')]/table/tbody/tr/td/a")).Click();
            try
            {
                Assert.AreEqual("BugTracker.NET - Create Bug", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            
            try
            {
                Assert.AreEqual("Project:", driver.FindElement(By.XPath("//span[conatins(@id, 'project_label')]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            // ERROR: Caught exception [ReferenceError: selectLocator is not defined]
            driver.FindElement(By.CssSelector("option[value=\"3\"]")).Click();
            
            try
            {
                Assert.AreEqual("[no project] DemoProject HasCustomFieldsProject HasDifferentPermissionsProject", driver.FindElement(By.Id("project")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            
            try
            {
                Assert.AreEqual("Project-specific", driver.FindElement(By.Id("label_pcd1")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }


            driver.Quit();
        }

        [TestMethod]
        public void CreateBugTestFunctionalProjectSpecific()
        {

            IWebDriver driver = new FirefoxDriver();
            string baseURL = "http://ifdefined.com/btnet/bugs.aspx";
            StringBuilder verificationErrors = new StringBuilder();


            driver.Navigate().GoToUrl(baseURL);
            try
            {
                Assert.AreEqual("BugTracker.NET - bugs", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//div[contains(@class, 'align')]/table/tbody/tr/td/a")).Click();
            try
            {
                Assert.AreEqual("BugTracker.NET - Create Bug", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }

            try
            {
                Assert.AreEqual("Project:", driver.FindElement(By.XPath("//span[conatins(@id, 'project_label')]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            // ERROR: Caught exception [ReferenceError: selectLocator is not defined]
            driver.FindElement(By.CssSelector("option[value=\"3\"]")).Click();

            try
            {
                Assert.AreEqual("[no project] DemoProject HasCustomFieldsProject HasDifferentPermissionsProject", driver.FindElement(By.Id("project")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }

            try
            {
                Assert.AreEqual("Project-specific", driver.FindElement(By.Id("label_pcd1")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }



            // ERROR: Caught exception [ReferenceError: selectLocator is not defined]      
            driver.FindElement(By.CssSelector("option[value=\"3\"]")).Click();
            try
            {
                Assert.AreEqual("[no project] DemoProject HasCustomFieldsProject HasDifferentPermissionsProject", driver.FindElement(By.Id("project")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }




            try
            {
                Assert.AreEqual("Project-specific", driver.FindElement(By.Id("label_pcd1")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("short_desc")).Clear();
            driver.FindElement(By.Id("short_desc")).SendKeys("Out-of-frame Telerik Rad Rotator contol");
            
           
            driver.FindElement(By.Id("Samplecustomfield")).Clear();
            driver.FindElement(By.Id("Samplecustomfield")).SendKeys("When selected the Rad rotator in vertical position shows the pictures out of frame with wifth 600 and height 150px");
           
            driver.FindElement(By.Id("comment")).Clear();
            driver.FindElement(By.Id("comment")).SendKeys("Get over it!");
           
 
            driver.FindElement(By.Id("submit_button")).Click();
           
           
            try
            {
                Assert.AreEqual("Bug ID:", driver.FindElement(By.Id("bugid_label")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
           
 
            //working to here

            try
            {
                Assert.AreEqual("[no project] DemoProject HasCustomFieldsProject HasDifferentPermissionsProject", driver.FindElement(By.Id("project")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Project-specific" == driver.FindElement(By.Id("label_pcd1")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Project-specific", driver.FindElement(By.Id("label_pcd1")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }


            driver.Quit();
        }
    }
}
