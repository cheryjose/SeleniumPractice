using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace BusinessCreation
{
     [TestFixture]
    class PayCalculator
    {
        IWebDriver driver;
        SelectElement PayCycleSelect;
        IList<IWebElement> TaxOption;
        IList<IWebElement> TableValList;

        [FindsBy(How = How.Name)]
        private IWebElement income;

        [FindsBy(How = How.Name)]
        private IWebElement paycycle;

        [FindsBy(How = How.XPath,Using="//Div[@class='optionsBlock']")]
        private IWebElement OptionsDiv;

        [FindsBy(How = How.XPath, Using = "//Div[@class='resultContainer']/table[@class='resultTable']/tbody/tr")]
        private IWebElement TableContents;
        public PayCalculator(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void IncomeValue(IWebDriver driver, string strSalary)
        {
            income.Clear();
            income.SendKeys(strSalary);
        }

        public void TermSelection(IWebDriver driver, string strSelectVal)
        {
            PayCycleSelect = new SelectElement(paycycle);
            PayCycleSelect.SelectByValue(strSelectVal);
        }

        public void CalculateOptions(IWebDriver driver, string strTaxOption)
        {
            TaxOption = OptionsDiv.FindElements(By.XPath("//Div[@class='optionsBlock']/fieldset/input[@class='options']"));
            foreach(IWebElement option in TaxOption)
            {
                if (option.GetAttribute("value") == strTaxOption)
                {
                    option.Click();
                }
            }

        }

        public void GetTableData()
        {
            TableValList = TableContents.FindElements(By.XPath("//Div[@class='resultContainer']/table[@class='resultTable']/tbody/tr"));
            Console.WriteLine(TableValList.Count);
            foreach (IWebElement Tr in TableValList)
            {
                //

            }

            IList<IWebElement> TableItems = TableContents.FindElements(By.XPath("//Div[@class='resultContainer']/table[@class='resultTable']/tbody/tr/td"));
            foreach (IWebElement item in TableItems)
            {
                Console.WriteLine("Item: " + item.GetAttribute("id") + " Value: " + item.Text);

            }
        }

        public void VerifyTableData()
        {


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.paycalculator.com.au/");
            PayCalculator PayCalc = new PayCalculator(driver);
            PageFactory.InitElements(driver,PayCalc);
            PayCalc.IncomeValue(driver, "200000");
            PayCalc.TermSelection(driver, "monthly");
            PayCalc.CalculateOptions(driver, "foreigner");
            PayCalc.GetTableData();
            Console.ReadLine();
        }
    }
}
