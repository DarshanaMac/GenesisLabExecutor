using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.StoreLocator
{
    /**
   *
   * This class covers the user actions of the Store Locator page of Radio Rentals. 
   * 
   * @author Kanchana Liyanagamage
   * 
   */
    partial class StoreLocatorPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void StoreLocatorPage_NavigateToStoreLocatorPage()
        {
            I.Open(Pages.StoreLocatorPage.Url);
            I.AmOn(Pages.StoreLocatorPage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void StoreLocatorPage_PresenceOfElements()
        {
            I.Open(Pages.StoreLocatorPage.Url);
            I.SeeText(Pages.StoreLocatorPage.HeaderTitle, TestData.StoreLocatorPage.HeaderTitle);
            I.See(Pages.StoreLocatorPage.UseMyLocationButton);
            I.See(Pages.StoreLocatorPage.ShowAllStoresButton);
            I.See(Pages.StoreLocatorPage.SearchTextField);
            I.WaitUntilReady();
            I.Click(Pages.StoreLocatorPage.ViewAllStoresLink);
            I.WaitUntilReady();
            I.See(Pages.StoreLocatorPage.ShowMoreButton);
            I.See(Pages.StoreLocatorPage.MapIcon);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void StoreLocatorPage_SearchAStore()
        {
            I.Open(Pages.StoreLocatorPage.Url);
            I.Fill(Pages.StoreLocatorPage.SearchTextField, TestData.ResidentialDetailsYourAddressPage.Suburb);
            I.ClickKeyBoardEvent(Pages.StoreLocatorPage.SearchTextField,"DOWN");
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.StoreLocatorPage.SearchTextField, "ENTER");
            I.Click(Pages.StoreLocatorPage.SearchButton);
            I.WaitUntilReady();
            I_CompareSearchAndResult();
        }
    }
}
