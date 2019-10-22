using OpenQA.Selenium;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    // This class stores all of the methods availible to the page class

    public class Homepage : BasePage
    {
        public HomepageMap Map;
        public Homepage(IWebDriver driver) : base(driver)
        {
            // Creates a new mapping file when the page object is created

            Map = new HomepageMap(driver);
        }

        // Test methods availible that are availible to the tast cases.

        public void GoTo()
        {
            Helper.GoToUrl("http://automationpractice.com/");
            Helper.WaitForPageToLoad(Map.HomepageContent);
        }
    }
}
