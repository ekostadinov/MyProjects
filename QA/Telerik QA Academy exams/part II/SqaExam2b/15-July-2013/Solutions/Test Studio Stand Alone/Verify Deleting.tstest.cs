using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using ArtOfTest.WebAii.Win32.Dialogs;

namespace TestProject7
{

    //
    // You can add custom execution steps by simply
    // adding a void function and decorating it with the [CodedStep] 
    // attribute to the test method. 
    // Those steps will automatically show up in the test steps on save.
    //
    // The BaseWebAiiTest exposes all key objects that you can use
    // to access the current testcase context. [i.e. ActiveBrowser, Find ..etc]
    //
    // Data driven tests can use the Data[columnIndex] or Data["columnName"] 
    // to access data for a specific data iteration.
    //
    // Example:
    //
    // [CodedStep("MyCustom Step Description")]
    // public void MyCustomStep()
    // {
    //        // Custom code goes here
    //      ActiveBrowser.NavigateTo("http://www.google.com");
    //
    //        // Or
    //        ActiveBrowser.NavigateTo(Data["url"]);
    // }
    //
        

    public class Verify_Deleting : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"delete item")]
        public void Verify_Deleting_CodedStep()
        {
            AlertDialog alertDialog = new AlertDialog(ActiveBrowser, DialogButton.OK);
            Manager.DialogMonitor.AddDialog(alertDialog);
            Manager.DialogMonitor.Start();
            HtmlInputImage deleteButton = Find.ById<HtmlInputImage>("RadGrid1_ctl00_ctl04_gbccolumn");
            deleteButton.Click();
            alertDialog.WaitUntilHandled();
            
             
            
            
        }
    
        [CodedStep(@"verify deliting")]
        public void Verify_Deleting_CodedStep1()
        {
            HtmlTable table = Pages.HttpLocalhost58549TestPag.RadGrid1Table;
            table.Wait.ForExists(10000);
            Assert.IsTrue(table.IsVisible());
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                HtmlTableRow row = table.Rows[i];
                HtmlTableCell cell = row.Cells[1];
                
                string content = cell.InnerText;
                Assert.IsFalse(content == "Chai");
            }
        }
    
        //[CodedStep(@"Wait for '250' msec.")]
        //public void Verify_Deleting_CodedStep2()
        //{
            //// Wait for '250' msec.
            //System.Threading.Thread.Sleep(250);
            
        //}
    
        //[CodedStep(@"Verify element 'RadGrid1Table' 'is' visible.")]
        //public void Verify_Deleting_CodedStep2()
        //{
            //// Verify element 'RadGrid1Table' 'is' visible.
            //Pages.HttpLocalhost58549TestPag.RadGrid1Table.Wait.ForExists(10000);
            //Assert.IsTrue(Pages.HttpLocalhost58549TestPag.RadGrid1Table.IsVisible());
            
        //}
    
        //[CodedStep(@"Verify element 'RadGrid1Table' 'is' visible.")]
        //public void Verify_Deleting_CodedStep2()
        //{
            //// Verify element 'RadGrid1Table' 'is' visible.
            //Pages.HttpLocalhost58549TestPag.RadGrid1Table.Wait.ForExists(10000);
            //Assert.IsTrue(Pages.HttpLocalhost58549TestPag.RadGrid1Table.IsVisible());
            
        //}
    }
}
