using OpenQA.Selenium;
using System;

namespace POMFramework.PageObjects
{
    public class Pages
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
