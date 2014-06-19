using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using QaExamIb;
using WebDriverQaExamI.Pages;

namespace WebDriverQaExamI.MagentoTests
{
    [TestClass]
    public class IncorrectLoginData
    {
        [TestMethod]
        public void IncorrectLogin()
        {
            BaseTest.BaseUrl = MagentoPage.HomePageUrl;
            BaseTest.Setup(BaseTest.BaseUrl);

            WebDriverWait wait = new WebDriverWait(BaseTest.BaseDriver, TimeSpan.FromSeconds(5));
            wait.Until((d) => { return d.Title.StartsWith("Home page"); });

            MagentoPage.AreAllElementShown();
            MagentoPage.MyAccountBtn.Click();

            wait.Until((d) => { return d.Title.StartsWith("Customer Login"); });

            try
            {
                Assert.AreEqual("Registered Customers", MagentoPage.RegisteredCustomersLabel.Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            //Assert.AreEqual("*/r/n Email Address", MagentoPage.EmailAdressLabel.Text);
            
            Assert.IsTrue(MagentoPage.EmailAdressInput.Displayed);
            MagentoPage.EmailAdressInput.Clear();
            MagentoPage.EmailAdressInput.SendKeys("incorrect@mail.test");
            
            
            //Assert.AreEqual("Password", MagentoPage.PasswordLabel.Text);
            
            Assert.IsTrue(MagentoPage.PasswordInput.Displayed);
            MagentoPage.PasswordInput.Clear();
            MagentoPage.PasswordInput.SendKeys("incorrect-pass");

            Assert.IsTrue(MagentoPage.LoginBtn2.Displayed);
            MagentoPage.LoginBtn2.Click();
            Assert.AreEqual("Invalid login or password.", MagentoPage.ErrorMsgLabel.Text);

            BaseTest.TearDown();
        }

    }
}
