using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace NameSpace
{
    class MultipleBrowsers
    {
        static void Main(string[] args)
        {
            FirefoxDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://google.com");
            //driver.FindElement(By.Id("lst-ib")).SendKeys("Chery");
            driver.FindElement(By.Name("btnK")).Click();

        }
    }
}
