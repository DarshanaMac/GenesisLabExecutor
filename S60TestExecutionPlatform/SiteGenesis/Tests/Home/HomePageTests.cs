using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.Home
{
    class HomePageTests  :TestBase
    {
        public void HomePage_NavigateToHomePage() {
            I.Open(Pages.HomePage.Url);
            I.AmOn(Pages.HomePage.Url);
        }

        public void HomePage_PresenceOfElements()
        {
            I.Open(Pages.HomePage.Url);
            I.See(Pages.LayoutPage.SearchTextField);
            I.See(Pages.LayoutPage.LocationIcon);
            I.See(Pages.LayoutPage.UserProfileIcon);
            I.See(Pages.LayoutPage.CartIcon);
            I.See(Pages.LayoutPage.ProductTopCategoriesLinks);
            I.See(Pages.LayoutPage.PopUpYesButton);
        }
    }
}
