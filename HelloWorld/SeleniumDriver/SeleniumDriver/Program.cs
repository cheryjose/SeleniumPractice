using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;



// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;

class GoogleSuggest
{


    private static void Main(string[] args)
    {
  
        DesiredCapabilities cap = new DesiredCapabilities();
        var firefoxProfile = new FirefoxProfile();
        // configure firefoxProfile ...
        DesiredCapabilities capabilities = DesiredCapabilities.Firefox();

        capabilities.SetCapability(CapabilityType.AcceptSslCertificates, true);
        capabilities.SetCapability(CapabilityType.HasNativeEvents, false);
        capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
        capabilities.IsJavaScriptEnabled = true;
        capabilities.SetCapability(FirefoxDriver.ProfileCapabilityName, firefoxProfile.ToBase64String());
        Uri url = new Uri("http://localhost:4444/");
        RemoteWebDriver driver = new RemoteWebDriver(url, capabilities);
       
    }

}