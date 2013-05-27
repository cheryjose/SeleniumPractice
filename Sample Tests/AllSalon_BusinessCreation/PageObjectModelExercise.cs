using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace BusinessCreation
{
    class GmailHomePage
    {
        IWebDriver driver;

        [FindsBy(How = How.Name)]
        private IWebElement Title;

        [FindsBy(How = How.Name)]
        private IWebElement Email;

        [FindsBy(How = How.Name)]
        private IWebElement Passwd;

        public GmailHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CheckTile()
        {
            
            try
            {
                Assert.AreEqual("Gmail: Email from Google",driver.Title);
                Console.WriteLine("The page title is correct: " +driver.Title);
            }
            catch (Exception)
            {
                Console.WriteLine("The page title is wrong: " +driver.Title);
            }

        }

        public void CheckElements()
        {
            try
            {
                Assert.IsTrue(Email.Enabled);
                Console.WriteLine("Email field enabled");
            }
            catch (Exception)
            {
                Console.WriteLine("Email field disabled");
            }

            try
            {
                Assert.IsTrue(Passwd.Enabled);
                Console.WriteLine("Passwd field enabled");
            }
            catch (Exception)
            {
                Console.WriteLine("Passwd field disabled");
            }
        }

    }

    class Login
    {


    }

    class program
    {
        static void Main()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.gmail.com");
            GmailHomePage homepage = new GmailHomePage(driver);
            PageFactory.InitElements(driver, homepage);
            homepage.CheckTile();
            homepage.CheckElements();
            Console.ReadLine();
        }

    }
    //class LoginPage
    //{
    //    private IWebDriver driver;

    //    [FindsBy(How = How.Name)]
    //    private IWebElement userName; // How.NAME = userName

    //    [FindsBy(How = How.Name)]
    //    private IWebElement password; // How.NAME = password

    //    [FindsBy(How = How.Name)]
    //    private IWebElement login; // How.NAME = login

    //    public LoginPage(IWebDriver driver)
    //    {
    //        this.driver = driver;
    //    }

    //    public void Do(string UserName, string Password)
    //    {
    //        userName.SendKeys(UserName);
    //        password.SendKeys(Password);
    //        login.Click();

    //        //PageFactory.InitElements(driver, (new FindFlightsPage(this.driver)));
    //        //return new FindFlightsPage(driver);
    //    }
    //}

    //class FindFlightsPage
    //{
    //    private IWebDriver driver;

    //    public FindFlightsPage(IWebDriver driver)
    //    {
    //        this.driver = driver;

    //        // 1. verify if page is valid
    //        Console.WriteLine("Verify page load");
    //        //if (driver.Title != "Find a Flight: Mercury Tours:")
    //        //    throw new NoSuchWindowException("This is not the FindFlights page");
    //    }

    //    // 2. method/code-block to find a flight
    //    //public void Do()
    //    //{
    //    //    Console.WriteLine("In FindFlightsPage.Do [Checking for Flights]");
    //    //}

    //    // returns LoginPage PageObject
    //    public LoginPage Logout()
    //    {
    //        // 3. log-off and return to LoginPage
    //        driver.FindElement(By.LinkText("SIGN-OFF")).Click();
    //        driver.FindElement(By.LinkText("Home")).Click();

    //        // 4. return the LoginPage object
    //        return new LoginPage(driver);
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        IWebDriver driver = new FirefoxDriver();
    //        driver.Navigate().GoToUrl("http://newtours.demoaut.com");

    //        LoginPage Login = new LoginPage(driver);

    //        // initialize elements of the LoginPage class
    //        PageFactory.InitElements(driver, Login);
    //        // all elements in the 'WebElements' region are now alive!
    //        // FindElement or FindElements no longer required to locate elements

    //         Login.Do("User", "mercury");
            
    //        driver.Quit();
    //        Console.ReadLine();
    //    }
    //}
}
