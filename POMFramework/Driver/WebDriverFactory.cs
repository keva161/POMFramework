using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace POMFramework.Driver
{
    // This class creates the webdriver object for the pages

    class Factory
    {
        internal IWebDriver CreateBrowser(Network type, Browsertype name)
        {
            switch (type)
            {
                case Network.Local:
                    switch (name)
                    {
                        case Browsertype.Chrome:
                            return GetChromeDriver();
                        case Browsertype.Edge:
                            return new EdgeDriver();
                        case Browsertype.Firefox:
                            return GetFirefoxDriver();
                        default:
                            throw new ArgumentOutOfRangeException("No such browser");
                    }
                case Network.Remote:
                    return CreateSauceDriver();
                default:
                    throw new ArgumentException("Unknown Environment");
            };

        }

        private IWebDriver GetFirefoxDriver()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--start-maximized");

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new FirefoxDriver(outPutDirectory, options);
        }

        private IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory, options);
        }
        private  IWebDriver CreateSauceDriver()
        {
            var sauceUserName = Environment.GetEnvironmentVariable("SAUCE_USERNAME", EnvironmentVariableTarget.User);
            var sauceAccessKey = Environment.GetEnvironmentVariable("SAUCE_ACCESS_KEY", EnvironmentVariableTarget.User);

            ChromeOptions options = new ChromeOptions
            {
                PlatformName = "Windows 10",
                BrowserVersion = "latest",
                UseSpecCompliantProtocol = true
            };
            
            Dictionary<string, object> sauceOptions = new Dictionary<string, object>
            {
                { "username", sauceUserName },
                { "accessKey", sauceAccessKey }
            };
            
            options.AddAdditionalCapability("sauce:options", sauceOptions, true);
            return new RemoteWebDriver(new Uri("http://ondemand.eu-central-1.saucelabs.com/wd/hub"),
                options.ToCapabilities(), TimeSpan.FromSeconds(600));
        }
    }
}
