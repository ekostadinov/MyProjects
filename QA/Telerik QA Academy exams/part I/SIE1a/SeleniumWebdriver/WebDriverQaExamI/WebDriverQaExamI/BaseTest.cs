using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Selenium;

namespace WebDriverQaExamI
{
    public abstract class BaseTest
    {
        //fields
        private static IWebDriver _baseDriver;
        private static WebDriverBackedSelenium _selenium;
        private static string _baseUrl;

        //properties
        public static IWebDriver BaseDriver
        {
            get{ return _baseDriver; }
            set { _baseDriver = value; }
        }

        public static WebDriverBackedSelenium Selenium
        {
            get { return _selenium; }
            set { _selenium = value; }
        }
        
        public static string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        //constructors

        //methods
        public static void Setup(string url)
        {
            //FirefoxProfile profile = new FirefoxProfile(@"C:\Users\User\Documents\GitHub\MyProjects\QA\Telerik QA Academy exams\part I\SIE1a\SeleniumWebdriver");

            BaseDriver = new FirefoxDriver();
            //new FirefoxDriver(profile);
            //new ChromeDriver(@"D:\software\selenium\chrome");
            //new InternetExplorerDriver(@"D:\software\selenium\ie");
            Selenium = new WebDriverBackedSelenium(BaseDriver, BaseUrl);
            
            //Selenium.Start();
            BaseDriver.Navigate().GoToUrl(url);
            BaseDriver.Manage().Window.Maximize();
        }

        public static void TearDown()
        {
            //Selenium.Close();
            BaseDriver.Close();
            BaseDriver.Quit();
        }

       
    }
}
