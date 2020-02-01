using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    // This object stores all the methods available to the page object

    public class InventoryPage : BasePage
    {
        public readonly InventoryPageMap Map;

        public InventoryPage(IWebDriver driver) : base(driver)
        {
            Map = new InventoryPageMap(driver);

        }
        public void LogOut()
        {
            Map.HamBurgerMenu.Click();
            Helper.WaitForPageToLoad(Map.SlideOutMenu);
            Map.LogOutLink.Click();
            Helper.WaitForPageToLoad(Map.BotImg);
        }

        public void SortByMostExpensive()
        {
            var select = new SelectElement(Map.ProductSort);
            select.SelectByValue("hilo");
        }

        public void AddItemToCart()
        {
            Map.AddItemToCart[0].Click();
            Helper.WaitForTextToBePresent(Map.ShoppingCart, "1");
        }

        public void CheckOut()
        {
            Map.ShoppingCart.Click();
            Map.CheckoutButton.Click();


        }

        public void AddAllItemsToCart()
        {
            foreach (var button in Map.AllStoreItems)
            {
                button.Click();
            }
        }

    }
}
