using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace QaSampleExam
{
    [TestClass]
    public class TestGoogleCalendar
    {
        //alternative for command IsElementPresent
        private bool isElementPresent(IWebDriver driver, By by)
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

        private string UniqueEventName()
        {
            string eventName = string.Empty;

            string currDate = DateTime.Now.Date.ToShortDateString();
            string currHour = DateTime.Now.Hour.ToString();
            string currMin = DateTime.Now.Minute.ToString();
            string currSec = DateTime.Now.Second.ToString();

            eventName = currDate + currHour + currHour + currSec;

                return eventName;
            
        }

        [TestMethod]
        public void CorrectUserLogInTest()
        {
            IWebDriver driver = new FirefoxDriver();
            string baseURL = "http://www.google.com/ ";
            StringBuilder verificationErrors = new StringBuilder();


            driver.Navigate().GoToUrl(baseURL);
            try
            {
                Assert.AreEqual("Google", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("gb_70")).Click();
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("testqaexam");
            driver.FindElement(By.Id("Passwd")).Clear();
            driver.FindElement(By.Id("Passwd")).SendKeys("TestPass");
            driver.FindElement(By.Id("signIn")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("testqaexam@gmail.com" == driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("testqaexam@gmail.com", driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }

            // command [selectWindow | null | ]
            string currentWindowHadle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(currentWindowHadle);

            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("testqaexam@gmail.com" == driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("testqaexam@gmail.com", driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("testqaexam@gmail.com")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Изход" == driver.FindElement(By.Id("gb_71")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Изход", driver.FindElement(By.Id("gb_71")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("gb_71")).Click();
           
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Вход" == driver.FindElement(By.Id("gb_70")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Вход", driver.FindElement(By.Id("gb_70")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }

            driver.Quit();


        }


        [TestMethod]
        public void CalendarAddEventTest()
        {
            //set-up the test
            IWebDriver driver = new FirefoxDriver();
            string baseURL = "http://www.google.com/ ";
            StringBuilder verificationErrors = new StringBuilder();

            //test body
            driver.Navigate().GoToUrl(baseURL);
            try
            {
                Assert.AreEqual("Google", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("gb_70")).Click();
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("testqaexam");
            driver.FindElement(By.Id("Passwd")).Clear();
            driver.FindElement(By.Id("Passwd")).SendKeys("TestPass");
            driver.FindElement(By.Id("signIn")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("testqaexam@gmail.com" == driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("testqaexam@gmail.com", driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | null | ]]
            
            driver.FindElement(By.CssSelector("a.gb_n.gb_d")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Календар" == driver.FindElement(By.CssSelector("#gb24 > span.gb_e")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Календар", driver.FindElement(By.CssSelector("#gb24 > span.gb_e")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.CssSelector("#gb24 > span.gb_e")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Google Календар" == driver.Title) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Google Календар", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            
                try
                {
                    if ("Създаване" == driver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]")).Text);
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            
            try
            {
                Assert.AreEqual("Създаване", driver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]")).Click();
            
                try
                {
                    if ("Запазване\n\n\n\n\n\n  \nОтхвърляне" == driver.FindElement(By.CssSelector("div.ep-ea.noprint")).Text);
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);

                try
                {
                    Assert.AreEqual("Запазване\n\n\n\n\n\n  \nОтхвърляне", driver.FindElement(By.CssSelector("div.ep-ea.noprint")).Text);
                }
                catch (Exception e)
                {
                    verificationErrors.Append(e.Message);
                }
                driver.FindElement(By.XPath("//input[@id=':1r']")).Clear();
                driver.FindElement(By.XPath("//input[@id=':1r']")).SendKeys("Meeting 8 pm today");
                driver.FindElement(By.XPath("//div[contains(text(), 'Запазване')]")).Click();
                driver.Navigate().GoToUrl("https://www.google.com/calendar/render?tab=wc&pli=1");
                try
                {
                    Assert.IsTrue(isElementPresent(driver, By.XPath("//td[contains(@class, 'today')]/div[2]/div/div/dl/dd/span[contains(text(), 'Meeting 8 pm today')]")));
                }
                catch (Exception e)
                {
                    verificationErrors.Append(e.Message);
                }
                driver.FindElement(By.XPath("//td[contains(@class, 'today')]/div[2]/div/div/dl/dd/span[contains(text(), 'Meeting 8 pm today')]")).Click();
           
            
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Изтриване" == driver.FindElement(By.XPath("//div[@id=':1s.delete_top']/div/div/div/div/div[2]")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Изтриване", driver.FindElement(By.XPath("//div[@id=':1s.delete_top']/div/div/div/div/div[2]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//div[contains(text(), 'Изтриване')]")).Click();
            try
            {
                Assert.IsFalse(isElementPresent(driver, By.XPath("//td[contains(@class, 'today')]/div[2]/div/div/dl/dd/span[contains(text(), 'Meeting 8 pm today')]")));
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
                    if ("testqaexam@gmail.com" == driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            
            try
            {
                Assert.AreEqual("testqaexam@gmail.com", driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("testqaexam@gmail.com")).Click();
            driver.FindElement(By.Id("gb_71")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Вход" == driver.FindElement(By.Id("signIn")).GetAttribute("value")) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Вход", driver.FindElement(By.Id("signIn")).GetAttribute("value"));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
        
            //close all resources
            driver.Quit();


        }

        [TestMethod]
        public void CalendarUniqueEventTest()
        {
            //set-up the test
            IWebDriver driver = new FirefoxDriver();
            string baseURL = "http://www.google.com/ ";
            StringBuilder verificationErrors = new StringBuilder();

            //test body
            driver.Navigate().GoToUrl(baseURL);
            try
            {
                Assert.AreEqual("Google", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("gb_70")).Click();
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("testqaexam");
            driver.FindElement(By.Id("Passwd")).Clear();
            driver.FindElement(By.Id("Passwd")).SendKeys("TestPass");
            driver.FindElement(By.Id("signIn")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("testqaexam@gmail.com" == driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("testqaexam@gmail.com", driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | null | ]]

            driver.FindElement(By.CssSelector("a.gb_n.gb_d")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Календар" == driver.FindElement(By.CssSelector("#gb24 > span.gb_e")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Календар", driver.FindElement(By.CssSelector("#gb24 > span.gb_e")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.CssSelector("#gb24 > span.gb_e")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Google Календар" == driver.Title) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Google Календар", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }

            try
            {
                if ("Създаване" == driver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]")).Text);
            }
            catch (Exception)
            { }
            Thread.Sleep(1000);

            try
            {
                Assert.AreEqual("Създаване", driver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]")).Click();

            try
            {
                if ("Запазване\n\n\n\n\n\n  \nОтхвърляне" == driver.FindElement(By.CssSelector("div.ep-ea.noprint")).Text);
            }
            catch (Exception)
            { }
            Thread.Sleep(1000);

            try
            {
                Assert.AreEqual("Запазване\n\n\n\n\n\n  \nОтхвърляне", driver.FindElement(By.CssSelector("div.ep-ea.noprint")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            string uniqueEventName = "Meeting " + UniqueEventName();
            driver.FindElement(By.XPath("//input[@id=':1r']")).Clear();
            driver.FindElement(By.XPath("//input[@id=':1r']")).SendKeys(uniqueEventName);
            driver.FindElement(By.XPath("//div[contains(text(), 'Запазване')]")).Click();
            driver.Navigate().GoToUrl("https://www.google.com/calendar/render?tab=wc&pli=1");
            try
            {
                Assert.IsTrue(isElementPresent(driver, By.XPath("//td[contains(@class, 'today')]/div[2]/div/div/dl/dd/span[contains(text(), '" + uniqueEventName + "')]")));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//td[contains(@class, 'today')]/div[2]/div/div/dl/dd/span[contains(text(), '" + uniqueEventName + "')]")).Click();


            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Изтриване" == driver.FindElement(By.XPath("//div[@id=':1s.delete_top']/div/div/div/div/div[2]")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Изтриване", driver.FindElement(By.XPath("//div[@id=':1s.delete_top']/div/div/div/div/div[2]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//div[contains(text(), 'Изтриване')]")).Click();
            try
            {
                Assert.IsFalse(isElementPresent(driver, By.XPath("//td[contains(@class, 'today')]/div[2]/div/div/dl/dd/span[contains(text(), 'Meeting 8 pm today')]")));
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
                    if ("testqaexam@gmail.com" == driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }

            try
            {
                Assert.AreEqual("testqaexam@gmail.com", driver.FindElement(By.LinkText("testqaexam@gmail.com")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("testqaexam@gmail.com")).Click();
            driver.FindElement(By.Id("gb_71")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if ("Вход" == driver.FindElement(By.Id("signIn")).GetAttribute("value")) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("Вход", driver.FindElement(By.Id("signIn")).GetAttribute("value"));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }

            //close all resources
            driver.Quit();


        }

    }
}
