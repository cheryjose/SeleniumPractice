using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace ShortcutsSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            string []ExceptionVal= new string[10];
            FirefoxProfileManager fprofilManager = new FirefoxProfileManager();
            FirefoxProfile fprofile = new FirefoxProfile();
            //fprofile.SetPreference(
            FirefoxDriver driver = new FirefoxDriver(fprofile);
            //fprofile.
            
            driver.Navigate().GoToUrl("http://www.shortcuts.com.au/");
            driver.FindElement(By.Name("t1")).SendKeys("TestUser");
            driver.FindElement(By.Name("t2")).SendKeys("TestCompany");
            driver.FindElement(By.Name("t3")).SendKeys("0420727256");
            driver.FindElement(By.Name("t4")).SendKeys("testemail@email.com");
            driver.FindElement(By.Name("t5")).SendKeys("5050");
            IWebElement elementSelect = driver.FindElement(By.Name("t6"));

            SelectElement selecElement = new SelectElement(elementSelect);
            selecElement.SelectByText("Event");

            try
            {
                if (driver.FindElement(By.LinkText("Home")).Displayed)
                {
                    Console.WriteLine("Home link is displayed");
                }
                else
                {
                    Console.WriteLine("Home link is not displayed");
                    ExceptionVal[0] = "No Home link";
                }
                if (driver.FindElement(By.LinkText("Company")).Displayed)
                {
                    Console.WriteLine("Company link is displayed");
                    IWebElement CompanyLink = driver.FindElement(By.LinkText("Company"));
                    Actions builder = new Actions(driver);
                    //builder.ContextClick(CompanyLink).Perform();
                    //IJavaScriptExecutor jscript = driver as IJavaScriptExecutor;
                    //jscript.ExecuteScript("return $(\"a:contains('Company')\").mouseover();");
                    //driver.FindElement(By.XPath("//div[@id='HeadSubMenu']/a[text()='Contact']")).Click();
                    //builder.MoveByOffset(5, 5).Perform();
                    //builder.MoveToElement(CompanyLink).Perform();
                    //builder.MoveToElement(CompanyLink); 


                    //builder.MoveToElement(CompanyLink).Build().Perform();
                    //builder.Click(CompanyLink);
                    //builder.ContextClick(CompanyLink);
                    //CompanyLink.Click();
                }
                else
                {
                    Console.WriteLine("Company link is not displayed");
                    ExceptionVal[1] = "No Company link";
                }
                if(driver.FindElement(By.LinkText("Products")).Displayed)
                {
                    Console.WriteLine("Products link is displayed");
                }
                else
                {
                    Console.WriteLine("Products link is not displayed");
                }
                if (driver.FindElement(By.LinkText("Education")).Displayed)
                {
                    Console.WriteLine("Education Products link is displayed");
                }
                else
                {
                    Console.WriteLine("Education link is not displayed");
                }
                if (driver.FindElement(By.LinkText("Support")).Displayed)
                {
                    Console.WriteLine("Support link is displayed");
                }
                else
                {
                    Console.WriteLine("Support link is not displayed");
                }

            }
            catch(StaleElementReferenceException e)
            {

            }

            
            Console.ReadLine();
            
        }
    }
}
