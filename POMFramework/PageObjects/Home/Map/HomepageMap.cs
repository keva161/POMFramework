using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;
using System.Collections.Generic;

namespace POMFramework.PageObjects
{
    // This class stores the locators to all of the elements that can be interacted with on the page


    public class HomePageMap : BasePage
    {
        public HomePageMap(IWebDriver driver) : base(driver)
        {
        }

        //Page elements used for synchronisation
        public By InventoryContainer => By.Id("inventory_container");

        //Page elements for interaction
        public IWebElement Username_Field => Helper.LocateElement(Locators.ID, "user-name");
        public IWebElement AcceptatedUsernames => Helper.LocateElement(Locators.ID, "login_credentials");
        public IWebElement AcceptedPasswords => Helper.LocateElement(Locators.ClassName, "login_password");
        public IWebElement Password_Field => Helper.LocateElement(Locators.ID, "password");
        public IWebElement LoginButton => Helper.LocateElement(Locators.ClassName, "btn_action");

    }
}
