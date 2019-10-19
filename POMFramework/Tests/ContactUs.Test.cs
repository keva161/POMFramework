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
            Pages.ContactUs.GoTo();
            Pages.ContactUs.WaitForPageToLoad();
            Pages.ContactUs.TypeAMessage();
            Pages.ContactUs.SelectASubject("Webmaster");
            Pages.ContactUs.SubmitForm();

            var error = Pages.ContactUs.ErrorMessageIsDisplayed();

            Assert.IsTrue(error);
            
        }
    }
}
