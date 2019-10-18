using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;

namespace POMFramework.Driver
{
    // This class creates the webdriver object for the pages

    class Factory
    {
        internal IWebDriver CreateBrowser(Browsertype name)
        {
            switch (name)
            {
                case Browsertype.Chrome:
                    return GetChromeDriver();
                default:
                    throw new ArgumentOutOfRangeException("No such browser");
            }
        }
        private IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory, options);
        }
    }
}
