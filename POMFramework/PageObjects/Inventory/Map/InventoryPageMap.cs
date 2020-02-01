using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;
using System.Collections.Generic;

namespace POMFramework.PageObjects
{
    public class InventoryPageMap : BasePage
    {
        public InventoryPageMap(IWebDriver driver) : base(driver)
        {
        }

        //Page elements used for synchronisation
        public By SlideOutMenu => By.ClassName("bm-item-list");
        public By BotImg => By.ClassName("bot_column");


        //Page elements for interaction
        public IWebElement HamBurgerMenu => Helper.LocateElement(Locators.ClassName, "bm-burger-button");
        public IWebElement LogOutLink => Helper.LocateElement(Locators.Xpath, "//a[@id='logout_sidebar_link']");
        public IWebElement ProductSort => Helper.LocateElement(Locators.ClassName, "product_sort_container");
        public IList<IWebElement> AddItemToCart => Helper.LocateElements(Locators.Xpath, "//button[contains(text(), 'ADD TO CART')]");
        public IWebElement ShoppingCart => Helper.LocateElement(Locators.Xpath, "//*[@id=\"shopping_cart_container\"]/a/span");
        public IWebElement CheckoutButton => Helper.LocateElement(Locators.Xpath, "//a[contains(text(), 'CHECKOUT')]");
        public IEnumerable<IWebElement> AllStoreItems => Helper.LocateElements(Locators.Xpath, "//div[@class=\"inventory_item\"]//button");

    }
}