using NUnit.Framework;
using POMFramework.PageObjects;

namespace POMFramework
{
    // Main test class

    [TestFixture]
    public class Homepage : BaseTest
    { 

        [Test]
        [Description("Test to ensure the 'Contact Us' page can be accessed from the home page")]
        [Author("Kevin Tuck")]

        public void ContactUs_Page_Is_Accessible()
        {
            Pages.Home.GoTo();
            Pages.ContactUs.GoTo();

            var url = Pages.ContactUs.CurrentUrl();

            Assert.AreEqual("http://automationpractice.com/index.php?controller=contact", url);
        }
    }
}
