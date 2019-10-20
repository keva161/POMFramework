using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace POMFramework.Utilities
{
    public class Helpers
    {
        public IWebDriver Driver;
        public Helpers(IWebDriver driver)
        {
            Driver = driver;
        }

        public void HighlightElement(IWebElement element)
        {
            var jsDriver = (IJavaScriptExecutor)Driver;
            jsDriver.ExecuteScript("arguments[0].style.border='3px solid red'", element);
        }

        public void WaitForPageToLoad(By name, int duration = 10)
        {
            var Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(duration));
            Wait.Until(ExpectedConditions.ElementIsVisible(name));
        }

        public IWebElement LocateElement(Locators type, string name)
        {
            switch (type)
            {
                case Locators.Xpath:
                    return Driver.FindElement(By.XPath(name));
                case Locators.CssSelector:
                    return Driver.FindElement(By.CssSelector(name));
                case Locators.ID:
                    return Driver.FindElement(By.Id(name));
                case Locators.Name:
                    return Driver.FindElement(By.Name(name));
                case Locators.LinkText:
                    return Driver.FindElement(By.LinkText(name));
                case Locators.ClassName:
                    return Driver.FindElement(By.ClassName(name));
                case Locators.PartialLinkText:
                    return Driver.FindElement(By.PartialLinkText(name));
                case Locators.TagName:
                    return Driver.FindElement(By.TagName(name));
                default:
                    throw new ArgumentOutOfRangeException("Invalid locator");
            }
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }
    }
}
