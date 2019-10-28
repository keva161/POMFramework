using NUnit.Framework;
using OpenQA.Selenium;
using POMFramework.PageObjects;
using POMFramework.Driver;

namespace POMFramework
{
    public class BaseTest
    {
        public IWebDriver driver { get; private set; }

        [SetUp]
        public void TestSetup()
        {
            var factory = new Factory();
            driver = factory.CreateBrowser(Network.Local, Browsertype.Chrome);
            Pages.Init(driver);
        }

        [TearDown]
        public void TestEnding()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
