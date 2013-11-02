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
    /// task three from the QA exam is to  Test RandomNumber generator web-site
    /// </summary>
    [TestClass]
    public class TestRandomNumber
    {        
        [TestMethod]
        public void RandomNumberGenerator()
        {
            IWebDriver driver = new FirefoxDriver();
            string baseURL = "http://www.random.org/integers/";
            StringBuilder verificationErrors = new StringBuilder();


            driver.Navigate().GoToUrl(baseURL);
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | null | ]]
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Random Integer Generator" == driver.FindElement(By.CssSelector("h2")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Random Integer Generator", driver.FindElement(By.CssSelector("h2")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Name("num")).Clear();
            driver.FindElement(By.Name("num")).SendKeys("1");
            driver.FindElement(By.Name("max")).Clear();
            driver.FindElement(By.Name("max")).SendKeys("2");
            driver.FindElement(By.XPath("//*[@value='Get Numbers']")).Click();
            //can not find the submit button / input
            driver.FindElement(By.XPath("//input[@value='Again!']")).Click();
           //driver.FindElement(By.XPath("//input[@value='Again!']")).Click();
            //driver.FindElement(By.XPath("//input[@value='Again!']")).Click();
            //driver.FindElement(By.XPath("//input[@value='Again!']")).Click();
            //driver.FindElement(By.XPath("//input[@value='Again!']")).Click();
            //driver.FindElement(By.XPath("//input[@value='Again!']")).Click();
        




            driver.Quit();
        }
    }
}
