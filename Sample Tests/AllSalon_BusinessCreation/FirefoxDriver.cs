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
    class FirefoxDriverTest
    {
        static void Main(string[] arg)
        {
            
            
            FirefoxDriver properties = new FirefoxDriver();
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager profmanager = new FirefoxProfileManager();
            FirefoxDriverTest ffoxTest = new FirefoxDriverTest();
            profile.SetPreference("webdriver.load.strategy", "unstable");
            properties.Navigate().GoToUrl(@"http://www.google.com");
            SendKeys.SendWait("hi");
            MouseEventArgs mouse;
            IMouse e;
            IWebDriver driver = new FirefoxDriver();
            //Console.WriteLine(properties.Capabilities);
            //Console.WriteLine(profile.EnableNativeEvents);
            //Console.WriteLine(profmanager.ExistingProfiles);
            //Console.ReadLine();
        }
    }
}
