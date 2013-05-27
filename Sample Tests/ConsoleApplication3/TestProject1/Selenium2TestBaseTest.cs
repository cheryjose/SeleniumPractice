using SeleniumTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for Selenium2TestBaseTest and is intended
    ///to contain all Selenium2TestBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Selenium2TestBaseTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Selenium2TestBase Constructor
        ///</summary>
        [TestMethod()]
        public void Selenium2TestBaseConstructorTest()
        {
            Selenium2TestBase target = new Selenium2TestBase();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CloseAlertAndGetItsText
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bank.exe")]
        public void CloseAlertAndGetItsTextTest()
        {
            Selenium2TestBase_Accessor target = new Selenium2TestBase_Accessor(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.CloseAlertAndGetItsText();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsElementPresent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bank.exe")]
        public void IsElementPresentTest()
        {
            Selenium2TestBase_Accessor target = new Selenium2TestBase_Accessor(); // TODO: Initialize to an appropriate value
            By by = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsElementPresent(by);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetupTest
        ///</summary>
        [TestMethod()]
        public void SetupTestTest()
        {
            Selenium2TestBase target = new Selenium2TestBase(); // TODO: Initialize to an appropriate value
            target.SetupTest();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TeardownTest
        ///</summary>
        [TestMethod()]
        public void TeardownTestTest()
        {
            Selenium2TestBase target = new Selenium2TestBase(); // TODO: Initialize to an appropriate value
            target.TeardownTest();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TheSelenium2TestBaseTest
        ///</summary>
        [TestMethod()]
        public void TheSelenium2TestBaseTestTest()
        {
            Selenium2TestBase target = new Selenium2TestBase(); // TODO: Initialize to an appropriate value
            target.TheSelenium2TestBaseTest();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
