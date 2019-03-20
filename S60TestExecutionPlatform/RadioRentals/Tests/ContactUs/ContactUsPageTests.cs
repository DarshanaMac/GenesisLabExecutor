using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ContactUs
{
    partial class ContactUsPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ContactUsPage_NavigateToContactUsPage()
        {
            I.Open(Pages.ContactUsPage.Url);            
            I.AmOn(Pages.ContactUsPage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ContactUsPage_PresenceOfElements()
        {
            I.Open(Pages.ContactUsPage.Url);
            I.See(Pages.ContactUsPage.FullNameTextField);
            I.See(Pages.ContactUsPage.EmailTextField);
            I.See(Pages.ContactUsPage.MobileTextField);
            I.See(Pages.ContactUsPage.FeedbackTextField);
            I.See(Pages.ContactUsPage.SubmitButton);
        }
    }
}
