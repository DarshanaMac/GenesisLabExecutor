using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.Wishlist
{
    partial class WishlistPageTests :TestBase
    {
        object emailAddress = I_GenerateUniqueMailAddressForNewProfile();

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Confident)]
        public void WishlistPage_VerifySuccessfulItemAddingToWishlist() {
            I_CreateNewUser(emailAddress);
            I.NavigateToPage(Pages.ProductDetailsPage.Url,"Yes");
            I.WaitUntilReady();
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I.Wait(3);
            I_ClickActiveSwatch();
            I.Wait(3);
            string ItemName = I_StoreProductNameFromProductDetailsPage(Pages.ProductDetailsPage.ProductNameHeader);
            I.Click(Pages.ProductDetailsPage.WishListIcon);
            I.Wait(3);
            I.Click(Pages.LayoutPage.WishlistIcon);
            I.SeeText(Pages.WishlistPage.ProductName, ItemName);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void WishlistPage_PresenceOfElements() {
            I_CreateNewUser(emailAddress);
            I.NavigateToPage(Pages.ProductDetailsPage.Url, "Yes");
            I.WaitUntilReady();
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I.Wait(3);
            I_ClickActiveSwatch();
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.WishListIcon);
            I.Wait(3);
            I.Click(Pages.LayoutPage.WishlistIcon);
            I.See(Pages.WishlistPage.PageHeader);
            I.See(Pages.WishlistPage.ProductName);
            I.See(Pages.WishlistPage.AddToBagButton);
            I.See(Pages.WishlistPage.ProductImage);
        }
    }
}
