using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.ProductDetails
{
    partial class ProductDetailsPageTests : TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority3)]
        public void ProductDetailsPage_NavigateToTheProductDetailsPage()
        {
            I.Open(Pages.CategoryListingPage.Url);
            I_HandlePopUp();
            I.WaitUntilReady();
            I.ClickOnElementList(Pages.CategoryListingPage.ProductItemList,0);
            I.Wait(3);
            I.See(Pages.ProductDetailsPage.ProductNameHeader);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Confident)]
        public void ProductDetailsPage_PresenceOfElementsOfProductDetailsPage()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I_HandlePopUp();
            I.WaitUntilReady();
            I.See(Pages.ProductDetailsPage.ProductImage);
            I.See(Pages.ProductDetailsPage.ProductNameHeader);
            I.See(Pages.ProductDetailsPage.ProductDetailsPanel);
            I.Click(Pages.ProductDetailsPage.ShippingDetailsPanel);
            I.See(Pages.ProductDetailsPage.ProductPriceText);
            I.See(Pages.ProductDetailsPage.SocialMediaIcon);
        }
    }
}
