using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.Navigation
{
    /**
    *
    * This class covers the user actions of the Navigation Menu of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class NavigationMenuTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void NavigationMenu_ClickOnMainMenuItem()
        {
            I.Open(Pages.HomePage.Url);
            I.ClickMenuItemByDisplayText(Pages.NavigationMenu.TopLevelNavigationMenuItemsList, TestData.NavigationMenu.MainMenuItem);
            I.WaitUntilReady();
            I.SeeText(Pages.CategoryLandingPage.HeaderTitle, TestData.NavigationMenu.TopLevelNavigationMenuHeaderTitle);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void NavigationMenu_ClickOnSubMenuItem()
        {
            I.Open(Pages.HomePage.Url);
            I.MouseHoverMenuItemByDisplayText(Pages.NavigationMenu.TopLevelNavigationMenuItemsList, TestData.NavigationMenu.MainMenuItem);
            I.WaitUntilReady();
            I.ClickMenuItemByDisplayText(Pages.NavigationMenu.SubLevelNavigationMenuItemsList, TestData.NavigationMenu.SubMenuItem);
            I.WaitUntilReady();
            I.SeeText(Pages.CategoryListingPage.HeaderTitle, TestData.NavigationMenu.SubLevelNavigationMenuHeaderTitle);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void NavigationMenu_ClickOnBottomMenuItem()
        {
            I.Open(Pages.HomePage.Url);
            I.MouseHoverMenuItemByDisplayText(Pages.NavigationMenu.TopLevelNavigationMenuItemsList, TestData.NavigationMenu.MainMenuItem);
            I.WaitUntilReady();
            I.MouseHoverMenuItemByDisplayText(Pages.NavigationMenu.SubLevelNavigationMenuItemsList, TestData.NavigationMenu.SubMenuItem);
            I.WaitUntilReady();
            I.ClickMenuItemByDisplayText(Pages.NavigationMenu.BottomLevelNavigationMenuItemsList, TestData.NavigationMenu.BottomMenu);
            I.WaitUntilReady();
            I.SeeText(Pages.CategoryListingPage.HeaderTitle, TestData.NavigationMenu.BottomLevelNavigationMenuHeaderTitle);
        }
    }
}
