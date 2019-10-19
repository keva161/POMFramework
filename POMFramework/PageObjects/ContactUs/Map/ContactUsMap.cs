using OpenQA.Selenium;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    public class ContactUsMap : BasePage
    {
        public ContactUsMap(IWebDriver driver) : base(driver)
        {
        }

        //Page elements used for syncronisation
        public By ContactUsPage => By.Id("message");
        //Page elements for interaction
        public IWebElement ContactUsMessageBox => Driver.FindElement(By.Id("message"));
        public IWebElement ContactUsLink => Driver.FindElement(By.Id("contact-link"));
        public IWebElement SubjectDropdownItems => Driver.FindElement(By.Id("id_contact"));
        public IWebElement ErrorMessage => Driver.FindElement(By.XPath("//*[@class=\"alert alert-danger\"]"));
        public IWebElement SubmitButton => Driver.FindElement(By.Id("submitMessage"));
    }
}