using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Selenium;
using SeleniumTests;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class FDCalculator
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            
            driver = new FirefoxDriver();
            baseURL = "http://www.rupeetimes.com/calculators/fixed_deposits/fixed_deposit_interest_income_calculator.php";
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
        public void TheFDCalculatorTest()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Name("deposit")).Clear();
            driver.FindElement(By.Name("deposit")).SendKeys("2000000");
            driver.FindElement(By.Name("duration")).Clear();
            driver.FindElement(By.Name("duration")).SendKeys("1265");
            driver.FindElement(By.Name("rate")).Clear();
            driver.FindElement(By.Name("rate")).SendKeys("10");
            new SelectElement(driver.FindElement(By.Name("compound"))).SelectByText("Compound Annually");
            driver.FindElement(By.Name("btnSubmit")).Click();
            if (driver.FindElement(By.XPath("//input[@name='deposit']")).Enabled)
            {
                Console.WriteLine("//input[@name='deposit']");
                            }
            if (driver.FindElement(By.XPath("//td[@class='content_cell']")).Enabled)
            {
                Console.WriteLine("//td[@class='content_cell']");
            }

            if (driver.FindElement(By.XPath("//td[@class='navtab_selected']")).Enabled)
            {
                driver.FindElement(By.XPath("//td[@class='navtab_selected']")).Click();
                Console.WriteLine("//td[@class='navtab_selected']");    
            }
            if (driver.FindElement(By.XPath("//input[@type='button' and @name='btnGo']")).Enabled)
            {
                Console.WriteLine("//input[@type='button' and @name='btnGo']");
            }
            //if (driver.FindElement(By.XPath("//td[@class='navtab']/a[contains(text(),'Home')]")).Enabled)
            //{
            //    driver.FindElement(By.XPath("//td[@class='navtab']/a[contains(text(),'Home')]")).Click();
            //    Console.WriteLine("//td[@class='navtab']/a[");
            //}
            Console.ReadLine();
            //if(driver.FindElement(By.XPath("//td[class='content_cell']")).Displayed)
            //{
            //    Console.WriteLine("/td[class='content_cell]");
            //    Console.ReadLine();
            //}

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
