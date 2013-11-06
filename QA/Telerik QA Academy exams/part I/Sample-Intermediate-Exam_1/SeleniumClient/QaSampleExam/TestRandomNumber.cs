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
            
            //the test body
            driver.Navigate().GoToUrl(baseURL);
           
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
            driver.FindElement(By.XPath("//input[@value='Get Numbers']")).Click();

            string fiRand =
            driver.FindElement(By.XPath("//*[@class='data']")).Text.ToString();
            
            driver.Navigate().Refresh();

            string newRand = driver.FindElement(By.XPath("//*[@class='data']")).Text.ToString();

            while (fiRand == newRand)
            {
                driver.Navigate().Refresh();
                newRand = driver.FindElement(By.XPath("//*[@class='data']")).Text.ToString();
            }

            driver.Quit();
        }



        [TestMethod]
        public void RandNumGenOneOrTwo()
        {
            //configure test
            IWebDriver driver = new FirefoxDriver();
            string baseURL = "http://www.random.org/integers/";
            StringBuilder verificationErrors = new StringBuilder();

            //the test body
            driver.Navigate().GoToUrl(baseURL);

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
            driver.FindElement(By.XPath("//input[@value='Get Numbers']")).Click();

            string randNum =
            driver.FindElement(By.XPath("//*[@class='data']")).Text.ToString();


            if (randNum == "1")
            {

                driver.FindElement(By.LinkText("FAQ")).Click();
                try
                {
                    Assert.AreEqual("RANDOM.ORG - Frequently Asked Questions (FAQ)", driver.Title);
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
                        if ("Frequently Asked Questions (FAQ)" == driver.FindElement(By.CssSelector("h2")).Text) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }
                try
                {
                    Assert.AreEqual("Frequently Asked Questions (FAQ)", driver.FindElement(By.CssSelector("h2")).Text);
                }
                catch (Exception e)
                {
                    verificationErrors.Append(e.Message);
                }
                driver.FindElement(By.LinkText("Home")).Click();
                try
                {
                    Assert.AreEqual("RANDOM.ORG - True Random Number Service", driver.Title);
                }
                catch (Exception e)
                {
                    verificationErrors.Append(e.Message);
                }
            }
            else
            {
                driver.FindElement(By.LinkText("Home")).Click();
                try
                {
                    Assert.AreEqual("RANDOM.ORG - True Random Number Service", driver.Title);
                }
                catch (Exception e)
                {
                    verificationErrors.Append(e.Message);
                }
            }

            //close all resources
            driver.Quit();
        }
    }
}
