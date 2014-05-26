using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace WebDriverQaExamI.Pages
{
    class MagentoPage : BasePage
    {
        //fields
        private static string _homePageUrl = "http://demo.koongo.com/";

        //properties
        #region
        public static IWebElement MyAccountBtn
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//a[contains(text(),'My Account')]")); }
        }

        public static string HomePageUrl
        {
            get { return _homePageUrl; }
        }

        public static IWebElement RegisteredCustomersLabel
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//form[@id='login-form']/div/div[2]/div/h2")); }
        }
        
        public static IWebElement EmailAdressLabel
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//form[@id='login-form']/div/div[2]/div/ul/li/label")); }
        }

        public static IWebElement EmailAdressInput
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@id='email']")); }
        }

        public static IWebElement PasswordLabel
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//form[@id='login-form']/div/div[2]/div/ul/li[2]/label")); }
        }

        public static IWebElement PasswordInput
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@id='pass']")); }
        }

        public static IWebElement LoginBtn2
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//button[@id='send2']")); }
        }

        public static IWebElement ErrorMsgLabel
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//li/span")); }
        }

        public static IWebElement EmptyEmailLabel
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//div[@id='advice-required-entry-email']")); }
        }

        public static IWebElement EmptyPassLabel
        {
            get
            {
                return BaseTest.BaseDriver.FindElement(By.XPath("//div[@id='advice-required-entry-pass']"));
            }
        }
        #endregion

        //constructors

        //methods
        public static bool AreAllElementShown()
        {
            Assert.IsTrue(MyAccountBtn.Displayed);

            return true;
        }

    }
}
