using OpenQA.Selenium;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    public class HomepageMap : BasePage
    {
        public HomepageMap(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement ContactUsLink => Driver.FindElement(By.Id("contact-link"));
    }
}
