using System;
using System.Windows.Forms;
using System.Collections.Generic;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
namespace AllSalon_BusinessCreation
{
    class PlUpload
    {
        static void Main(string[] args)
        {      
               string CurrWindHandler;  
               IWebDriver driver = new FirefoxDriver();
               driver.Navigate().GoToUrl("http://www.plupload.com/example_queuewidget.php");
               driver.FindElement(By.XPath("//object[@data='/plupload/js/plupload.flash.swf']")).Click();
               SendKeys.SendWait(@"C:\Users\Public\Pictures\Sample Pictures\Dock.jpg");
               SendKeys.SendWait(@"{Enter}");
               IKeyboard e;
               //e.SendKeys("kk");
               //driver.SwitchTo().Window("Open").FindElement(By.Id("File Name")).SendKeys(@"C:\Users\Public\Pictures\Sample Pictures\Dock.jpg");
               CurrWindHandler = driver.CurrentWindowHandle;
               Console.WriteLine(CurrWindHandler);
               IList<String> windowIterator = driver.WindowHandles;
               Console.WriteLine(windowIterator.Count);
               foreach (string element in windowIterator)
               {
                   Console.WriteLine(element.ToString());
                   driver.SwitchTo().Window(element);
                   Console.WriteLine(driver.SwitchTo().Window(element).Title);
               }
               Console.ReadLine();
        }


    }
}
