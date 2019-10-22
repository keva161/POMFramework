using OpenQA.Selenium;

namespace POMFramework.PageObjects
{
    internal class Pages : BaseTest
    {

        // This class is utilised by giving all of the page objects values when the initialise method is called prior to the tests execution. When this occurs, they can be referenced in the tests.

        public static Homepage Home;
        public static ContactUsPage ContactUs;

        public static void Init(IWebDriver driver)
        {
            Home = new Homepage(driver);
            ContactUs = new ContactUsPage(driver);
        }
    }
}
