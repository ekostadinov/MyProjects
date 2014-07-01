using System.Threading;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Silverlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
//using Button = ArtOfTest.WebAii.Controls.Xaml.Wpf.Button;

namespace TestStudio_StandAlone_Skeleton
{
    /// <summary>
    /// Summary description for GotoDataFilterPage
    /// </summary>
    [TestClass]
    //public class GotoDataFilterPage : ArtOfTest.WebAii.TestTemplates.BaseTest
    public class GotoDataFilterPage : BaseTest    
    {
        private string _homePage = "http://demos.telerik.com/silverlight/";
 
        [TestMethod]
        public void GotoDemoPage()
        {
            Manager myManager = Setup(_homePage);
            myManager.ActiveBrowser.WaitUntilReady();

            NavigateToDataFilter(myManager);
            TearDown(myManager);
        }

        [TestMethod]
        public void ApplyFilter()
        {
            Manager myManager = Setup(_homePage);
            myManager.ActiveBrowser.WaitUntilReady();

            NavigateToDataFilter(myManager);

            var slApp = myManager.ActiveBrowser.SilverlightApps()[0];
            string targetQuantity = "9";

            FilterQuantity(slApp, myManager, targetQuantity);

            //check if all products are with quantity == 9
            Thread.Sleep(1000);
            int products = 0;
            int cells = 0;
            string currProduct = "Row_" + products.ToString();
            bool found = true;

            while (found)
            {
                currProduct = "Row_" + products.ToString();
                var row = slApp.Find.AllByAutomationId(currProduct);
                if (row.Count == 0)
                {
                    found = false;
                    break;
                }
                string currCell = "Cell_" + products.ToString() + "_1";
                var quantityCell = slApp.Find.ByAutomationId(currCell);
                string quantityCellText = quantityCell.Text;
                if (quantityCellText == targetQuantity)
                {
                    cells++;
                }
                products++;
            }

            Assert.AreEqual(products, cells);
            TearDown(myManager);

        }

        [TestMethod]
        public void AddDataSource()
        {
            Manager myManager = Setup(_homePage);
            myManager.ActiveBrowser.WaitUntilReady();

            var slApp = myManager.ActiveBrowser.SilverlightApps()[0];
            string targetQuantity = "9";
            string nameStartsWith = "p";
            int unitPrice = 50;

            NavigateToDataFilter(myManager);
            FilterQuantity(slApp, myManager, targetQuantity);

            // filter by name 
            var andBtn = slApp.Find.ByTextContent("And");
            Assert.AreNotEqual(null, andBtn);
            var addFilterBtn = slApp.FindName("PART_AddFilterButton");
            Assert.AreNotEqual(null, addFilterBtn);
            addFilterBtn.User.Click();
            Thread.Sleep(500);
            slApp.RefreshVisualTrees();
            var comboboxes = slApp.Find.AllByAutomationId("PART_SimpleFilterMemberComboBox");
            comboboxes[2].User.Click();
            comboboxes[2].Wait.ForVisible();
            Thread.Sleep(500);
            slApp.RefreshVisualTrees();

            var name = slApp.Find.ByTextContent("Name");
            name.User.Click();

            var filterComboboxes = slApp.Find.AllByAutomationId("PART_SimpleFilterOperatorComboBox");
            filterComboboxes[2].User.Click();
            var startsWith = slApp.Find.ByTextContent("Starts with");
            startsWith.User.Click();

            Thread.Sleep(500);

            var filterInputs = slApp.Find.AllByAutomationId("FilterEditor");
            filterInputs[2].User.Click();
            myManager.Desktop.KeyBoard.TypeText(nameStartsWith);
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);
            Assert.AreNotEqual(null, filterInputs);


            //filter by unit price
            addFilterBtn.User.Click();
            Thread.Sleep(500);
            slApp.RefreshVisualTrees();
            comboboxes = slApp.Find.AllByAutomationId("PART_SimpleFilterMemberComboBox");
            comboboxes[3].Wait.ForVisible();
            comboboxes[3].User.Click();
            Thread.Sleep(500);
            slApp.RefreshVisualTrees();

            var unitPriceFilter = slApp.Find.ByTextContent("UnitPrice");
            unitPriceFilter.User.Click();

            Thread.Sleep(500);
            comboboxes = slApp.Find.AllByAutomationId("PART_SimpleFilterOperatorComboBox");
            comboboxes[3].User.Click();
            var isLessThan = slApp.Find.ByTextContent("Is less than");
            isLessThan.User.Click();

            Thread.Sleep(500);

            filterInputs = slApp.Find.AllByAutomationId("FilterEditor");
            filterInputs[3].User.Click();
            myManager.Desktop.KeyBoard.TypeText(unitPrice.ToString());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);
            Assert.AreNotEqual(null, filterInputs);

            TearDown(myManager);
        }

        private void NavigateToDataFilter(ArtOfTest.WebAii.Core.Manager myManager)
        {
            //explore all controls btn
            var slApp = myManager.ActiveBrowser.SilverlightApps()[0];
            var exploreBtn = slApp.Find.ByTextContent("Explore all controls");
            exploreBtn.Wait.ForNoMotion(500, 10000);
            exploreBtn.User.Click();

            //verify correct page
            Thread.Sleep(3000);
            slApp.RefreshVisualTrees();
            var controls = slApp.Find.ByTextContent("Controls");
            Assert.AreNotEqual(null, controls);

            Thread.Sleep(1000);
            slApp.RefreshVisualTrees();
            var dataFilterBtn = slApp.Find.ByTextContent("DataFilter");
            //exploreBtn.Wait.ForNoMotion(500, 10000);
            dataFilterBtn.User.Click();

            //verify correct page
            Thread.Sleep(5000);
            slApp.RefreshVisualTrees();
            var otherExamples = slApp.Find.ByTextContent("Other DataFilter Examples");
            Assert.AreNotEqual(null, otherExamples);
        }

        private static void FilterQuantity(SilverlightApp slApp, Manager myManager, string targetQuantity)
        {
            var andBtn = slApp.Find.ByTextContent("And");
            Assert.AreNotEqual(null, andBtn);

            var addFilterBtn = slApp.FindName("PART_AddFilterButton");
            Assert.AreNotEqual(null, addFilterBtn);
            addFilterBtn.User.Click();

            Thread.Sleep(500);

            var quantitySelect = slApp.Find.ByTextContent("Quantity");
            Assert.AreNotEqual(null, quantitySelect);

            var isEqualToSelect = slApp.Find.ByTextContent("Is equal to");
            Assert.AreNotEqual(null, isEqualToSelect);

            var filterInput = slApp.Find.AllByAutomationId("FilterEditor");
            filterInput[1].User.Click();
            myManager.Desktop.KeyBoard.TypeText(targetQuantity);
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);
            Assert.AreNotEqual(null, filterInput);
        }

    }
}
