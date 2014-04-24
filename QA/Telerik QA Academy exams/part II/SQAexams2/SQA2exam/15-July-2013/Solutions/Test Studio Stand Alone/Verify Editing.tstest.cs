using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

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
        

    public class Verify_Editing : BaseWebAiiTest
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
    
        [CodedStep(@"click on edit button")]
        public void Verify_Editing_CodedStep()
        {
            HtmlTable table = Pages.HttpLocalhost58549TestPag.RadGrid1Table;
            HtmlTableRow row = table.Rows[0];
            HtmlTableCell cell = row.Cells[1];
            
            string oldValue = cell.InnerText;
            SetExtractedValue("old", oldValue);
            Log.WriteLine(oldValue);
            
            
            HtmlInputImage b = Find.ById<HtmlInputImage>("RadGrid1_ctl00_ctl04_EditButton");
            b.Click();
            
            
            
        }
    
        [CodedStep(@"type text")]
        public void Verify_Editing_CodedStep1()
        {
            HtmlInputText editElement = Find.ById<HtmlInputText>("RadGrid1_ctl00_ctl05_TB_ProductName");
            editElement.Value=DateTime.Now.ToString();
            string newValue = editElement.Value;
            Log.WriteLine(editElement.Value);
            
            HtmlInputImage updateButton = Find.ById<HtmlInputImage>("RadGrid1_ctl00_ctl05_UpdateButton");
            updateButton.Click();
            
            object extractedValue = GetExtractedValue("old");
            //Log.WriteLine(extractedValue.ToString());
            //Log.WriteLine(newValue);
            Assert.AreNotEqual(extractedValue.ToString(), newValue);
            
        }
    
        //[CodedStep(@"New Coded Step")]
        //public void Verify_Editing_CodedStep2()
        //{
            
        //}
    }
}
