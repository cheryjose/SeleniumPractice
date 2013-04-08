using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using ThoughtWorks.Selenium.Silvernium;

namespace BusinessCreation
{
    class HandlingAlert
    {
        static string strWindowHandle;
        static string strAlertMessage;
        static string strAlertSuppressed;
        static void Main()
        {
            
            

            IWebDriver driver = new FirefoxDriver();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("http://www.tizag.com/javascriptT/javascriptalert.php");
            ThoughtWorks.Selenium.Silvernium.Silvernium obj1 = new Silvernium(driver,"hi");
            //driver.FindElement(By.XPath("//div/form/input[@value='Confirmation Alert']")).Click();
            //try
            //{

            //    //driver.FindElement(By.XPath("//div/form/input[@value='Confirmation Alert']")).Click();
            //    IAlert alert = driver.SwitchTo().Alert();
            //    alert.Accept();
            //    driver.FindElement(By.LinkText("HTML Forms Lesson")).Click();
            //}
            //catch (NoAlertPresentException e) 
            //{
            //    Console.WriteLine(e.Message);
                
            //}
            //strAlertSuppressed=SuppressAlert(driver);
            //Console.WriteLine(strAlertSuppressed);
            //SendKeys.SendWait("{Enter}");
            Console.WriteLine("Missed the lines");
            Console.ReadLine();
        }



        //static string SuppressAlert(IWebDriver driver)
        //{
        //    try
        //    {
        //        IAlert alert = driver.SwitchTo().Alert();
        //        alert.Accept();
        //    }
        //    catch(NoAlertPresentException e)
        //    {
        //        strAlertMessage= e.Message;
        //    }
        //    return strAlertMessage;
        //}
    }
}
