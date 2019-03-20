using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.Layout
{
   partial class LayoutPageTests :TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority1)]
        public void Layout_VerifyThePresenceOfElements()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.See(Pages.LayoutPage.CountryIcon);
            I.See(Pages.LayoutPage.HomeHeaderTextLabel);
            I.See(Pages.LayoutPage.LoginIcon);
            I.See(Pages.LayoutPage.WishlistIcon);
            I.See(Pages.LayoutPage.BagIcon);
            I.See(Pages.LayoutPage.BardotLink);
            I.See(Pages.LayoutPage.BardotJuniorLink);
            I.AmOn(Pages.HomePage.Url);
        }
    }
}
