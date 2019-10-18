using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace POMFramework.PageObjects

{
    public class BasePage
    {
        protected IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        internal void HighlightElement(IWebElement element)
        {
            var jsDriver = (IJavaScriptExecutor)Driver;
            jsDriver.ExecuteScript("arguments[0].style.border='3px solid red'", element);
        }
        public void WaitForPageToLoad(By name)
        {
            var Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Wait.Until(ExpectedConditions.ElementIsVisible(name));
        }
    }
}
