using OpenQA.Selenium;
using POMFramework.Utilities;

namespace POMFramework.PageObjects.Base

{
    internal abstract class BasePage
    {

        public IWebDriver Driver;
        public readonly Helpers Helper;

        public BasePage(IWebDriver driver)
        {
            Helper = new Helpers(driver);
            Driver = driver;
        }
    }
}