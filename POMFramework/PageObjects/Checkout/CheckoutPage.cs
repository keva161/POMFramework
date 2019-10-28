using OpenQA.Selenium;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    class CheckoutPage : BasePage
    {
        public CheckoutPageMap Map;
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
            // Creates a new mapping file when the page object is created

            Map = new CheckoutPageMap(driver);
        }

        public void EnterDetails(string firstname, string lastname, string postcode)
        {
            Helper.WaitForPageToLoad(Map.CheckoutContainer);
            Map.FirstNameField.SendKeys(firstname);
            Map.LastnameField.SendKeys(lastname);
            Map.PostalcodeField.SendKeys(postcode);
            Map.ContinueButton.Click();
        }

        public void FinishCheckout()
        {
            Helper.WaitForPageToLoad(Map.SummaryContainer);
            Map.FinishCheckoutButton.Click();
        }

    }
}
