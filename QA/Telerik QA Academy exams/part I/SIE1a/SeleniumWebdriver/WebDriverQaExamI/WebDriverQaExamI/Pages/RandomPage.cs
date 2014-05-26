using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace WebDriverQaExamI.Pages
{
    class RandomPage : BasePage
    {
        //fields
        private static string _homePageUrl = "http://www.random.org/integers/";

        //properties
        #region
        public static string HomePageUrl
        {
            get { return _homePageUrl; }
        }

        public static IWebElement NumbersCountInput
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@name='num']")); }
        }

        public static IWebElement MinNumbersInput
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@name='min']")); }
        }

        public static IWebElement MaxNumbersInput
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@name='max']")); }
        }

        public static IWebElement GetNumbersBtn
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@value='Get Numbers']")); }
        }

        public static IWebElement GeneratedNumber
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//div[@id='invisible']/pre")); }
        }

        public static IWebElement HomePageLink
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//a[contains(text(),'Home')]"));}
        }

        public static IWebElement LearnMoreLink
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//a[contains(text(),'Learn More')]")); }
        }

        public static IWebElement LearnMoreNavLink
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//ul[@id='navigation']/li[9]/ul/li[3]/a")); }
        }
        #endregion

        //constructors

        //methods
        public static bool AreAllElementShown()
        {
            Assert.IsTrue(NumbersCountInput.Displayed);
            Assert.IsTrue(MinNumbersInput.Displayed);
            Assert.IsTrue(MaxNumbersInput.Displayed);
            Assert.IsTrue(GetNumbersBtn.Displayed);

            return true;
        }
    }
}
