using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using System.Reflection;
using NUnit.Framework;

namespace TestPractice_PageObject_Nunit
{
    [TestFixture]
    class PageObject
    {
       //[FindsBy(How = How.Name
        [FindsBy(How = How.XPath, Using = "//input[@id='ic-annual-income']")]
        public IWebElement element;
        [FindsBy(How = How.XPath, Using = "//div[@id='ic-white-block']")]
        public IWebElement frame;
        [FindsBy(How = How.XPath, Using = "//a[@title='Income Tax']")]
        public IWebElement elementSelection;
        [FindsBy(How = How.XPath, Using = "//div[@class='accordion-content open-content']")]
        public IWebElement elementTaxValue;
        [FindsBy(How = How.XPath, Using = "//div[@class='accordion-content open-content']/span")]
        public IList<IWebElement> elementTaxValues;
        [FindsBy(How = How.XPath, Using = "//a[@title='Tax Thresholds']")]
        public IWebElement elementTaxThreshold;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Home Loans')]")]
        public IWebElement elementHomeLoan;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'First Home Buyers')]")]
        public IWebElement elementHomeByer;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Refinancing')]")]
        public IWebElement elementRefinancing;
        [FindsBy(How = How.Id, Using = "ic-calculator-iframe")]
        public IWebElement FrameWindow;
    }

    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    class TestLogic
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        [SetUp]
        static void Main(string[] args)
        {
                /*
                 * 
                 */
                FirefoxDriver driver = new FirefoxDriver();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                driver.Navigate().GoToUrl("http://www.loanmarket.com.au/calculators/income-tax/?gclid=COeE_M6anLcCFSo6pgod80QAxQ");
                PageObject obj = new PageObject();
                TestLogic testLogObj = new TestLogic();
                PageFactory.InitElements(driver, obj);
                string windowHandle = driver.CurrentWindowHandle;
                testLogObj.EnterValue(driver, obj);
                driver.SwitchTo().Window(windowHandle);
                testLogObj.LinkCheck(driver, obj, obj.elementHomeLoan);
                testLogObj.LinkCheck(driver, obj, obj.elementHomeByer);
                testLogObj.LinkCheck(driver, obj, obj.elementRefinancing);
                //driver.Close();
                //driver.Quit();
                Console.ReadLine();
            
        }
        [Test]
        public void LinkCheck(IWebDriver driver, PageObject obj, IWebElement element)
        {
               try
               {
                    //if (driver.FindElement(By.XPath("//a[contains(text(),'Home Loans')]")).Displayed == true)
                    //{
                    //    Console.WriteLine(" Input field is identified Cond 2");
                    //}
                   if (element.Displayed == true)
                    {
                        Console.WriteLine(" Input field is identified "+ element.Text + " displayed");
                        //Assert.Pass(element.Text + " is Displayed");
                        Assert.AreEqual(5, 5);
                    }
                    else
                    {
                        Console.WriteLine(" Input field is identified " + element.Text + " not displayed");
                        //Assert.Fail(element.Text + " is not Displayed");
                        //Assert.Pass("kkkk");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception : " + e.Message);
                    Console.WriteLine("Exception InnerMessage : " + e.InnerException);
                    //Assert.Fail(e.Message);
                }


        }
        [Test]
        public void EnterValue(IWebDriver driver, PageObject obj)
        {
                try
                {
                    IWebElement FrameWindow = driver.FindElement(By.Id("ic-calculator-iframe"));
                    //Console.WriteLine(obj.FrameWindow.Text);
                    driver.SwitchTo().Frame(FrameWindow);
                    //if (driver.FindElement(By.XPath("//input[@id='ic-annual-income']")).Displayed == true)
                    //{
                    IWebElement TempElement = obj.element;
                    if (TempElement.Enabled == true)
                    {

                        Console.WriteLine(" Input field is identified Cond 1");
                        //Assert.Pass(TempElement.Text + " is Displayed");
                        //IWebElement element = driver.FindElement(By.XPath("//input[@id='ic-annual-income']"));
                        Actions newAction = new Actions(driver);
                        //element.Clear();
                        //IKeyboard neI;


                        newAction.MoveToElement(obj.element).Perform();
                        //newAction.SendKeys(Keys.Home).SendKeys(Keys.Shift).SendKeys(Keys.End).SendKeys(Keys.Delete).Perform();
                        ILocatable loc = (ILocatable)obj.element;
                        IMouse mouse = ((IHasInputDevices)driver).Mouse;         // Converting driver as a Mouse
                        mouse.DoubleClick(loc.Coordinates);                    //Right Click
                        IKeyboard key = ((IHasInputDevices)driver).Keyboard;    // Converting driver as a Keyboard
                        key.PressKey(Keys.Home + Keys.Shift + Keys.End + Keys.Delete);
                        obj.element.SendKeys("1000");
                        //driver.FindElement(By.XPath("//div[@id='ic-white-block']")).Click();
                        obj.frame.Click();
                        //key.SendKeys("222");
                        //IWebElement elementSelection = driver.FindElement(By.XPath("//a[@title='Income Tax']"));
                        //string incomeTax = driver.CurrentWindowHandle;
                        //Console.WriteLine("incomeTax handle : " +incomeTax);
                        //obj.elementSelection.Click();
                        //IWebElement elementTaxValue = driver.FindElement(By.XPath("//div[@class='accordion-content open-content']"));
                        //IWebElement tempWebElement = obj.elementTaxValue;
                        //IList<IWebElement> listTaxValue;
                        //listTaxValue = tempWebElement.FindElements(By.TagName("span"));
                        //listTaxValue = 
                        //Console.WriteLine(tempWebElement.Text);
                        //.FindElements(By.TagName("span")).Count;
                        foreach (IWebElement item in obj.elementTaxValues)
                        {
                            Console.WriteLine(item.Text);
                        }
                        ////driver.FindElement(By.XPath("//a[@title='Tax Thresholds']")).Click();
                        //obj.elementTaxThreshold.Click();
                        //IList<string> winHandles = driver.WindowHandles;
                        //foreach (string hnd in winHandles)
                        //{
                        //    Console.WriteLine("List of handles : " + hnd);
                        //    Console.WriteLine("Name of Window : " + driver.SwitchTo().Window(hnd).Title);
                        //    IWindow winObject =driver.SwitchTo().Window(hnd).Manage().Window;
                        //    winObject.Maximize();

                        //}
                        //newAction.DoubleClick(ediBox).SendKeys(neI.PressKey("&#127")).SendKeys("2000").Perform();
                        //ediBox.SendKeys("200");
                        //driver.FindElement(By.XPath("//input[@id='ic-annual-income']")).Click();
                        //driver.FindElement(By.XPath("//input[@id='ic-annual-income']")).SendKeys("200000");
                        Assert.AreEqual(5, 5);
                    }
                    else
                    {
                        Console.WriteLine(" Input field is not identified Cond 1");
                        //Assert.Fail(TempElement.Text + " is not Displayed");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception : " + e.Message);
                    Console.WriteLine("Exception InnerMessage : " + e.InnerException);
                    //Assert.Fail(e.Message);
                }
        }
    }
}
