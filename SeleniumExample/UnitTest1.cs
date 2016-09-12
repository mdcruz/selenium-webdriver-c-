using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumExample
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void TestGoogleSearch()
        {
            driver.Navigate().GoToUrl("http://www.google.co.uk");
            driver.FindElement(By.Id("lst-ib")).SendKeys("selenium");
            driver.FindElement(By.ClassName("lsb")).Click();
        }

        [TestMethod]
        public void SimpleTest()
        {
            Assert.AreEqual(25, 10 + 10);
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
