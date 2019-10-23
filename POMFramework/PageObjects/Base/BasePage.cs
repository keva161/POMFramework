using OpenQA.Selenium;
using POMFramework.Utilities;

namespace POMFramework.PageObjects.Base

{
    public class BasePage
    {

        public IWebDriver driver { get; private set; }
        public Helpers Helper { get; set; }

        public BasePage(IWebDriver Driver)
        {
            Helper = new Helpers(Driver);
            driver = Driver;
        }
    }
}