using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFramework.PageObjects
{
    public class ContactUsMap : BasePage
    {
        public ContactUsMap(IWebDriver driver) : base(driver)
        {
        }

        public By ContactUsPage => By.Id("message");
        public IWebElement ContactUsMessageBox => Driver.FindElement(By.Id("message"));
    }
}