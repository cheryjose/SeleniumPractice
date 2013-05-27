using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;


namespace BusinessCreation
{
    class WaitTimeoutsTimers
    {
            static void Main(string[] args)
            {
                IWebDriver driver = new FirefoxDriver();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
                driver.Navigate().GoToUrl("https://www.google.com.au");
                driver.FindElement(By.Name("q")).Clear();
                driver.FindElement(By.Name("q")).SendKeys("Chery Jose");
                if (driver.FindElement(By.Name("btnK")).Displayed)
                {
                    driver.FindElement(By.Name("btnK")).Click();
                }
                else if (driver.FindElement(By.Name("btnG")).Displayed)
                {
                    //WebDriverWait wait = new WebDriverWait();
                    driver.FindElement(By.Name("btnG")).Click();
                }
                driver.FindElement(By.XPath("//a[@href='http://au.linkedin.com/in/cheryjose']")).Click();
                
            }
    }
}