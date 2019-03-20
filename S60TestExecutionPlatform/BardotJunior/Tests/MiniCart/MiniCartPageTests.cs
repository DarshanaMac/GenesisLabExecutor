using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests.MiniCart
{
    partial class MiniCartPageTests : TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void MiniCartPage_ViewMiniCartWithEmptyProducts()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.Click(Pages.LayoutPage.BagIcon);
            I.SeeText(Pages.ShoppingCartPage.EmptyProductPageHeaderLabel, TestData.ShoppingCartPage.EmptyProductPageHeader);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRDJ_Confident)]
        public void MiniCartPage_ViewProductInMiniCart()
        {
            I.NavigateToPage(Pages.ProductDetailsPage.Url,"Yes");
            I.Wait(2);
            I_HandlePopUp();
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I.Wait(3);
            I_ClickActiveSwatch();
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            string productname = I_StoreProductName(Pages.ProductDetailsPage.ProductNameHeader, 0);
            I.Wait(2);
            I.Click(Pages.LayoutPage.BagIcon);
            I_VerifyProductName(productname);
        }


    }
}
