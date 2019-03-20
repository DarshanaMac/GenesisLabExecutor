using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.WishlistPage
{

    /**
    *
    * This class covers the user actions of the wishlist page of Radio Rentals. 
    * 
    * @author Darshana Konara
    * 
    */
    partial class WishlistPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void WishlistPage_VerifySuccessfulItemAddingToWishlist()
        {
            I.Open(Pages.CategoryLandingPage.Url);
            I_GetProductNames(1);
            I.Click(Pages.CategoryLandingPage.WishListIcon);
            I.Click(Pages.LayoutPage.WishListLink);
            I_VerifyProductsWishList(1);
        }
    }
}
