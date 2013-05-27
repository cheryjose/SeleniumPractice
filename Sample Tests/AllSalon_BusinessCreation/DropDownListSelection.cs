using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    class DropDownListSelection
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/chery/Desktop/DropDownList.html");
            IWebElement element = driver.FindElement(By.XPath("//Select"));
            IWebElement ddl = driver.FindElement(By.TagName("Select"));
            int numofitems = ddl.FindElements(By.TagName("Option")).Count;
            IList<IWebElement> AllDropDownList = element.FindElements(By.XPath("//option"));
            int DpListCount = AllDropDownList.Count;
            //foreach (IWebElement item in AllDropDownList)
            //{
            //    item.Click();
            //}
            //for (int i = 0; i < DpListCount; i++)
            //{
            //    if (AllDropDownList[i].Text == "Coffee")
            //    {
            //        AllDropDownList[i].Click();
            //    }
            //}
            SelectElement selector = new SelectElement(ddl);
            for (int j = 0; j < numofitems; j++)
            {
                
                selector.SelectByText("2");
                selector.

            }
            Console.WriteLine(DpListCount);
            Console.WriteLine(numofitems);
            Console.ReadLine();
        }
    }
}
