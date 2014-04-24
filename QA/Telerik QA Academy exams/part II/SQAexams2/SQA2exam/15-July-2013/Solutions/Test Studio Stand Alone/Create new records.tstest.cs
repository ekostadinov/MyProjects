using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        

    public class Create_new_records : BaseWebAiiTest
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
    
        //[CodedStep(@"New Coded Step")]
        //public void WebTest1_CodedStep()
        //{
            ////Pages.HttpLocalhost58549TestPag.RadGrid1Table
            //HtmlTable table = Pages.HttpLocalhost58549TestPag.RadGrid1Table;
            //int rowCount = table.Rows.Count;
            ////Log.WriteLine(rowCount.ToString());
            //var headers = table.HeadRows;
            
            //string expectedValue = GetExtractedValue("ProductValue") as string;
            ////var row = table.Rows;
            //HtmlTableRow jayne = table.Find.TableRow(expectedValue);
            //Log.WriteLine(expectedValue);
            
            ////foreach(HtmlTableRow r in row)
            ////{
             ////    List<HtmlTableCell> listCells = r.Cells;
             ////   for(int i=0; i<listCells.Count; i++)
             ////   {
              ////  HtmlTableCell cell = r.Cells[i];
               
                ////foreach(HtmlTableCell c in listCells)
                ////{
              ////  Log.WriteLine(cell.InnerText);
                ////}
              ////  }
        //}
    
        //[CodedStep(@"New Coded Step")]
        //public void WebTest1_CodedStep()
        //{
            //HtmlTable table = Pages.HttpLocalhost58549TestPag.RadGrid1Table;
            ////var tbody = table.Find.AllByExpression("tagname=td").FirstOrDefault();
            
            
            
        //}
    }
}
