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
            //Test
            driver.Navigate().GoToUrl("http://www.google.co.uk");
            driver.FindElement(By.Id("lst-ib")).SendKeys("selenium");
            driver.FindElement(By.ClassName("lsb")).Click();
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
