using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests
{
    /**
    *
    * This class covers the user actions of the Store Locator page of Bardot. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class StoreLocatorPageTests : TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void StoreLocator_NavigateToStoreLocatorPage()
        {
            I.Open(Pages.StoreLocatorPage.Url);
            I_HandlePopUp();
            I.AmOn(Pages.StoreLocatorPage.Url);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void StoreLocator_PresenceOfElements()
        {
            I.Open(Pages.StoreLocatorPage.Url);
            I_HandlePopUp();
            I.WaitUntilReady();
            I.See(Pages.StoreLocatorPage.SearchByCurrentLocationButton);
            I.SeeDropDownListForSFCC(Pages.StoreLocatorPage.MaximumDistanceDropDownList);
            I.See(Pages.StoreLocatorPage.PostcodeTextField);
            I.See(Pages.StoreLocatorPage.SearchButton);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void StoreLocator_FindAStore()
        {
            I.Open(Pages.StoreLocatorPage.Url);
            I_HandlePopUp();
            I.WaitUntilReady();
            I.ClickDropDownListSSA(Pages.StoreLocatorPage.MaximumDistanceDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListSSA(Pages.StoreLocatorPage.MaximumDistanceDropDownList, I_GetMaximumDistance((string)TestData.StoreLocatorPage.MaximumDistance));
            I.WaitUntilReady();
            I.Fill(Pages.StoreLocatorPage.PostcodeTextField, TestData.StoreLocatorPage.PostCode);
            I.Click(Pages.StoreLocatorPage.SearchButton);
            I.WaitUntilReady();
            I.See(Pages.StoreLocatorPage.StoreList);
        }
    }
}
