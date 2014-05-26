using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebDriverQaExamI.GoogleCalendarTests
{
    [TestClass]
    public class AddEventUniqueTimeTest
    {
        [TestMethod]
        public void AddCalendarUniqueEvent()
        {
            GoogleLoginTest.LoginProfile();

            DateTime today = DateTime.Now;
            string calendarEvent = today.ToShortDateString();
            calendarEvent = calendarEvent.Substring(0, 9);
            calendarEvent = "Meeting at " + calendarEvent + " - " + today.ToShortTimeString();
            AddEventTest add = new AddEventTest();
            add.AddNewCalendarEvent(calendarEvent);

            BaseTest.TearDown();
        }
    }
}
