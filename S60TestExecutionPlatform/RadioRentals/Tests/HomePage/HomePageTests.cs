using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.HomePage
{
    /**
    *
    * This class covers the user actions of the Home page of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class HomePageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.Demo)]
        public void HomePage_NavigateToHomePage()
        {
            I.Open(Pages.HomePage.Url);
            I.AmOn(Pages.HomePage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void HomePage_PresenceOfElements()
        {
            I.Open(Pages.HomePage.Url);
            I.SeeInTitle(TestData.HomePage.PageTitle);
            I.See(Pages.LayoutPage.Logo);
            I.See(Pages.LayoutPage.SearchTextField);
            I.See(Pages.LayoutPage.LoginLink);
            I.See(Pages.LayoutPage.AboutRadioRentalsLink);
            I.See(Pages.LayoutPage.StoreLocatorLink);
            I.See(Pages.LayoutPage.ContactUsLink);
            I.See(Pages.LayoutPage.LocationButton);
            I.See(Pages.LayoutPage.CartButton);
            I.See(Pages.LayoutPage.ApplyOnlineButton);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void HomePage_VerifyBrandListInHome() {
            I.Open(Pages.HomePage.Url);
            I.See(Pages.HomePage.BrandsPanel);
            I.See(Pages.HomePage.ViewAllBrandsButton);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void HomePage_NavigationToBrandPage()
        {
            I.Open(Pages.BrandListPage.Url);
            I.WaitUntilReady();
            I.AmOn(Pages.BrandListPage.Url);
        }
    }
}
