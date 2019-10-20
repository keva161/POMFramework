using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    // This object stores all the methods available to the page object

    public class ContactUsPage : BasePage
    {
        public ContactUsMap Map;

        public ContactUsPage(IWebDriver driver) : base(driver)
        {
            Map = new ContactUsMap(driver);

        }

        public void GoTo()
        {
            Map.ContactUsLink.Click();
            Helper.WaitForPageToLoad(Map.ContactUsPage);
            
        }

        public void TypeAMessage()
        {
            Map.ContactUsMessageBox.SendKeys("Hey this is a test of your system!");
        }

        public void SelectASubject(string option)
        {
            var select = new SelectElement(Map.SubjectDropdownItems);
            select.SelectByText(option);
        }

        public void SubmitForm()
        {
            Map.SubmitButton.Click();
        }

        public bool ErrorMessageIsDisplayed()
        {
            var result = Map.ErrorMessage.Displayed;
            return result;
        }

        public string CurrentUrl()
        {
            var url = Helper.GetCurrentUrl();
            return url;
        }
    }
}
