using OpenQA.Selenium;

namespace POMFramework.PageObjects
{
    internal class Pages : BaseTest
    {

        // This class is utilised by giving all of the page objects values when the initialise method is called prior to the tests execution. When this occurs, they can be referenced in the tests.

        public static HomePage Home;
        public static InventoryPage Inventory;
        public static CheckoutPage Checkout;

        public static void Init(IWebDriver driver)
        {
            Home = new HomePage(driver);
            Inventory = new InventoryPage(driver);
            Checkout = new CheckoutPage(driver);
        }
    }
}
