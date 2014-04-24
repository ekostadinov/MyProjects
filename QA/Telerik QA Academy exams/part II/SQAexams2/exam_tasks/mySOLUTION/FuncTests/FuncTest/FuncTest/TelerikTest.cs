using System;
using System.Globalization;
using DBServer.Selenium.Silvernium.Fixtures;
using NUnit.Framework;
using System.Windows.Automation;
using System.Windows.Automation.Text;
using System.Diagnostics; // for Process
using System.Threading; // for Thread.Sleep()
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Selenium;
using ThoughtWorks.Selenium.Silvernium;
using Telerik.WebAii;
using Telerik.WebAii.Controls;

namespace FuncTest
{
    [TestClass]
    public class TelerikTest
    {
        //fields
        #region
        private const string URL = "http://demos.telerik.com/silverlight/";
        private const string OBJECTID = "SilverlightControl";
        private const string SCRIPTKEY = "SilverNibbles";
        private ISelenium selenium;
        //private Silvernium silvernium;
        private IWebDriver driver;

        #endregion
        //properties
        #region
        #endregion

        //constructors
        #region
        #endregion

        //methods
        #region
        //[SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            selenium = new WebDriverBackedSelenium(driver, URL);
            selenium.Start();
            selenium.Open(URL);
            driver.Navigate().GoToUrl(URL);
            //silvernium = new Silvernium(selenium, OBJECTID, SCRIPTKEY);
        }

        //[TearDown]
        public void TearDown()
        {
            selenium.Stop();
        }


        [TestMethod]
        public void NavigateToPage()
        {
            
            SetUp();

            AutomationElement aeDesktop = null;
            aeDesktop = AutomationElement.RootElement;

            Thread.Sleep(25000);

            AutomationElement firefox = null;
            firefox = aeDesktop.FindFirst(TreeScope.Children,
                new PropertyCondition(AutomationElement.NameProperty,
                    "Silverlight 5 Controls Examples - GridView, ChartView, ScheduleView, RichTextBox, Map, Code Samples - Mozilla Firefox"));

            AutomationElementCollection aeWindows = null;
            aeWindows = firefox.FindAll(TreeScope.Descendants,
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window));
           
            AutomationElement firefoxPage = null;
            firefoxPage = aeWindows[1];
            Thread.Sleep(2000);

            AutomationElementCollection aeBtns = null;
            aeBtns = firefox.FindAll(TreeScope.Descendants,
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Button));
           
            AutomationElement allControlsLink = null;
            allControlsLink = 
            SilverlightPage.WaitForElementByName(allControlsLink, 20, firefoxPage, "EXPLORE ALL CONTROLS");

            InvokePattern clickLink = (InvokePattern)allControlsLink.GetCurrentPattern(InvokePattern.Pattern);
            clickLink.Invoke();

            Thread.Sleep(10000);

            //next page - all controls
            AutomationElementCollection aeWindowsNew = null;
            aeWindowsNew = firefox.FindAll(TreeScope.Descendants,
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window));

            AutomationElement firefoxPageNew = null;
            firefoxPageNew = aeWindowsNew[1];

            AutomationElementCollection aeBtnsNew = null;
            aeBtnsNew = firefoxPageNew.FindAll(TreeScope.Descendants,
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Button));

            AutomationElement dataFilterBtn = aeBtnsNew[24];
            InvokePattern clickdataFilterBtn = (InvokePattern)dataFilterBtn.GetCurrentPattern(InvokePattern.Pattern);
            clickdataFilterBtn.Invoke();

            Thread.Sleep(10000);


            //next page - data filter
            AutomationElementCollection aeWindowsNext = null;
            aeWindowsNext = firefox.FindAll(TreeScope.Descendants,
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window));

            AutomationElement firefoxPageNext = null;
            firefoxPageNext = aeWindowsNext[1];
            
            AutomationElement ordersLabel = null;
            ordersLabel = SilverlightPage.WaitForElementByName(ordersLabel, 15, firefoxPageNext,"Orders");

            //unsupported pattern - maybe for this cind of element [textblock]
            //TextPattern ordersText = (TextPattern)ordersLabel.GetCurrentPattern(TextPattern.Pattern);
            //string actualOrdersText = ordersText.DocumentRange.GetText(-1);
            //string expectedOrdersText = "Orders";
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedOrdersText, actualOrdersText);

            AutomationElement radGrid = null;
            radGrid = SilverlightPage.WaitForElementByName(radGrid, 10, firefoxPageNext, "radDataFilter");

            AutomationElement filterControl = null;
            filterControl = SilverlightPage.WaitForElementByName(filterControl, 10, radGrid, "FilterControl_R");

            AutomationElement addFilter = null;
            addFilter = SilverlightPage.WaitForElementByName(addFilter, 10, filterControl, "PART_AddFilterButton");

            InvokePattern clickAddFilterBtn = (InvokePattern)addFilter.GetCurrentPattern(InvokePattern.Pattern);
            clickAddFilterBtn.Invoke();

            AutomationElement myFilter = null;
            myFilter = SilverlightPage.WaitForElementByName(myFilter, 10, radGrid, "FilterControl_R0");

            AutomationElementCollection comboBoxes = null;
            comboBoxes = myFilter.FindAll(TreeScope.Descendants,
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ComboBox));

            //first combobox
            AutomationElement radComboBox = null;
            radComboBox = comboBoxes[0];

            //InvokePattern clickRadComboBox = (InvokePattern)radComboBox.GetCurrentPattern(InvokePattern.Pattern);
            //clickRadComboBox.Invoke();

            //select quantity item
            AutomationElement quantityComboBoxItem = null;
            quantityComboBoxItem = SilverlightPage.WaitForElementByName(quantityComboBoxItem, 10, radComboBox, "Quantity");

            //InvokePattern clickQuantityItem = (InvokePattern)quantityComboBoxItem.GetCurrentPattern(InvokePattern.Pattern);
            //clickQuantityItem.Invoke();

            //second combobox
            AutomationElement radComboBoxNext = null;
            radComboBoxNext = comboBoxes[1];

            //InvokePattern clickRadComboBoxNext = (InvokePattern)radComboBoxNext.GetCurrentPattern(InvokePattern.Pattern);
            //clickRadComboBoxNext.Invoke();

            //select isEqualTo item
            AutomationElement isEqualTo = null;
            isEqualTo = SilverlightPage.WaitForElementByName(isEqualTo, 10, radComboBoxNext, "IsEqualTo");

            //InvokePattern clickisEqualToItem = (InvokePattern)isEqualTo.GetCurrentPattern(InvokePattern.Pattern);
            //clickisEqualToItem.Invoke();

            //input quantity 
            AutomationElement input = null;
            input = myFilter.FindFirst(TreeScope.Descendants,
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));
            
            //set quantity to '9'
            


            TearDown();

        }
        #endregion


    }
}
