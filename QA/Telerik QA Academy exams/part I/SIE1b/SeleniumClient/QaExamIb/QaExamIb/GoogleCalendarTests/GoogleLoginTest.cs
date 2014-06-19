using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using QaExamIb;
using WebDriverQaExamI.Pages;

namespace WebDriverQaExamI.GoogleCalendarTests
{
    [TestClass]
    public class GoogleLoginTest
    {
        [TestMethod]
        public static void GoogleLogin()
        {
            LoginProfile();
            // account page
            Assert.IsTrue(GooglePage.ProfileMenu.Displayed);
            GooglePage.ProfileMenu.Click();

            Thread.Sleep(1000);

            string expectedProfile = "testqaexam@gmail.com";
            Assert.AreEqual(expectedProfile, GooglePage.ProfileLabel.Text);

            GooglePage.LogoutProfile(expectedProfile);    
            
            BaseTest.TearDown();
        }

        public static void LoginProfile()
        {
            BaseTest.BaseUrl = GooglePage.HomePageUrl;
            BaseTest.Setup(BaseTest.BaseUrl);

            WebDriverWait wait = new WebDriverWait(BaseTest.BaseDriver, TimeSpan.FromSeconds(5));
            wait.Until((d) => { return d.Title.StartsWith("Google"); });

            GooglePage.AreAllElementShown();

            // login btn
            GooglePage.LoginBtn.Click();
            // login page
            // Sign in - Google Accounts
            Thread.Sleep(1500);
            Assert.AreEqual("Вход – Google Профили", BaseTest.BaseDriver.Title);

            Assert.IsTrue(GooglePage.EmailInput.Displayed);
            GooglePage.EmailInput.Clear();
            GooglePage.EmailInput.SendKeys("testqaexam");
            Assert.IsTrue(GooglePage.PasswordInput.Displayed);
            GooglePage.PasswordInput.Clear();
            GooglePage.PasswordInput.SendKeys("TestPass");
            Assert.IsTrue(GooglePage.SigninBtn.Displayed);
            GooglePage.SigninBtn.Click();
            Thread.Sleep(1500);
        }
    }
}
