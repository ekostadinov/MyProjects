using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class RandomNumberGenerator
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.random.org/integers/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheRandomNumberGeneratorTest()
        {
            driver.Navigate().GoToUrl("http://www.random.org/integers/");
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | null | ]]
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Random Integer Generator" == driver.FindElement(By.CssSelector("h2")).Text) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Random Integer Generator", driver.FindElement(By.CssSelector("h2")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Name("num")).Clear();
            driver.FindElement(By.Name("num")).SendKeys("1");
            driver.FindElement(By.Name("max")).Clear();
            driver.FindElement(By.Name("max")).SendKeys("2");
            driver.FindElement(By.XPath("//input[@value='Get Numbers']")).Click();
            driver.FindElement(By.CssSelector("form > input[type=\"submit\"]")).Click();
            driver.FindElement(By.CssSelector("form > input[type=\"submit\"]")).Click();
            driver.FindElement(By.CssSelector("form > input[type=\"submit\"]")).Click();
            driver.FindElement(By.CssSelector("form > input[type=\"submit\"]")).Click();
            driver.FindElement(By.CssSelector("form > input[type=\"submit\"]")).Click();
            driver.FindElement(By.CssSelector("form > input[type=\"submit\"]")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
