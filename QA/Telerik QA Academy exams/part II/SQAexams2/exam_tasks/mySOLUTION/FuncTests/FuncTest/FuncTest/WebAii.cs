using System;
using System.Text;
using System.Collections.Generic;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using DBServer.Selenium.Silvernium.Fixtures;
//using NUnit.Framework;
using System.Windows.Automation;
using System.Windows.Automation.Text;
using System.Diagnostics; // for Process
using System.Threading; // for Thread.Sleep()
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Selenium;
using ThoughtWorks.Selenium.Silvernium;
using Telerik.WebAii;
using Telerik.WebAii.Controls;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Button = ArtOfTest.WebAii.Controls.Xaml.Wpf.Button;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;


namespace FuncTest
{
    /// <summary>
    /// Summary description for WebAii
    /// </summary>
    [TestClass]
    public class WebAii
    {
        private Browser browser { get; set; }
        private const string URL = "http://demos.telerik.com/silverlight/";
       
        public WebAii()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        public void SetUp()
        {
            //Settings.Current.Web.EnableSilverlight = true;
            Settings.WebSettings web = new Settings.WebSettings();
            Settings.WpfSettings wpf = new Settings.WpfSettings();
            Settings set = new Settings(web, wpf);
            Manager man = new Manager(false);
            man.Start();
            
            Manager.Current.LaunchNewBrowser();
            browser = Manager.Current.ActiveBrowser;

           
        }

        public void TearDown()
        {
            browser.Close();
        }
        
        [TestMethod]
        public void TestWeb()
        {
            Settings mySettings = new Settings();
            mySettings.Web.DefaultBrowser = BrowserType.FireFox;
            mySettings.Web.EnableSilverlight = true;
            Manager myManager = new Manager(mySettings);
            myManager.Start();
            myManager.LaunchNewBrowser();
            // Navigate to the page
            //myManager.ActiveBrowser.NavigateTo(URL, false);
            
            // Launch a browser instance
            browser = Manager.Current.ActiveBrowser;
            browser.NavigateTo(URL, false);
            browser.WaitUntilReady();
            var aframes = browser.Frames;
            var adesktop = browser.Desktop;
            var time = browser.CommandTimeOut;
            var tree = browser.DomTree;
            var nodes = tree.Root.ChildNodes;
            var child = tree.Root.Children;



            // Get an instance of our Silverlight app.
            SilverlightApp app = browser.SilverlightApps()[0];

            var xmllist = app.Find.AllByType<Button>();
            var uilist = app.Find.AllByType<ArtOfTest.WebAii.Silverlight.UI.Button>();
            var idlist = app.Find.AllByAutomationId("radButton");
            
            var byname = app.Find.AllByName("EXPLORE ALL CONTROLS");
            var text = app.Find.AllByTextContent("EXPLORE ALL CONTROLS");
            app.RefreshVisualTrees();
            

            // Click the button
            var btn = app.FindName<ArtOfTest.WebAii.Silverlight.UI.Button>("EXPLORE ALL CONTROLS");
            btn.User.Click();
            
            // Verify the text
           
        }
    }
}
