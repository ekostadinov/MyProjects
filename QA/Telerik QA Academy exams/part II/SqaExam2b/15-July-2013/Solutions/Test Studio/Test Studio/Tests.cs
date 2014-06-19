using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.TestAttributes;
using ArtOfTest.WebAii.TestTemplates;
using ArtOfTest.WebAii.Win32.Dialogs;

using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using ArtOfTest.WebAii.Controls.Xaml;


using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.WebAii.Controls.Xaml;
using System.Diagnostics;
using System.Threading;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for TelerikVSUnitTest1
    /// </summary>
    [TestClass]
    public class Tests : BaseTest
    {

        #region [Setup / TearDown]

        private TestContext testContextInstance = null;
        /// <summary>
        ///Gets or sets the VS test context which provides
        ///information about and functionality for the
        ///current test run.
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


        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
        }


        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            #region WebAii Initialization

            // Initializes WebAii manager to be used by the test case.
            // If a WebAii configuration section exists, settings will be
            // loaded from it. Otherwise, will create a default settings
            // object with system defaults.
            //
            // Note: We are passing in a delegate to the VisualStudio
            // testContext.WriteLine() method in addition to the Visual Studio
            // TestLogs directory as our log location. This way any logging
            // done from WebAii (i.e. Manager.Log.WriteLine()) is
            // automatically logged to the VisualStudio test log and
            // the WebAii log file is placed in the same location as VS logs.
            //
            // If you do not care about unifying the log, then you can simply
            // initialize the test by calling Initialize() with no parameters;
            // that will cause the log location to be picked up from the config
            // file if it exists or will use the default system settings (C:\WebAiiLog\)
            // You can also use Initialize(LogLocation) to set a specific log
            // location for this test.

            // Pass in 'true' to recycle the browser between test methods
            Initialize(false, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));

            // If you need to override any other settings coming from the
            // config section you can comment the 'Initialize' line above and instead
            // use the following:

            /*

            // This will get a new Settings object. If a configuration
            // section exists, then settings from that section will be
            // loaded

            Settings settings = GetSettings();

            // Override the settings you want. For example:
            settings.DefaultBrowser = BrowserType.FireFox;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(this.TestContext.WriteLine));

            */

            // Set the current test method. This is needed for WebAii to discover
            // its custom TestAttributes set on methods and classes.
            // This method should always exist in [TestInitialize()] method.
            SetTestMethod(this, (string)TestContext.Properties["TestName"]);

            #endregion

            //
            // Place any additional initialization here
            //

        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {

            //
            // Place any additional cleanup here
            //

            #region WebAii CleanUp

            // Shuts down WebAii manager and closes all browsers currently running
            // after each test. This call is ignored if recycleBrowser is set
            this.CleanUp();

            #endregion
        }

        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            // This will shut down all browsers if
            // recycleBrowser is turned on. Else
            // will do nothing.
            ShutDown();
        }

        #endregion


        [TestMethod]
        public void CreateRenameDeleteTreeViewItem()
        {

            // Set settings and Launch a browser instance 
            Manager.Settings.Web.EnableSilverlight = true;
            Manager.Settings.ExecutionDelay = 0;
            Manager.Settings.AnnotateExecution = false;
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);

            // Navigate to home page 
            ActiveBrowser.NavigateTo("http://demos.telerik.com/silverlight/");

            // Click all controls 
            var slApp = ActiveBrowser.SilverlightApps()[0];
            var button = slApp.Find.ByTextContent("Explore all controls");
            button.Wait.ForNoMotion(500, 10000); 
            button.User.Click();

            // Go to Context Menu demos 
            slApp.Find.ByTextContent("Context Menu").User.Click();

            // Verify I'm on the correct demo 
            var panel = slApp.Find.ByName<StackPanel>("labelsPanel");
            Assert.AreEqual("Context Menu First Look", panel.TextBlockContent);

            // Go to RadTreeVIew Integration demo 
            var chooserDropDown = slApp.Find.ByName<RadDropDownButton>("allExamplesChooser");
            chooserDropDown.User.Click();
            slApp.Find.ByTextContent("RadTreeView Integration").User.Click();

            // Verify I'm on the correct demo 
            Assert.AreEqual("Context Menu RadTreeView Integration", panel.TextBlockContent);    
            
            var tree = slApp.Find.ByType<RadTreeView>();

            // Create child Item of Inbox(14)
            var inbox = tree.Find.AllByType<RadTreeViewItem>().Where(i => i.Text == "Inbox(14)").FirstOrDefault();
            inbox.User.Click(MouseClickType.RightClick);
            slApp.Find.ByTextContent("New Child").User.Click();

            // Edit(rename) the Item
            tree.Find.ByTextContent("New Child").User.Click(MouseClickType.RightClick);
            slApp.Find.ByTextContent("Edit").User.Click();

            Manager.Current.Desktop.KeyBoard.TypeText("RenamedItem", 50);
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            // VErify item is renamed
            Assert.IsTrue(tree.Find.AllByType<RadTreeViewItem>().Where(i => i.Text == "RenamedItem").Count() == 1);

            // Delte Item
            var renameditem = tree.Find.AllByType<RadTreeViewItem>().Where(i => i.Text == "RenamedItem").FirstOrDefault();
            renameditem.User.Click(MouseClickType.RightClick);
            slApp.Find.ByTextContent("Delete").User.Click();

            slApp.RefreshVisualTrees();
            Assert.IsTrue(tree.Find.AllByTextContent("RenamedItem").Count() == 0);
        }

        [TestMethod]
        public void SelectTreeViewItem()
        {
            Manager.Settings.Web.EnableSilverlight = true;
            Manager.Settings.ExecutionDelay = 0;
            Manager.Settings.AnnotateExecution = false;
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);
            ActiveBrowser.NavigateTo(@"http://demos.telerik.com/silverlight/#ContextMenu/TreeViewIntegration");
            var slApp = ActiveBrowser.SilverlightApps()[0];
            var tree = slApp.Find.ByType<RadTreeView>();

            // Select Outbox
            var outbox = tree.Find.AllByType<RadTreeViewItem>().Where(i => i.Text == "Outbox").FirstOrDefault();
            outbox.User.Click(MouseClickType.RightClick);
            slApp.Find.ByTextContent("Select").User.Click();

            // Verify isSelected
            Assert.IsTrue(outbox.IsSelected);
        }
    }
}