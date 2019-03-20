using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
namespace Bardot.Tests.Footer
{
   partial class FooterTests :TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void Footer_VerifyThePresenceOfElements() {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.See(Pages.HomePage.AboutusPanel);
            I.See(Pages.HomePage.HelpPanel);
            I.See(Pages.HomePage.QuickLinksPanel);
            I.See(Pages.HomePage.FollowUsPanel);
            I.See(Pages.HomePage.SocialMediaLinks);
        }
    }
}
