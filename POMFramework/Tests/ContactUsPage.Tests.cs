using NUnit.Framework;
using POMFramework.PageObjects;

namespace POMFramework
{
    // Main test class

    [TestFixture]
    public class ContactUsPage : BaseTest
    {

        [Test]
        [Description("Test to ensure the 'Contact Us' page when submitted with no email displays an error message")]
        [Author("Kevin Tuck")]

        public void Error_Message_Is_Displayed_With_No_Email()
        {
            Pages.Home.GoTo();
            Pages.ContactUs.GoTo();
            Pages.ContactUs.TypeAMessage();
            Pages.ContactUs.SelectASubject("Webmaster");
            Pages.ContactUs.SubmitForm();

            var error = Pages.ContactUs.ErrorMessageIsDisplayed();

            Assert.IsTrue(error);
        }
    }
}
