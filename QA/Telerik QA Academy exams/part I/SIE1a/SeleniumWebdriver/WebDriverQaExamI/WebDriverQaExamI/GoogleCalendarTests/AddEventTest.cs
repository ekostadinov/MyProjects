using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriverQaExamI.Pages;

namespace WebDriverQaExamI.GoogleCalendarTests
{
    [TestClass]
    public class AddEventTest
    {
        [TestMethod]
        public void AddEvent()
        {
            GoogleLoginTest.LoginProfile();

            string calendarEvent = "Meeting 8 pm today";
            AddNewCalendarEvent(calendarEvent);

            BaseTest.TearDown();
        }

        public void AddNewCalendarEvent(string eventName)
        {
            // options img btn
            Assert.IsTrue(GooglePage.OptionsImgBtn.Displayed);
            GooglePage.OptionsImgBtn.Click();
            // calendar img btn
            Thread.Sleep(1000);
            
            Assert.IsTrue(GooglePage.CalendarImgBtn.Displayed);
            GooglePage.CalendarImgBtn.Click();
            
            // calendar page
            WebDriverWait wait = new WebDriverWait(BaseTest.BaseDriver, TimeSpan.FromSeconds(5));
            wait.Until((d) => { return d.Title.StartsWith("Google Календар"); });

            // new event img btn
            Assert.IsTrue(GooglePage.NewEventImgBtn.Displayed);
            GooglePage.NewEventImgBtn.Click();
            
            Thread.Sleep(1500);
            
            Assert.IsTrue(GooglePage.NewEventInput.Displayed);
            GooglePage.NewEventInput.Clear();
            GooglePage.NewEventInput.SendKeys(eventName);

            Assert.IsTrue(GooglePage.NewEventTimeInput.Displayed);
            GooglePage.NewEventTimeInput.Clear();
            GooglePage.NewEventTimeInput.SendKeys("20:00");

            Assert.IsTrue(GooglePage.SaveEventBtn.Displayed);
            GooglePage.SaveEventBtn.Click();

            // calendar page
            IList<IWebElement> cells = BaseTest.BaseDriver.FindElements(By.XPath("//div//div/dl/dd/span"));

            bool hasEventRecord = false;
            foreach (var cell in cells)
            {
                //find event
                if (eventName == cell.Text)
                {
                    hasEventRecord = true;
                    break;
                }                
            }
            Assert.IsTrue(hasEventRecord);

            //delete event
            Thread.Sleep(1500);
            IList<IWebElement> ddList = BaseTest.BaseDriver.FindElements(By.XPath("//div//div/dl/dd"));
            foreach (var dd in ddList)
            {
                //find event
                if (eventName == dd.Text)
                {
                    dd.Click();
                    IWebElement deleteLink = BaseTest.BaseDriver.FindElement(By.XPath("//div[@id='bubbleContent:e']//a"));
                    deleteLink.Click();
                    break;
                }
            }
            Thread.Sleep(1000);
            try
            {
                IWebElement deleteBtn = BaseTest.BaseDriver.FindElement(By.XPath("//div[contains(text(), 'Изтриване')]"));
                deleteBtn.Click();                                
            }
            catch (NoSuchElementException nsee)
            {
             //do nothing if no such btn   
            }

            //IList<IWebElement> dlList = BaseTest.BaseDriver.FindElements(By.XPath("//div//div/dl"));
            //foreach (var dl in dlList)
            //{
            //    IWebElement span = BaseTest.BaseDriver.FindElement(By.XPath("//span"));
            //    //find event
            //    if ("Meeting 8 pm today" == span.Text)
            //    {
            //        dl.Click();
            //        break;
            //    }
            //}

            string expectedProfile = "testqaexam@gmail.com";
            GooglePage.LogoutProfile(expectedProfile);    
           

            }

    }
}
