using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using System;

namespace POMFramework.PageObjects
{
    // This class stores all of the methods availible to the page class

    public class HomePage : BasePage
    {
        public HomePageMap Map;
        public HomePage(IWebDriver driver) : base(driver)
        {
            // Creates a new mapping file when the page object is created

            Map = new HomePageMap(driver);
        }

        // Test methods availible that are availible to the tast cases.

        public void GoTo()
        {
            Helper.GoToUrl("https://www.saucedemo.com/");
        }

        public void Login()
        {

            string username = Map.AcceptatedUsernames.Text;
            string[] username_result = username.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            Map.Username_Field.SendKeys(username_result[1]);

            string password = Map.AcceptedPasswords.Text;
            string[] password_result = password.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            Map.Password_Field.SendKeys(password_result[1]);

            Map.LoginButton.Click();

            Helper.WaitForPageToLoad(Map.InventoryContainer);
        }

    }
}