using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;
namespace SeleniumTests
{
    [TestFixture]
    public class AllSalon
    {
        private IWebDriver driver;
        private IKeyboard keboard;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.explorekeralatours.com";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheAllSalonTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/saloons/saloons/");
            new SelectElement(driver.FindElement(By.Id("city"))).SelectByText("Canberra");
            Thread.Sleep(5000);
            new SelectElement(driver.FindElement(By.Id("suburub"))).SelectByText("Woden");
            Thread.Sleep(5000);
            new SelectElement(driver.FindElement(By.Id("service"))).SelectByText("Tinting");
            Console.WriteLine(driver.FindElement(By.XPath("//form[@action='searchresults']/input[@id='Searchtxt']")));
            driver.FindElement(By.Id("Search")).Click();
            if(driver.FindElement(By.XPath("//form[@action='searchresults']/input[@id='Searchtxt']")).Displayed)
            driver.FindElement(By.XPath("//form[@action='searchresults']/input[@id='Searchtxt']")).SendKeys("Franklin");
            if (driver.FindElement(By.XPath("//form[@action='searchresults']/input[@id='Searchfrm']")).Displayed)
            driver.FindElement(By.XPath("//form[@action='searchresults']/input[@id='Searchfrm']")).Click();
            
            
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alert.Text;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
