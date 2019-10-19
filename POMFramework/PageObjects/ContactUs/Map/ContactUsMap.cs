using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using System.Collections.Generic;

namespace POMFramework.PageObjects
{
    public class ContactUsMap : BasePage
    {
        public ContactUsMap(IWebDriver driver) : base(driver)
        {
        }


        public By ContactUsPage => By.Id("message");
        public IWebElement ContactUsMessageBox => Driver.FindElement(By.Id("message"));
        public IWebElement ContactUsLink => Driver.FindElement(By.Id("contact-link"));
        public IWebElement SubjectDropdownItems => Driver.FindElement(By.Id("id_contact"));
        public IWebElement ErrorMessage => Driver.FindElement(By.XPath("//*[@class=\"alert alert-danger\"]"));
        public IWebElement SubmitButton => Driver.FindElement(By.Id("submitMessage"));
    }
}