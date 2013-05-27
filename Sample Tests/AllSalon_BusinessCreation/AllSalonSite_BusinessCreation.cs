using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Selenium;
using SeleniumTests;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
namespace SeleniumTests
{
    [TestFixture]
    public class AllSalonSiteBusinessCreation
    {
        private IWebDriver driver;
        private DefaultSelenium dfs;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.explorekeralatours.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheAllSalonSiteBusinessLoginTest()
        {
            
            driver.Navigate().GoToUrl(baseURL + "saloons/");
            driver.FindElement(By.XPath("//input[@name='user']")).Clear();
            driver.FindElement(By.XPath("//input[@name='user']")).SendKeys("superadmin");
            driver.FindElement(By.XPath("//input[@name='pass']")).Clear();
            driver.FindElement(By.XPath("//input[@name='pass']")).SendKeys("superadmin");
            driver.FindElement(By.XPath("//input[@name='loginsubmit']")).Click();
        }

        public void BusinessProfileNextPage(int i)
        {
            IWebElement table1;
            table1= driver.FindElement(By.XPath(("//html/body/div[3]/div[2]/div[2]/div/div/div[2]/table")));
            IList<IWebElement> allRows = table1.FindElements(By.TagName("tr"));
            int RowCount = table1.FindElements(By.TagName("tr")).Count;
            string strVal=allRows[0].Text;
            Console.WriteLine(strVal);
            driver.FindElement(By.LinkText(Convert.ToString(i))).Click();
        }
        public void BusinessProfileCreationCheck(int i)
        {
            bool result = false;
            bool result1 = false;
            bool result2 = false;
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            try 
            {
              driver.FindElement(By.LinkText("Company Management"));
              result=true;
              Console.WriteLine("Company Management: "+Convert.ToString(result));
            }
            catch(NoSuchElementException e)
            {
              result = false;
              Console.WriteLine("Company Management: " + Convert.ToString(result));
            }
            try
            {
                driver.FindElement(By.XPath("//a[contains(text(),'View Company List')]"));
                result1 = true;
                Console.WriteLine("View Company List: " + Convert.ToString(result1));
                try
                {
                    IWebElement nml,table1;
                    //String cssLocatorOfTheElement = "html body div#header-box div#module-menu ul#menu li.node ul#menu-com-users-groups.menu-component li a:contains(\"View Company List\")";
                    nml = driver.FindElement(By.LinkText("Company Management")); 
                    //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    //StringBuilder stringbuilder = new StringBuilder();
                    //stringbuilder.Append("var x = $(\'" + cssLocatorOfTheElement + "\');");
                    //stringbuilder.Append("x.click();");
                    //Console.WriteLine(stringbuilder.ToString());
                    //js.ExecuteScript(stringbuilder.ToString());
                    //Console.WriteLine("Title: " + title);
                    Actions builder = new Actions(driver);
                    // Move cursor to the Main Menu Element
                    builder.MoveToElement(nml).Perform();
                    driver.FindElement(By.XPath("//a[contains(text(),'View Company List')]")).Click();
                    result2 = true;
                    //Console.WriteLine("View Company List Click Event: " + Convert.ToString(result2));
                    driver.FindElement(By.XPath("//html/body/div[3]/div[2]/div[2]/div/div/div[2]/table"));
                    table1 = driver.FindElement(By.XPath("//html/body/div[3]/div[2]/div[2]/div/div/div[2]/table"));
                    IList<IWebElement> allRows = table1.FindElements(By.TagName("tr"));
                    //Console.WriteLine(table1.FindElements(By.TagName("tr")).Count);
                    int RowCount = table1.FindElements(By.TagName("tr")).Count;
                    //foreach (IWebElement row in allRows)
                    //{
                    //IList<IWebElement> columnCollection = table1.FindElements(By.TagName("td"));
                    //int ColCount = table1.FindElements(By.TagName("td")).Count;
                    //Console.WriteLine(table1.FindElements(By.TagName("td")).Count);
                        //if (columnCollection[5].Text.Contains("Fwd: Security"))
                        //{
                        //Console.WriteLine(row); 
                        //}
                        //for (int j = 0; j < RowCount; j++)
                        //{

                        //    Console.WriteLine(allRows[j].Text);
                            IList<IWebElement> columnCollection = table1.FindElements(By.TagName("td"));
                            int ColCount = table1.FindElements(By.TagName("td")).Count;
                            for (int k = 0; k < ColCount; k++)
                            {
                               if (columnCollection[k].Text.Contains("Test Business"))
                                {
                                    //Console.WriteLine(columnCollection[k].Text);
                                    Thread.Sleep(5000);
                                    driver.FindElement(By.LinkText("Delete")).Click();
                                    Thread.Sleep(2000);
                                    try
                                    {
                                        Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Do You want to Continue[\\s\\S]$"));
                                    }
                                    catch (NoAlertPresentException e)
                                    {
                                        Console.WriteLine("NoAlertPresentException");
                                    }

                                }
                            }
                        //}
                    //}
                }
                catch(ElementNotVisibleException e) 
                {
                    result2 = false;
                    Console.WriteLine("View Company List Click Event: " + Convert.ToString(result2));
                }
                
                
            }
            catch (NoSuchElementException e)
            {
                result1 = false;
                Console.WriteLine("View Company List: " + Convert.ToString(result1));
            }        
              
            
         }
        public void TheAllSalonSiteBusinessCreationTest(int i)
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Company Management")).Click();
            IWebElement nml;
            nml = driver.FindElement(By.LinkText("Company Management"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(nml).Perform();
            driver.FindElement(By.XPath("//a[contains(text(),'Add New Company')]")).Click();
            //driver.FindElement(By.LinkText("Add New Company")).Click();
            driver.FindElement(By.Id("jform_nametitle")).Clear();
            driver.FindElement(By.Id("jform_nametitle")).SendKeys("Test Business"+Convert.ToString(i));
            new SelectElement(driver.FindElement(By.Id("jform_type"))).SelectByText("hair");
            driver.FindElement(By.Id("jform_unit")).Clear();
            driver.FindElement(By.Id("jform_unit")).SendKeys("Test Specalit for Business" + Convert.ToString(i));
            driver.FindElement(By.Name("jform_unit")).Clear();
            driver.FindElement(By.Name("jform_unit")).SendKeys("Test Level" + Convert.ToString(i));
            driver.FindElement(By.Id("jform_street")).Clear();
            driver.FindElement(By.Id("jform_street")).SendKeys("Test Street" + Convert.ToString(i));
            driver.FindElement(By.Id("jform_suburb")).Clear();
            driver.FindElement(By.Id("jform_suburb")).SendKeys("Test Suburb" + Convert.ToString(i));
            driver.FindElement(By.Id("jform_city")).Clear();
            driver.FindElement(By.Id("jform_city")).SendKeys("Test City" + Convert.ToString(i));
            new SelectElement(driver.FindElement(By.Id("jform_country"))).SelectByText("Australia");
            Thread.Sleep(2000);
            new SelectElement(driver.FindElement(By.Id("jform_stateval"))).SelectByText("Australian Capital Territory");
            driver.FindElement(By.Id("jform_postcode")).Clear();
            driver.FindElement(By.Id("jform_postcode")).SendKeys("1000");
            driver.FindElement(By.Id("jform_email")).Clear();
            driver.FindElement(By.Id("jform_email")).SendKeys("testbusiness"+Convert.ToString(i)+"@email.com");
            driver.FindElement(By.Id("jform_phone")).Clear();
            driver.FindElement(By.Id("jform_phone")).SendKeys("1000000000");
            driver.FindElement(By.Id("jform_mobile")).Clear();
            driver.FindElement(By.Id("jform_mobile")).SendKeys("2000000000");
            driver.FindElement(By.Id("jform_website")).Clear();
            driver.FindElement(By.Id("jform_website")).SendKeys("http://www.testbusiness"+Convert.ToString(i)+".com");
            //driver.FindElement(By.CssSelector("input[type=\"button\"]")).Click();
            driver.FindElement(By.XPath("//div[@id='tabs']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.XPath("//input[@id='check1']")).Click();
            new SelectElement(driver.FindElement(By.Name("openhour1"))).SelectByText("8");
            new SelectElement(driver.FindElement(By.Name("close_hour1"))).SelectByText("12");
            new SelectElement(driver.FindElement(By.Name("breakopenhour1"))).SelectByText("13");
            new SelectElement(driver.FindElement(By.Name("breakclosehour1"))).SelectByText("20");
            //Thread.Sleep(5000);
            //driver.FindElement(By.CssSelector("a.toolbar > input.bluebutt")).Click();
            driver.FindElement(By.XPath("//div[@id='tabs']/ul/li[3]/a/span")).Click();
            new SelectElement(driver.FindElement(By.Id("services_areas0"))).SelectByText("Tinting");
            new SelectElement(driver.FindElement(By.Name("duration0"))).SelectByText("01:00:00");
            driver.FindElement(By.Name("cost0")).Clear();
            driver.FindElement(By.Name("cost0")).SendKeys("100");
            driver.FindElement(By.Name("jform_title0")).Clear();
            driver.FindElement(By.Name("jform_title0")).SendKeys("Tinting" + Convert.ToString(i));
            driver.FindElement(By.Id("serv_description_add0")).Clear();
            driver.FindElement(By.Id("serv_description_add0")).SendKeys("Tinting"+Convert.ToString(i)+ " Service Description");
            //driver.FindElement(By.XPath("(//input[@value='Save and Next'])[4]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [addSelection | name=tool_areas1[] | label=Massage Machine]]
            //driver.FindElement(By.CssSelector("td > a.toolbar > input.bluebutt")).Click();
            driver.FindElement(By.XPath("//div[@id='tabs']/ul/li[5]/a/span")).Click();
            driver.FindElement(By.Id("offer_name")).Clear();
            driver.FindElement(By.Id("offer_name")).SendKeys("Test Offer" + Convert.ToString(i));
            driver.FindElement(By.CssSelector("img.ui-datepicker-trigger")).Click();
            driver.FindElement(By.XPath("//input[@name='createdfrom']")).SendKeys("20-02-2013");
            driver.FindElement(By.XPath("//input[@name='createdto']")).SendKeys("31-03-2013");
            driver.FindElement(By.XPath("//textarea[@name='offerdesc']")).SendKeys("Deal");
            //driver.FindElement(By.CssSelector("div.offerdiv > input.bluebutt")).Click();
            //driver.FindElement(By.CssSelector("td > div.offerdiv > a.anchorbut > input.bluebutt")).Click();
            driver.FindElement(By.XPath("//div[@id='tabs']/ul/li[6]/a/span")).Click();
            driver.FindElement(By.Id("notice")).Clear();
            driver.FindElement(By.Id("notice")).SendKeys("Test Walls/Notices");
            driver.FindElement(By.XPath("//div[@id='tabs']/ul/li[7]/a/span")).Click();
               
            driver.FindElement(By.XPath("//div[@id='tabs']/ul/li[7]/a/span")).Click();
            driver.FindElement(By.Id("staffname0")).Clear();
            driver.FindElement(By.Id("staffname0")).SendKeys("test staff1");
            driver.FindElement(By.Id("staffpositon0")).Clear();
            driver.FindElement(By.Id("staffpositon0")).SendKeys("test role");
            new SelectElement(driver.FindElement(By.Name("staffgender0"))).SelectByText("Male");
            driver.FindElement(By.CssSelector("div.offerdiv > a.toolbar > input[type=\"button\"]")).Click();
           
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alert.Text;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
