using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using POMFramework.PageObjects;
using POMFramework.Driver;
using OpenQA.Selenium.Support.UI;

namespace POMFramework
{
    public class BaseTest
    {
        public IWebDriver Driver;

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
