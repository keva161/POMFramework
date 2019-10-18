using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMFramework.Driver;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace POMFramework.PageObjects
{
    public class ContactUsPage : BasePage
    {
        private ContactUsMap Map;
        public ContactUsPage(IWebDriver driver) : base(driver)
        {
            Map = new ContactUsMap(Driver);
        }

        public void TypeAMessage()
        {
            HighlightElement(Map.ContactUsMessageBox);
            Map.ContactUsMessageBox.SendKeys("Hey this is a test of your system!");
        }
        public void WaitForPageToLoad()
        {
            WaitForPageToLoad(Map.ContactUsPage);
        }
    }
}
