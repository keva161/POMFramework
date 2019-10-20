using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;

namespace POMFramework.PageObjects
{
    internal class ContactUsMap : BasePage
    {
        public ContactUsMap(IWebDriver driver) : base(driver)
        {
        }

        //Page elements used for synchronisation
        public By ContactUsPage => By.Id("message");
        //Page elements for interaction
        public IWebElement ContactUsMessageBox => Helper.LocateElement(Locators.ID,"message");
        public IWebElement ContactUsLink => Helper.LocateElement(Locators.ID,"contact-link");
        public IWebElement SubjectDropdownItems => Helper.LocateElement(Locators.ID, "id_contact");
        public IWebElement ErrorMessage => Helper.LocateElement(Locators.Xpath, "//*[@class=\"alert alert-danger\"]");
        public IWebElement SubmitButton => Helper.LocateElement(Locators.ID, "submitMessage");

    }
}