using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
namespace AllSalon_BusinessCreation
{
    class WebDriverExecutionSpeed
    {
        static void Main(string[] args)
        {
            int second;
            string exception="";
            //string location="
            IWebDriver driver = new InternetExplorerDriver(@"T:\users\chery\documents\visual studio 2010\Projects\AllSalon_BusinessCreation\AllSalon_BusinessCreation");
            driver.Navigate().GoToUrl("http://www.gmail.com");
            driver.FindElement(By.Id("Email")).SendKeys("cheryjose");
            driver.FindElement(By.Id("Passwd")).SendKeys("hesba437$");
            driver.FindElement(By.Id("signIn")).Click();
            
            //driver.FindElement(By.XPath("//a[@id='gbg6']/span[@id='gbi4t']")).Click();
            for (second=0; ; second++)
            {
                
                try
                {
                    if (second >= 5) Assert.Fail("Fail");

                }
                catch (Exception f)
                {
                    Console.WriteLine(f.Message);
                }
                try { if(driver.FindElement(By.XPath("//a[@id='gbg6']/span[@id='gbi4t']")).Displayed) break; }
                catch (Exception e) { Console.WriteLine(e.Message);}
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("second : "+second);
            driver.FindElement(By.XPath("//a[@id='gbg6']/span[@id='gbi4t']")).Click();
            Console.ReadLine();
        }
        
        
    }
}
