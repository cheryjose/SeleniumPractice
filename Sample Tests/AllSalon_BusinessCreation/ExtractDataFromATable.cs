using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace BusinessCreation
{
    class ExtractDataFromATable
    {
        static void Main(string[] args)
        {
            
            
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://developer.yahoo.com/yui/examples/datasource/datasource_table_to_array.html");
            if(driver.FindElement(By.XPath("//table[@id='accounts']/thead/tr/th")).Displayed)
            {
                IWebElement webElementHead =  driver.FindElement(By.XPath("//table[@id='accounts']/thead/tr"));
                IList<IWebElement> ElementCollectionHead = webElementHead.FindElements(By.XPath("//table[@id='accounts']/thead/tr/th"));
                foreach (IWebElement item in ElementCollectionHead)
                {
                    Console.WriteLine(item.Text);
                }
            }
            if (driver.FindElement(By.XPath("//table[@id='accounts']/tbody/tr")).Displayed)
            {
                IWebElement webElementBody = driver.FindElement(By.XPath("//table[@id='accounts']/tbody/tr"));
                IList<IWebElement> ElementCollectionBody = webElementBody.FindElements(By.XPath("//table[@id='accounts']/tbody/tr"));
              
                foreach (IWebElement item in ElementCollectionBody)
                {
                    string[] arr= new string[4];
                    arr = item.Text.Split(' ');
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i]);
                    }               
                }
            }
            Console.ReadLine();
        }
    }
}
