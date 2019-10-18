using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using POMFramework.PageObjects;
using POMFramework.Driver;
using OpenQA.Selenium.Support.UI;

namespace POMFramework
{
    public class BaseTest
    {
        // This class contains the setup/teardown methods and keeps the main test class clean. It also isolates Selenium from the test cases meaning that the tests are not depedent on the Selenium framework and can be substituted for another framework later on. 
        
        public IWebDriver Driver { get; private set; }

        [TestInitialize]
        public void TestSetup()
        {
            var factory = new Factory();
            Driver = factory.CreateBrowser(Browsertype.Chrome);
            Pages.Init(Driver);
        }

        [TestCleanup]
        public void TestEnding()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
