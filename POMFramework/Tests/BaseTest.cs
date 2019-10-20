using NUnit.Framework;
using OpenQA.Selenium;
using POMFramework.PageObjects;
using POMFramework.Driver;

namespace POMFramework
{
    public abstract class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [SetUp]
        public void TestSetup()
        {
            var factory = new Factory();
            Driver = factory.CreateBrowser(Browsertype.Chrome);
            Pages.Init(Driver);
        }

        [TearDown]
        public void TestEnding()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
