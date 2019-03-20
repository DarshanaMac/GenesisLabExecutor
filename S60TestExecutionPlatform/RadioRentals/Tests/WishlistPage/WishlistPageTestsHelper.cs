using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.WishlistPage
{
   partial class WishlistPageTests : TestBase
    {
        public string I_GetProductNames(int index)
        {
            string ProductPDP= I_StoreProductName(Pages.CategoryLandingPage.ItemTitle, 0);
            return ProductPDP;
        }
        public string I_StoreProductName(object element, int index)
        {
            string ProductName = I.GetTextByIndex(element, index);
            return ProductName;
        }
        public void I_VerifyProductsWishList(int index) {
            string productPDP = I_GetProductNames(index);
            string wishlistitem= I_GetProductNames(index);
            if (productPDP.Equals(wishlistitem))
            {
                I.See(Pages.WishListPage.WishListPageHeaderTitle);
            }
        }
    }
}
