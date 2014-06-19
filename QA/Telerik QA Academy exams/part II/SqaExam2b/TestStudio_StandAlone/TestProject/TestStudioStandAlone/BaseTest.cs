using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Core;

namespace TestStudioStandAlone
{
    public class BaseTest
    {
        public Manager Setup(String _homePage)
        {
            // Initialize the settings
            Settings mySettings = new Settings();

            // Set the default browser + Silverlight
            mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;
            mySettings.Web.EnableSilverlight = true;
            mySettings.ExecutionDelay = 0;
            mySettings.AnnotateExecution = false;

            // Create the manager object
            Manager myManager = new Manager(mySettings);

            // Start the manager
            myManager.Start();

            // Launch a new browser instance. [This will launch an IE instance given the setting above]
            myManager.LaunchNewBrowser();

            // Navigate to a certain web page
            myManager.ActiveBrowser.NavigateTo(_homePage);

            return myManager;
        }

        public void TearDown(Manager myManager)
        {
            // Shut-down the manager and do all clean-up
            myManager.Dispose();
        }

    }
}
