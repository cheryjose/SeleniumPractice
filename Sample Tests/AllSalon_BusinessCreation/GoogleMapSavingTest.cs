using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    public class GoogleMapSavingTest
    {
          static void Main(string[] args)
          {
              IWebDriver driver = new FirefoxDriver();
              driver.Navigate().GoToUrl("https://maps.google.com.au/");
              driver.FindElement(By.Id("d_launch")).Click();
              driver.FindElement(By.Id("d_d")).Clear();
              driver.FindElement(By.Id("d_d")).SendKeys("Franklin, ACT");
              driver.FindElement(By.Id("d_daddr")).Clear();
              driver.FindElement(By.Id("d_daddr")).SendKeys("Gungahlin, ACT");
              driver.FindElement(By.Id("d_d")).Click();
              driver.FindElement(By.Id("d_sub")).Click();
              for (int second = 0;; second++) 
              {
                    if (second >= 60) Assert.Fail("timeout");
                    try
                    {
                        if (driver.FindElement(By.XPath("//div[@id='dir_sr']/a[@id='srlink']")).Displayed) break;
                    }
                    catch (Exception)
                    {}
                    Thread.Sleep(1000);
                }
                driver.FindElement(By.XPath("//div[@id='dir_sr']/a[@id='srlink']")).Click();
                driver.FindElement(By.Id("Email")).SendKeys("UserName");
                driver.FindElement(By.Id("Passwd")).SendKeys("Password");
                driver.FindElement(By.Id("signIn")).Click();
                for (int second = 0; ; second++)
                {
                    if (second >= 60) Assert.Fail("timeout");
                    try
                    {
                        if (driver.FindElement(By.XPath("//div[@id='dir_sr']/a[@id='srlink']")).Displayed) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }
                driver.FindElement(By.XPath("//div[@id='dir_sr']/a[@id='srlink']")).Click();
                driver.FindElement(By.XPath("//button[@id='srsave']")).Click();


          }
            

 
        
        
    }
}
