using OpenQA.Selenium;

namespace POMFramework.PageObjects
{
    public class Homepage : BasePage
    {
        private HomepageMap Map;
        public Homepage(IWebDriver driver) : base(driver)
        {
            Map = new HomepageMap(Driver);
        }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        public void GoToContactUsPage()
        {
            Map.ContactUsLink.Click();
        }
    }
}
