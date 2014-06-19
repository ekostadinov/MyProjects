using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using QaExamIb;
using WebDriverQaExamI.Pages;

namespace WebDriverQaExamI.MagentoTests
{
    [TestClass]
    public class IncorrectLoginNoInputData
    {
        [TestMethod]
        public void IncorrectLoginNoInput()
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


            //Assert.AreEqual("Password", MagentoPage.PasswordLabel.Text);

            Assert.IsTrue(MagentoPage.PasswordInput.Displayed);
            MagentoPage.PasswordInput.Clear();

            Assert.IsTrue(MagentoPage.LoginBtn2.Displayed);
            MagentoPage.LoginBtn2.Click();

            Thread.Sleep(1000);
            Assert.AreEqual("This is a required field.", MagentoPage.EmptyEmailLabel.Text);
            

            Assert.AreEqual("This is a required field.",  MagentoPage.EmptyPassLabel.Text);

            BaseTest.TearDown();       
        }

    }
}
