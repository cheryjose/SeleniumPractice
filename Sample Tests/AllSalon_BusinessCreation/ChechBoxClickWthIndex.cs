using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    class ChechBoxClickWthIndex
    {
        static void Main(string[] args)
        {
        
            IWebDriver driver = new FirefoxDriver();
            
            driver.Navigate().GoToUrl("file:///C:/Users/chery/Desktop/CheckBox.html");

            // Find the text input element by its name
            IWebElement WebElement = driver.FindElement(By.XPath("//div[@class='facetContainerDiv']/div"));
            IList<IWebElement> AllCheckBoxes = WebElement.FindElements(By.XPath("//label/input"));
            int RowCount = WebElement.FindElements(By.XPath("//label/input")).Count;
            for (int i = 0; i < RowCount; i++)
            {
                //AllCheckBoxes[i].Click();

            }
            foreach (IWebElement element in AllCheckBoxes)
            {

                element.Click();
            }
            Console.WriteLine(RowCount);
            Console.ReadLine(); 

        }
    }
}
