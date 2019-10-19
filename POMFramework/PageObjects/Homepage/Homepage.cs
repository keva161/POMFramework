using OpenQA.Selenium;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    public class Homepage : BasePage
    {
        public HomepageMap Map;
        public Homepage(IWebDriver driver) : base(driver)
        {
            Map = new HomepageMap(Driver);
        }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/");
        }
    }
}
