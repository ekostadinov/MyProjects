using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace WebDriverQaExamI.Pages
{
    public class BugTrackerPage : BasePage
    {
        //fields
        private static IWebElement bugIdTextInput;
        private static IWebElement gotoIdBtn;
        private static IWebElement errorMsgLabel;
        private static string _homePageUrl = "http://ifdefined.com/btnet/bugs.aspx";
        private static IWebElement _addNewBugBtn;
        private static IWebElement _projectTextLabel;
        private static IWebElement _projectSelect;
        private static IWebElement _projectSpecificLabel;
        private static IWebElement _projectSpecificSelect;
        

        //properties
        #region
        public static IWebElement BugIdTextInput
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@name='id']")); }
        }

        public static IWebElement GotoIdBtn
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//input[@value='go to ID']")); }
        }

        public static IWebElement ErrorMsgLabel
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//div[@class='err']")); }
        }

        public static string HomePageUrl
        {
            get { return _homePageUrl; }
        }

        public static IWebElement AddNewBugBtn
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//a[contains(text(),'add new bug')]")); }
            set { _addNewBugBtn = value; }
        }

        public static IWebElement ProjectTextLabel
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//tr[@id='row1']/td/span")); }
            set { _projectTextLabel = value; }
        }

        public static IWebElement ProjectSelect
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//select[@id='project']")); }
            set { _projectSelect = value; }
        }

        public static IWebElement ProjectSpecificLabel
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//span[@id='label_pcd1']")); }
            set { _projectSpecificLabel = value; }
        }

        public static IWebElement ProjectSpecificSelect
        {
            get { return BaseTest.BaseDriver.FindElement(By.XPath("//select[@id='pcd1']")); }
            set { _projectSpecificSelect = value; }
        }
        #endregion

        //constructors
        
        //methods
        public static bool AreAllElementShown()
        {
            Assert.IsTrue(BugIdTextInput.Displayed);
            Assert.IsTrue(GotoIdBtn.Displayed);

            return true;
        }
    }
}
