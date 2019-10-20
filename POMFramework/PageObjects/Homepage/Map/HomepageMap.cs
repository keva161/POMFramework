using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;

namespace POMFramework.PageObjects
{
    // This class stores the locators to all of the elements that can be interacted with on the page


    internal class HomepageMap : BasePage
    {
        public HomepageMap(IWebDriver driver) : base(driver)
        {
        }

        //Page elements used for synchronisation
        public By HomepageContent => By.Id("center_column");
        //Page elements for interaction
        public IWebElement ContactUsLink => Helper.LocateElement(Locators.ID, "contact-link");
    }
}
