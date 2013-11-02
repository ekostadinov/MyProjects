using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Text;
using System.Threading;

namespace QaSampleExam
{
    [TestClass]
    public class TestMagento
    {
        [TestMethod]
        public void MagentoNoInputUserData()
        {
            IWebDriver driver = new FirefoxDriver();
            //string baseURL = "http://demo.nostresscommerce.cz/";
            StringBuilder verificationErrors = new StringBuilder();


            driver.Navigate().GoToUrl("http://demo.nostresscommerce.cz/");
            driver.FindElement(By.XPath("//*[contains(@class, 'links')]/li/a")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("");
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("");
            driver.FindElement(By.XPath("//button[contains(@id, 'send2')]")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Login or Create an Account" == driver.FindElement(By.CssSelector("h1")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Login or Create an Account", driver.FindElement(By.CssSelector("h1")).Text);
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
                    if ("This is a required field." == driver.FindElement(By.Id("advice-required-entry-email")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("This is a required field.", driver.FindElement(By.Id("advice-required-entry-email")).Text);
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
                    if ("This is a required field." == driver.FindElement(By.Id("advice-required-entry-pass")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("This is a required field.", driver.FindElement(By.Id("advice-required-entry-pass")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }

            driver.Quit();
        }

        [TestMethod]
        public void MagentoIncorrectUser()
        {
            IWebDriver driver = new FirefoxDriver();
            string baseURL = "http://demo.nostresscommerce.cz/";
            StringBuilder verificationErrors = new StringBuilder();


            driver.Navigate().GoToUrl(baseURL);

            driver.FindElement(By.XPath("//*[contains(@class, 'links')]/li/a")).Click();
            driver.FindElement(By.XPath("//input[contains(@id, 'email')]")).Clear();
            driver.FindElement(By.XPath("//input[contains(@id, 'email')]")).SendKeys("testtwo@any.com");
            driver.FindElement(By.XPath("//input[contains(@id, 'pass')]")).Clear();
            driver.FindElement(By.XPath("//input[contains(@id, 'pass')]")).SendKeys("123456");
            driver.FindElement(By.Id("send2")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Login or Create an Account" == driver.FindElement(By.CssSelector("h1")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Login or Create an Account", driver.FindElement(By.CssSelector("h1")).Text);
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
                    if ("Invalid login or password." == driver.FindElement(By.CssSelector("li > span")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Invalid login or password.", driver.FindElement(By.CssSelector("li > span")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            
            driver.Quit();
        }
    }
}
