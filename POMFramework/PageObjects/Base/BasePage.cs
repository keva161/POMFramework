using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using POMFramework.Locators;

namespace POMFramework.PageObjects.Base

{
    public class BasePage
    {

        public IWebDriver Driver;

        public BasePage(IWebDriver driver)
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

        public IWebElement LocateElement(Location type, string name)
        {
            switch (type)
            {
                case Location.Xpath:
                    return Driver.FindElement(By.XPath(name));
                case Location.CssSelector:
                    return Driver.FindElement(By.CssSelector(name));
                case Location.ID:
                    return Driver.FindElement(By.Id(name));
                case Location.Name:
                    return Driver.FindElement(By.Name(name));
                case Location.LinkText:
                    return Driver.FindElement(By.LinkText(name));
                case Location.ClassName:
                    return Driver.FindElement(By.ClassName(name));
                case Location.PartialLinkText:
                    return Driver.FindElement(By.PartialLinkText(name));
                case Location.TagName:
                    return Driver.FindElement(By.TagName(name));
                default:
                    throw new ArgumentOutOfRangeException("Invalid locator");
            }
        }
    }
}