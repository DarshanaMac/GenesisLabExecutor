using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests.ContactUs
{
    /**
    *
    * This class covers the user actions of the ContactUs page of Bardot. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class ContactUsPageTests : TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority8)]
        public void ContactUsPage_NavigateToContactUsPage()
        {
            I.NavigateToPage(Pages.ContactUsPage.Url,"");
            I.AmOn(Pages.ContactUsPage.Url);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority8)]
        public void ContactUsPage_PresenceOfElements()
        {
            I.NavigateToPage(Pages.ContactUsPage.Url, "");
            I.WaitUntilReady();
            I.Click(Pages.ContactUsPage.ContactusTile);
            I.See(Pages.ContactUsPage.PageHeader);
            I.See(Pages.ContactUsPage.PageContent);
        }
    }
}
