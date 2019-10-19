using OpenQA.Selenium;

namespace POMFramework.PageObjects
{
    public class Pages : BaseTest
    {
        public static Homepage Home;
        public static ContactUsPage ContactUs;
        public static void Init(IWebDriver Driver)
        {
            Home = new Homepage(Driver);
            ContactUs = new ContactUsPage(Driver);
        }
    }
}
