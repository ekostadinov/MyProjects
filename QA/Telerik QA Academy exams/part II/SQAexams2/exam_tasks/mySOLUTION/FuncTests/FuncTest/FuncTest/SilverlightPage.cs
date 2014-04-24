using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;
using OpenQA.Selenium;

namespace FuncTest
{
    public class SilverlightPage
    {
        //fields
        #region
        #endregion

        //properties
        #region
        #endregion

        //constructors
        #region
        #endregion

        //methods
        #region

        public static AutomationElement WaitForElementByName(AutomationElement element, int seconds, AutomationElement parent, string name)
        {
            while (element == null)
            {
                Thread.Sleep(1000);

                seconds--;

                element = parent.FindFirst(TreeScope.Descendants,
                 new PropertyCondition(AutomationElement.NameProperty, name));

                if (seconds == 0)
                {
                    throw new NoSuchElementException("Can't find element or it's not loaded!");
                }
            }

            return element;
        }
        #endregion

    }
}
