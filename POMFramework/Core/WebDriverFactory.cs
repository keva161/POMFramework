using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace POMFramework.Driver
{
    // This class creates the webdriver object for the pages

    internal class Factory
    {
        internal IWebDriver CreateBrowser(Network type, BrowserType name)
        {
            return type switch
            {
                Network.Local => (name switch
                {
                    BrowserType.Chrome => GetChromeDriver(),
                    BrowserType.Edge => new EdgeDriver(),
                    BrowserType.Firefox => GetFirefoxDriver(),
                    _ => throw new ArgumentOutOfRangeException(name.ToString(), $"No such browser {name.ToString()}")
                }),
                Network.Remote => CreateSauceDriver(),
                _ => throw new ArgumentOutOfRangeException(type.ToString(), $"Unknown Environment {type.ToString()}")
            };
        }

        private IWebDriver GetFirefoxDriver()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--start-maximized");
            
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver(options);
        }

        private IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver(options);
        }
        private  IWebDriver CreateSauceDriver()
        {
            var sauceUserName = Environment.GetEnvironmentVariable("SAUCE_USERNAME", EnvironmentVariableTarget.User);
            var sauceAccessKey = Environment.GetEnvironmentVariable("SAUCE_ACCESS_KEY", EnvironmentVariableTarget.User);

            var options = new ChromeOptions
            {
                PlatformName = "Windows 10",
                BrowserVersion = "latest",
                UseSpecCompliantProtocol = true
            };
            
            var sauceOptions = new Dictionary<string, object>
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
