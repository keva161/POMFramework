using Microsoft.VisualStudio.TestTools.UnitTesting;
using POMFramework.PageObjects;

namespace POMFramework
{
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
