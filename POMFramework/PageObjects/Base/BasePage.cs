using OpenQA.Selenium;
using POMFramework.Utilities;

namespace POMFramework.PageObjects.Base

{
    public class BasePage
    {
        protected Helpers Helper { get; }

        protected BasePage(IWebDriver driver)
        {
            Helper = new Helpers(driver);
        }
    }
}