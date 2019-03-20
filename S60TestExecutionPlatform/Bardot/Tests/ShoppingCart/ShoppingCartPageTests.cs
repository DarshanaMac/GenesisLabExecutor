using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.ShoppingCart
{
    partial class ShoppingCartPageTests :TestBase 
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority6)]
        public void ShoppingCartPage_NavigateToShoppingCart() {
            I.Open(Pages.ShoppingCartPage.Url);
            I_HandlePopUp();
            I.See(Pages.ShoppingCartPage.EmptyProductPageHeaderLabel);
            I.AmOn(Pages.ShoppingCartPage.Url);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority6)]
        public void ShoppingCartPage_PresenceOfElements() {
            I.Open(Pages.ProductDetailsPage.Url);
            I_HandlePopUp();
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I.Wait(3);
            I_ClickActiveSwatch();
            I.WaitUntilReady();
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.Wait(2);
            string Productname = I.RememberText(Pages.ProductDetailsPage.ProductNameHeader);
            I.WaitUntilReady();
            I.NavigateToPage(Pages.ShoppingCartPage.Url,"Yes");
            I.SeeText(Pages.ShoppingCartPage.ProductName, Productname);
            I.See(Pages.ShoppingCartPage.TotalPriceLabel);
            I.See(Pages.ShoppingCartPage.CheckoutButton);
            I.See(Pages.ShoppingCartPage.EditLink);
            I.See(Pages.ShoppingCartPage.RemoveLink);
            I.See(Pages.ShoppingCartPage.PromotionTextField);
            I.See(Pages.ShoppingCartPage.AddPromotionButton);
        }
    }
}
