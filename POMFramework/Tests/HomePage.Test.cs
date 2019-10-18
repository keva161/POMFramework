using Microsoft.VisualStudio.TestTools.UnitTesting;
using POMFramework.PageObjects;

namespace POMFramework
{
    // Main test class

    [TestClass]
    public class HomePageTest : BaseTest
    { 

        [TestMethod]
        public void Contact_us_Test()
        {
            Pages.Home.GoTo();
            Pages.Home.GoToContactUsPage();
            Pages.ContactUs.WaitForPageToLoad();
            Pages.ContactUs.TypeAMessage();
        }
    }
}
