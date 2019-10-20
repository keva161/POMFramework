using OpenQA.Selenium;
using POMFramework.Locators;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;

namespace POMFramework.PageObjects
{
    public class ContactUsMap : BasePage
    {
        public ContactUsMap(IWebDriver driver) : base(driver)
        {
        }

        //Page elements used for synchronisation
        public By ContactUsPage => By.Id("message");
        //Page elements for interaction
        public IWebElement ContactUsMessageBox => Helper.LocateElement(Location.ID,"message");
        public IWebElement ContactUsLink => Helper.LocateElement(Location.ID,"contact-link");
        public IWebElement SubjectDropdownItems => Helper.LocateElement(Location.ID, "id_contact");
        public IWebElement ErrorMessage => Helper.LocateElement(Location.Xpath, "//*[@class=\"alert alert-danger\"]");
        public IWebElement SubmitButton => Helper.LocateElement(Location.ID, "submitMessage");

    }
}