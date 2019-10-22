using NUnit.Framework;
using OpenQA.Selenium;
using POMFramework.PageObjects;
using POMFramework.Driver;

namespace POMFramework
{
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [SetUp]
        public void TestSetup()
        {
            var factory = new Factory();
            Driver = factory.CreateBrowser(Network.Local, Browsertype.Firefox);
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
