using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFramework.PageObjects
{
    // This class stores the locators to all of the elements that can be interated with on the page

    public class ContactUsMap : BasePage
    {
        public ContactUsMap(IWebDriver driver) : base(driver)
        {
        }

        public By ContactUsPage => By.Id("message");

        public IWebElement ContactUsMessageBox => Driver.FindElement(By.("message"));
    }
}