using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using QaExamIb;

namespace WebDriverQaExamI.Pages
{
    public class GooglePage : BasePage
    {
        //fields
        private static string _homePageUrl = "http://www.google.com/";
        
        //properties
        #region
        public static IWebElement LoginBtn
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//div[3]/div/a")); }
        }

        public static string HomePageUrl
        {
            get { return _homePageUrl; }
        }

        public static IWebElement EmailInput
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@id='Email']")); }
        }

        public static IWebElement PasswordInput
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@id='Passwd']")); }            
        }

        public static IWebElement SigninBtn
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@id='signIn']")); }
        }

        public static IWebElement ProfileMenu
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//div[@id='gb']/div/div/div[2]/div[5]/div/a/span")); }
        }

        public static IWebElement ProfileLabel
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//div[@id='gb']/div/div/div[2]/div[5]/div[2]/div/div/div[2]")); }
        }

        public static IWebElement OptionsImgBtn
        {
            get { return BaseTest.BaseDriver.FindElement(
                By.XPath("//a[@href='http://www.google.bg/intl/bg/options/']"));
            }
        }

        public static IWebElement CalendarImgBtn
        {
            get
            {
                return BaseTest.BaseDriver.FindElement(By.XPath("//li[7]/a/span"));
            }
        }

        public static IWebElement NewEventImgBtn
        {
            get
            {
                return BaseTest.BaseDriver.FindElement(By.XPath("//div[@id='sidebar']/div/div/div/div/div/div[2]"));
            }
        }

        public static IWebElement NewEventInput
        {
            get
            {
                return BaseTest.BaseDriver.FindElement(By.XPath("//div[@id='coverinner']/div/div[2]/input"));
            }
        }

        public static IWebElement NewEventTimeInput
        {
            get
            {
                return BaseTest.BaseDriver.FindElement(By.XPath("//input[@id=':1u-st']"));
            }
        }

        public static IWebElement SaveEventBtn
        {
            get
            {
                return BaseTest.BaseDriver.FindElement(By.XPath("//div[@id=':1p.save_top']/div/div/div/div/div[2]"));
            }
        }
        #endregion

        //constructors

        //methods
        public static bool AreAllElementShown()
        {
            Assert.IsTrue(LoginBtn.Displayed);
        
            return true;
        }

        public static void LogoutProfile(string profile)
        {
            Assert.IsTrue(GooglePage.ProfileMenu.Displayed);
            if (ProfileLabel.Text != profile)
            {
                ProfileMenu.Click();
            }
            
            BaseTest.BaseDriver.FindElement(By.XPath("//a[contains(text(),'Изход')]")).Click();
            
        }
    }
}
