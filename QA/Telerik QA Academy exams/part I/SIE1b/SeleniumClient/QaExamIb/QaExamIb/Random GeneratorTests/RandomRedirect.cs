using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using QaExamIb;
using WebDriverQaExamI.Pages;

namespace WebDriverQaExamI.Random_GeneratorTests
{
    [TestClass]
    public class RandomRedirect
    {
        [TestMethod]
        public void RandomRedirectTest()
        {
            BaseTest.BaseUrl = RandomPage.HomePageUrl;
            BaseTest.Setup(BaseTest.BaseUrl);

            WebDriverWait wait = new WebDriverWait(BaseTest.BaseDriver, TimeSpan.FromSeconds(5));
            wait.Until((d) => { return d.Title.StartsWith("RANDOM.ORG - Integer Generator"); });
            
            // select how many rand numbers
            Assert.IsTrue(RandomPage.NumbersCountInput.Displayed);
            RandomPage.NumbersCountInput.Clear();
            RandomPage.NumbersCountInput.SendKeys("1");
            // select range
            Assert.IsTrue(RandomPage.MinNumbersInput.Displayed);
            // clear min
            RandomPage.MinNumbersInput.Clear();
            RandomPage.MinNumbersInput.SendKeys("1");

            Assert.IsTrue(RandomPage.MaxNumbersInput.Displayed);
            // clear max
            RandomPage.MaxNumbersInput.Clear();
            RandomPage.MaxNumbersInput.SendKeys("2");

            Assert.IsTrue(RandomPage.GetNumbersBtn.Displayed);
            RandomPage.GetNumbersBtn.Click();

            Thread.Sleep(1000);

            String randNum = RandomPage.GeneratedNumber.Text;

            if (randNum == "2 ")
            {
                GoForTwo();
            }
            else if (randNum == "1 ")
            {
                Assert.IsTrue(RandomPage.LearnMoreLink.Displayed);

                Actions action = new Actions(BaseTest.BaseDriver);
                action.MoveToElement(RandomPage.LearnMoreLink).MoveToElement(RandomPage.LearnMoreNavLink).Click().Build().Perform();

                //Assert.IsTrue(RandomPage.LearnMoreNavLink.Displayed);
                //RandomPage.LearnMoreNavLink.Click();
                Assert.AreEqual("RANDOM.ORG - Frequently Asked Questions (FAQ)", BaseTest.BaseDriver.Title);

                GoForTwo();
            }
            else
            {
                throw new IndexOutOfRangeException("Generated number is not correct!");
            }

            BaseTest.TearDown();
        }

        private void GoForTwo()
        {
            Assert.IsTrue(RandomPage.HomePageLink.Displayed);
            RandomPage.HomePageLink.Click();
            Assert.AreEqual("RANDOM.ORG - True Random Number Service", BaseTest.BaseDriver.Title);
        }

    }
}
