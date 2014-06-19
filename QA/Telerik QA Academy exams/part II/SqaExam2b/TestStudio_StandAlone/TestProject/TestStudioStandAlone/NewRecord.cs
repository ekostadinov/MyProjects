using System;
using ArtOfTest.WebAii.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestStudioStandAlone
{
    [TestClass]
    public class NewRecord : BaseTest
    {
        private string _homePage = "http://localhost:6464/";
        
        [TestMethod]
        public void TestMethod1()
        {
            Manager myManager = Setup(_homePage);
            myManager.ActiveBrowser.WaitUntilReady();

            //create record

            TearDown(myManager);
        }
    }
}
