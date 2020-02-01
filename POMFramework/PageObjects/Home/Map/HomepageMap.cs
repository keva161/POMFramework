using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;

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
        public IWebElement UsernameField => Helper.LocateElement(Locators.ID, "user-name");
        public IWebElement AcceptedUsernames => Helper.LocateElement(Locators.ID, "login_credentials");
        public IWebElement AcceptedPasswords => Helper.LocateElement(Locators.ClassName, "login_password");
        public IWebElement PasswordField => Helper.LocateElement(Locators.ID, "password");
        public IWebElement LoginButton => Helper.LocateElement(Locators.ClassName, "btn_action");

    }
}
