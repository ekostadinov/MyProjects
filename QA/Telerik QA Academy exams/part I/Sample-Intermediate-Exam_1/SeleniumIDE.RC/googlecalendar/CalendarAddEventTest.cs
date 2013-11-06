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
    public class GoogleCalendarAddEventTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.google.com/ ";
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
        public void TheGoogleCalendarAddEventTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com/");
            try
            {
                Assert.AreEqual("Google", driver.Title);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("gb_70")).Click();
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("testqaexam");
            driver.FindElement(By.Id("Passwd")).Clear();
            driver.FindElement(By.Id("Passwd")).SendKeys("TestPass");
            driver.FindElement(By.Id("signIn")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("testqaexam@gmail.com" == driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("testqaexam@gmail.com", driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | null | ]]
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | null | ]]
            driver.FindElement(By.CssSelector("a.gb_n.gb_d")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Календар" == driver.FindElement(By.CssSelector("#gb24 > span.gb_e")).Text) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Календар", driver.FindElement(By.CssSelector("#gb24 > span.gb_e")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.CssSelector("#gb24 > span.gb_e")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Google Календар" == driver.Title) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Google Календар", driver.Title);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Създаване" == driver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]")).Text) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Създаване", driver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Запазване\n\n\n\n\n\n  \nОтхвърляне" == driver.FindElement(By.CssSelector("div.ep-ea.noprint")).Text) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Запазване\n\n\n\n\n\n  \nОтхвърляне", driver.FindElement(By.CssSelector("div.ep-ea.noprint")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//input[@id=':1r']")).Clear();
            driver.FindElement(By.XPath("//input[@id=':1r']")).SendKeys("Meeting 8 pm today");
            driver.FindElement(By.XPath("//div[contains(text(), 'Запазване')]")).Click();
            driver.Navigate().GoToUrl("https://www.google.com/calendar/render?tab=wc&pli=1");
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td[contains(@class, 'today')]/div[2]/div/div/dl/dd/span[contains(text(), 'Meeting 8 pm today')]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//td[contains(@class, 'today')]/div[2]/div/div/dl/dd/span[contains(text(), 'Meeting 8 pm today')]")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Изтриване" == driver.FindElement(By.XPath("//div[@id=':1s.delete_top']/div/div/div/div/div[2]")).Text) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Изтриване", driver.FindElement(By.XPath("//div[@id=':1s.delete_top']/div/div/div/div/div[2]")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//div[contains(text(), 'Изтриване')]")).Click();
            try
            {
                Assert.IsFalse(IsElementPresent(By.XPath("//td[contains(@class, 'today')]/div[2]/div/div/dl/dd/span[contains(text(), 'Meeting 8 pm today')]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("testqaexam@gmail.com" == driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("testqaexam@gmail.com", driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("testqaexam@gmail.com")).Click();
            driver.FindElement(By.Id("gb_71")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Вход" == driver.FindElement(By.Id("signIn")).GetAttribute("value")) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Вход", driver.FindElement(By.Id("signIn")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
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
