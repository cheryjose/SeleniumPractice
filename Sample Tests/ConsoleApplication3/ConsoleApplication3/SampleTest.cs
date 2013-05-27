using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Web;

namespace SeleniumTests
{
    [TestFixture]
    public class SampleTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.google.com/";
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
        public void TheSampleTest()
        {
            //  Open the base URL like google.com
            driver.Navigate().GoToUrl(baseURL + "/");
            //  type selenium tutorial in text field which has id/name of q 
            // ERROR: Caught exception [Error: locator strategy either id or name must be specified explicitly.]
            //  click on submit button which has html id/name of btnG and wait for results 
            // ERROR: Caught exception [Error: locator strategy either id or name must be specified explicitly.]
            driver.FindElement(By.LinkText("Selenium Tutorial for Beginner/Tips for Experts")).Click();
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
