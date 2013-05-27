using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace Selenium2
{
    public class Selenium2TestBase
    {
        private FirefoxProfile _ffp;
        private IWebDriver _driver;

        public IWebDriver StartBrowser()
        {
            Common.WebBrowser = ConfigurationManager.AppSettings["Selenium2Browser"];

            switch (Common.WebBrowser)
            {
                case "firefox":
                    _ffp = new FirefoxProfile();
                    _ffp.AcceptUntrustedCertificates = true;
                    _driver = new FirefoxDriver(_ffp);
                    break;
                case "iexplore":
                    _driver = new InternetExplorerDriver();
                    break;
                case "chrome":
                    _driver = new ChromeDriver();
                    break;
            }

            return _driver;
        }
    }
}