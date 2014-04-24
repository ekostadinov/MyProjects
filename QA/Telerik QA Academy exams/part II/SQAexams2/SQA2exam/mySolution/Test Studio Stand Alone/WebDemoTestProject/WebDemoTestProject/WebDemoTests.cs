using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.TestTemplates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebDemoTestProject
{
    /// <summary>
    /// Summary description for WebDemoTests
    /// </summary>
    [TestClass]
    public class WebDemoTests : BaseTest
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
            settings.Web.DefaultBrowser = BrowserType.FireFox;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(this.TestContext.WriteLine));

            */

            // Set the current test method. This is needed for WebAii to discover
            // its custom TestAttributes set on methods and classes.
            // This method should always exist in [TestInitialize()] method.
            SetTestMethod(this, (string)TestContext.Properties["TestName"]);

            #endregion

            // Launch a browser instance
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);

            // Navigate the active browser
            ActiveBrowser.NavigateTo(
                TelerikWebDemoPage.PageUrl);
   

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
        public void AddProduct()
        {
           
            //add product
            #region
            var addProductBtn =
            Find.ByName<HtmlInputButton>("RadGrid1$ctl00$ctl02$ctl00$AddNewRecordButton");
            while (addProductBtn == null)
            {
                 addProductBtn =
                    Find.ByName<HtmlInputButton>("RadGrid1$ctl00$ctl02$ctl00$AddNewRecordButton");
                Thread.Sleep(1000);
            }
            addProductBtn.Click();

            var productNameInput = Find.ByName<HtmlInputText>("RadGrid1$ctl00$ctl02$ctl04$TB_ProductName");
            while (productNameInput == null)
            {
                Manager.Desktop.KeyBoard.KeyPress(Keys.F5, 500);
                Thread.Sleep(1000);
                addProductBtn.Click();
                Thread.Sleep(1000);
                productNameInput = Find.ByName<HtmlInputText>("RadGrid1$ctl00$ctl02$ctl04$TB_ProductName");
            }
            //productNameInput.Text = "Product1";
            //productNameInput.Text = "Product2";
            productNameInput.Text = "Product3";

            var unitPriceInput = Find.ByName<HtmlInputText>("RadGrid1$ctl00$ctl02$ctl04$RNTB_UnitPrice");
            unitPriceInput.Focus();
            unitPriceInput.Click();
            unitPriceInput.MouseClick(MouseClickType.LeftClick);
            //Manager.Desktop.KeyBoard.KeyPress(Keys.NumPad1, 500);
            //Manager.Desktop.KeyBoard.KeyPress(Keys.NumPad2, 500);
            Manager.Desktop.KeyBoard.KeyPress(Keys.NumPad3, 500);            
            var plusBtn = Find.ByName<HtmlInputControl>("RadGrid1$ctl00$ctl02$ctl04$PerformInsertButton");
            plusBtn.Focus();
            plusBtn.Click();
            #endregion


        }

        [TestMethod]
        public void FilterByProductName()
        {
            
            //filter products by name
            #region

            FilterProductsByName("Product");

            #endregion

            //verify footer count
            #region
            Thread.Sleep(1000);

            string footerXPath = "//tr[@class='rgFooter']";
            var footerCount = Find.ByXPath<HtmlTableCell>(footerXPath + "//td");
            string footerCountStr = footerCount.InnerText.ToString();
            string expectedFooterCount = "Count : 3";
            Assert.AreEqual(expectedFooterCount, footerCountStr);
            #endregion

            //verify correct first element
            #region
            var footerFirstProduct = Find.ByXPath<HtmlTableCell>(footerXPath + "//td[2]");
            string footerFirstProductStr = footerFirstProduct.InnerText;
            string expectedfooterFirstProductStr = "First : Product1";
            Assert.AreEqual(expectedfooterFirstProductStr, footerFirstProductStr);
            #endregion

            //verify footer sum
            #region
            var footerSum = Find.ByXPath<HtmlTableCell>(footerXPath + "//td[3]");
            string footerSumStr = footerSum.InnerText;

            var firstProductPrice = Find.ByXPath<HtmlTableCell>("//tr[@id='RadGrid1_ctl00__0']//td[3]");
            string firstProductPriceStr = firstProductPrice.InnerText;

            var secondProductPrice = Find.ByXPath<HtmlTableCell>("//tr[@id='RadGrid1_ctl00__1']//td[3]");
            string secondProductPriceStr = secondProductPrice.InnerText;

            var thirdProductPrice = Find.ByXPath<HtmlTableCell>("//tr[@id='RadGrid1_ctl00__2']//td[3]");
            string thirdProductPriceStr = thirdProductPrice.InnerText;

            double footerSumInt = ExtractDouble(footerSumStr);
            double firstProductPriceInt = ExtractDouble(firstProductPriceStr);
            double secondProductPriceInt = ExtractDouble(secondProductPriceStr);
            double thirdProductPriceInt = ExtractDouble(thirdProductPriceStr);

            bool sumPrices = footerSumInt == (firstProductPriceInt + secondProductPriceInt + thirdProductPriceInt);
            Assert.IsTrue(sumPrices);
            #endregion
        }

        [TestMethod]
        public void VerifyEditingProducts()
        {
            var resetState = Find.ById<HtmlInputButton>("Button1");
            while(resetState == null)
            {
                Thread.Sleep(2000);
                resetState = Find.ById<HtmlInputButton>("Button1");
            }

            //find elements
            #region

            //select the row for the Edit btn
            int row = 1;
            var editBtn = ReturnEditBtn(row);
            editBtn.MouseClick();

            Thread.Sleep(1000);

            //selected row for the Edit product name
            var editNameInput = ReturnEditNameInput(row);
            string editNameInputStr = editNameInput.Text;
            
            //selected row for Edit price
            var editPriceInput = ReturnPriceInput();
           
            //find apply/deny changes btns
            var applyChangesBtn = ReturnApplyChangesBtn();
            var denyChangesBtn = ReturnDenyChangesBtn();

            //find product price for selected row
            string currProductPrice = ReturnProductPrice(row);
            #endregion

            //logic for different behaviour
            #region
            Random rand = new Random();
            int randNum = rand.Next(1, 7);
            string expectedName = string.Empty;
            string productPrice = string.Empty;
            string expectedPrice = string.Empty;
            switch (randNum)
            {
                // apply new product name
                case 1:
                    editNameInput.Text = editNameInputStr + "-Edit";
                    expectedName = editNameInput.Text;
                    applyChangesBtn.Click();
                    Thread.Sleep(1000);
                    FilterProductsByName(expectedName);
                    productPrice = ReturnProductPrice(row);
                    Assert.IsTrue( ResultsAreFound(expectedName, productPrice) );
                    resetState.Click();
                    return;
                //deny changes new product name
                case 2:
                    editNameInput.Text = editNameInputStr + "-Edit";
                    expectedName = editNameInput.Text;
                    denyChangesBtn.Click();
                    Thread.Sleep(1000);
                    FilterProductsByName(expectedName);
                    productPrice = ReturnProductPrice(row);
                    Assert.IsFalse(ResultsAreFound(expectedName, productPrice));
                    resetState.Click();
                    return;
                //apply new product price
                case 3:
                    expectedPrice = "7,00 лв.";
                    editPriceInput.Focus();
                    editPriceInput.MouseClick(MouseClickType.LeftClick);
                    editPriceInput.Text = "";
                    Manager.Desktop.KeyBoard.KeyPress(Keys.NumPad7, 500);
                    expectedName = editNameInput.Text;
                    applyChangesBtn.Click();
                    Thread.Sleep(1000);
                    FilterProductsByName(expectedName);
                    productPrice = ReturnProductPrice(row);
                    Assert.IsTrue(ResultsAreFound(expectedPrice, productPrice));
                    resetState.Click();
                    return;
                //deny changes new product price
                case 4:
                    expectedPrice = "7,00 лв";
                    editPriceInput.Focus();
                    editPriceInput.MouseClick(MouseClickType.LeftClick);
                    editPriceInput.Text = "";
                    Manager.Desktop.KeyBoard.KeyPress(Keys.NumPad7, 500);
                    expectedName = editNameInput.Text;
                    denyChangesBtn.Click();
                    Thread.Sleep(1000);
                    FilterProductsByName(expectedName);
                    productPrice = ReturnProductPrice(row);
                    //assert must be .istrue to the old price has not been changed!
                    Assert.IsFalse(ResultsAreFound(expectedPrice, productPrice));
                    resetState.Click();
                    return;
                //apply new product name and price
                case 5:
                    editNameInput.Text = editNameInputStr + "-Edit";
                    expectedName = editNameInput.Text;
                    expectedPrice = "7,00 лв.";
                    editPriceInput.Focus();
                    editPriceInput.MouseClick(MouseClickType.LeftClick);
                    editPriceInput.Text = "";
                    Manager.Desktop.KeyBoard.KeyPress(Keys.NumPad7, 500);
                    applyChangesBtn.Click();
                    Thread.Sleep(1000);
                    FilterProductsByName(expectedName);
                    Assert.IsTrue(ResultsAreFound(expectedName, expectedPrice));
                    resetState.Click();
                    return;
                //deny changes new product name and price
                case 6:
                    editNameInput.Text = editNameInputStr + "-Edit";
                    expectedName = editNameInput.Text;
                    expectedPrice = "7,00 лв.";
                    editPriceInput.Focus();
                    editPriceInput.MouseClick(MouseClickType.LeftClick);
                    editPriceInput.Text = "";
                    Manager.Desktop.KeyBoard.KeyPress(Keys.NumPad7, 500);
                    denyChangesBtn.Click();
                    Thread.Sleep(1000);
                    FilterProductsByName(expectedName);
                    Assert.IsFalse(ResultsAreFound(expectedName, expectedPrice));
                    resetState.Click();
                    return;
                default:
                    throw new IndexOutOfRangeException("Rand number is not in the range! Check YOUR logic.");
            }

            #endregion
        }

        [TestMethod]
        public void VerifyDeletingProducts()
        {
            var resetState = Find.ById<HtmlInputButton>("Button1");
            while (resetState == null)
            {
                Thread.Sleep(2000);
                resetState = Find.ById<HtmlInputButton>("Button1");
            }

            //select the row for the Delete btn
            int row = 1;
            string expectedName = ReturnDeletedProductName(row);
            string expectedPrice = ReturnProductPrice(row);
            var deleteBtn = ReturnDeleteBtn(row);
            deleteBtn.MouseClick();

            Thread.Sleep(500);

            Manager.Desktop.KeyBoard.KeyPress(Keys.Enter, 500);

            Thread.Sleep(1000);

            FilterProductsByName(expectedName);

            Assert.IsFalse( ResultsAreFound(expectedName, expectedPrice) );

            //resetState.Click();
        }

        private string ReturnDeletedProductName(int row)
        {
            string xpath = "//table[@id='RadGrid1_ctl00']/tbody/tr[" + row.ToString() + "]/td[2]";
            var cell = Find.ByXPath<HtmlTableCell>(xpath);
            string name = cell.InnerText;

            return name;
        }
        
        private string ReturnProductPrice(int row)
        {
            string xpath = "//table[@id='RadGrid1_ctl00']/tbody/tr[" + row.ToString() + "]/td[3]";
            var product = Find.ByXPath<HtmlTableCell>(xpath);
            string price = product.InnerText;
            return price;
        }

        private bool ResultsAreFound(string expectedName, string expectedPrice)
        {
            bool isNameFound = false;
            var resultsNames = Find.AllByXPath<HtmlTableCell>("//table[@id='RadGrid1_ctl00']/tbody/tr/td[2]");
            foreach (var cell in resultsNames)
            {
                if (cell.InnerText == expectedName)
                {
                    isNameFound = true;
                }
            }

            bool isPriceFound = false;
            var resultsPrices = Find.AllByXPath<HtmlTableCell>("//table[@id='RadGrid1_ctl00']/tbody/tr/td[3]");
            foreach (var cell in resultsPrices)
            {
                if (cell.InnerText == expectedPrice)
                {
                    isPriceFound = true;
                }
            }

            bool result = isNameFound && isPriceFound;
            return result;
        }

        private void FilterProductsByName(string expectedName)
        {
            var productNameInput = Find.ByName<HtmlInputText>("RadGrid1$ctl00$ctl02$ctl03$FilterTextBox_ProductName");
            Thread.Sleep(1000);
            productNameInput.MouseClick();
            productNameInput.Text = expectedName;

            var byNameFilterBtn = Find.ByName<HtmlInputControl>("RadGrid1$ctl00$ctl02$ctl03$Filter_ProductName");
            byNameFilterBtn.Focus();
            byNameFilterBtn.Click();

            Thread.Sleep(1000);

            var noFilterLink =
                Find.ByXPath<HtmlAnchor>("//ul[@class='rmActive rmVertical rmGroup rmLevel1']//a[@class='rmLink']");

            var containsFilterLink =
                Find.ByXPath<HtmlAnchor>("//ul[@class='rmActive rmVertical rmGroup rmLevel1']/li[2]/a[@class='rmLink']");
            containsFilterLink.Focus();
            containsFilterLink.Click();
        }

        private HtmlInputImage ReturnDenyChangesBtn()
        {
            string xpath = "//table[@id='RadGrid1_ctl00']/tbody//div[@class='rgEditForm']/table/tbody/tr[2]/td/input[2]" ;
            var deny = Find.ByXPath<HtmlInputImage>(xpath);

            return deny;
        }

        private HtmlInputImage ReturnApplyChangesBtn()
        {
            string xpath = "//table[@id='RadGrid1_ctl00']/tbody//div[@class='rgEditForm']/table/tbody/tr[2]/td/input";
            var apply = Find.ByXPath<HtmlInputImage>(xpath);

            return apply;
        }

        private HtmlInputText ReturnPriceInput()
        {
            string xpath = "//table[@id='RadGrid1_ctl00']/tbody//div[@class='rgEditForm']/table/tbody//table/tbody/tr[2]/td[2]//input";
            var edit = Find.ByXPath<HtmlInputText>(xpath);
            return edit;         
        }

        private HtmlInputText ReturnEditNameInput(int row)
        {
            // ----------------- SOLUTION --------------------
            #region
            //RadGrid grid = Find.ById("RadGrid1");
            //GridDataItem firstRow = grid.MasteTable.DataItems[0];
            //GridDataCell firstRowThirdCell = firstRow.DataCells[2];

            // assert initial value
            //Assert.IsTrue(firstRowThirdCell.CellText == "Chai", 
            //String.Format("Assert failed, expected value {0}, actual {1}", "Chai", firstRowThirdCell.CellText)); 
            //HtmlAnchor firstRowEditButton = firstRow.Find.ById("~AutoGeneratedEditButton");

            // put the item in edit mode
            //firstRowEditButton.Click(); 
            //Wait.For(myItem => myItem.Edited, firstRow, 5000);
            //HtmlInputText productNameTbx = Find.ById("~ctl05_ctl09"); productNameTbx.Value = "foo";

            // update the item 
            //GridEditForm editForm = Find.ById("~ctl05_ctl00"); 
            //editForm.Update(); Wait.For(myItem => !myItem.Edited, firstRow, 5000);

            // verify grid is updated 
            //Assert.IsTrue(firstRowThirdCell.CellText ==
            //    "foo", String.Format("Assert failed, expected value {0}, actual {1}", "foo", firstRowThirdCell.CellText));
            #endregion
            ActiveBrowser.RefreshDomTree();
            string xpath = "//table[@id='RadGrid1_ctl00']/tbody//div[@class='rgEditForm']/table/tbody//table/tbody/tr[1]/td[2]/input";
            var edit = Find.ByXPath<HtmlInputText>(xpath);
            return edit;            
        }

        private HtmlTableCell ReturnEditBtn(int row)
        {
            string xpath = "//table[@id='RadGrid1_ctl00']/tbody/tr[" + row.ToString() + "]/td[4]";
            var edit = Find.ByXPath<HtmlTableCell>(xpath);

            return edit;
        }

        private HtmlTableCell ReturnDeleteBtn(int row)
        {
            string xpath = "//table[@id='RadGrid1_ctl00']/tbody/tr[" + row.ToString() + "]/td[5]";
            var delete = Find.ByXPath<HtmlTableCell>(xpath);

            return delete; 
        }

        private double ExtractDouble(string doubleStr)
        {
            double price = 0.000d;
            if (doubleStr.Contains("Sum"))
            {
                doubleStr = doubleStr.Substring(doubleStr.IndexOf(' '));
                doubleStr = doubleStr.Substring(doubleStr.IndexOf(':') + 1);
            }
            doubleStr = doubleStr.Replace(" лв.", "");
            bool result = double.TryParse(doubleStr, out price);
            if (result == false)
            {
                throw new InvalidOperationException("I can't parse this string!");
            }
            return price;
        }

    }
}














