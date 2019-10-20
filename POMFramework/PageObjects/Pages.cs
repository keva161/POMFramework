using OpenQA.Selenium;
using POMFramework.Locators;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    public class Pages : BaseTest
    {

        // This class is utilised by giving all of the page objects values when the initialise method is called prior to the tests execution. When this occurs, they can be referenced in the tests.

        public static Homepage Home;
        public static ContactUsPage ContactUs;

        public static void Init(IWebDriver Driver)
        {
            Home = new Homepage(Driver);
            ContactUs = new ContactUsPage(Driver);
        }
    }
}
