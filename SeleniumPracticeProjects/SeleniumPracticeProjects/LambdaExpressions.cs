using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox.Firefox;

namespace BusinessCreation
{
    class LambdaExpressions
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Cheese!");
            element.Submit();
        }
    }
}
