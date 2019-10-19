using OpenQA.Selenium;
using POMFramework.Locators;
using POMFramework.PageObjects.Base;

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
        public IWebElement ContactUsMessageBox => LocateElement(Location.ID,"message");
        public IWebElement ContactUsLink => LocateElement(Location.ID,"contact-link");
        public IWebElement SubjectDropdownItems => LocateElement(Location.ID, "id_contact");
        public IWebElement ErrorMessage => LocateElement(Location.Xpath, "//*[@class=\"alert alert-danger\"]");
        public IWebElement SubmitButton => LocateElement(Location.ID, "submitMessage");
    }
}