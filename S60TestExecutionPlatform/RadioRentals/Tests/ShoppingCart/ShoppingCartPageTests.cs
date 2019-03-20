using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ShoppingCart
{
    /**
    *
    * This class covers the user actions of the shopping cart page of Radio Rentals. 
    * 
    * @author Darshana Konara
    * 
    */
    partial class ShoppingCartPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ShoppingCartPage_NavigateToShoppingRentCartBuyCartPage()
        {
            I.Open(Pages.ShoppingCartPage.Url);
            I.SeeInTitle(TestData.ShoppingCartByOrRentPage.PageTitle);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ShoppingCartPage_PresenceOfElements()
        {
            I_LoginAsCustomer();
            I.WaitUntilReady();
            I.Click(Pages.LayoutPage.CartButton);
            I.WaitUntilReady();
            I.Click(Pages.LayoutPage.ViewCartButton);
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab);
            I_RemoveItems();
            I.Open(TestData.Products.InStock.Url);
            I.WaitUntilReady();
            I.See(Pages.ProductDetailsPage.ProductDetail);
            I.RefreshPage();
            I.WaitUntilReady();
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.See(Pages.ShoppingCartPage.RentCartTab);
            I.See(Pages.ShoppingCartPage.GoToBuyCartTab);
            I.See(Pages.ShoppingCartPage.ProductName);
            I.See(Pages.ShoppingCartPage.ProductPrice);
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab); 
            I.See(Pages.ShoppingCartPage.Total);
            I.See(Pages.ShoppingCartPage.CheckoutButton);
            I.See(Pages.ShoppingCartPage.ContinueShoppingButton);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void MiniCartPage_ViewMiniCartWithEmptyProducts()
        {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.CartButton);
            I.WaitUntilReady();
            I.SeeText(Pages.MiniCartPage.ItemsMessageLabel, TestData.MiniCartPage.WithoutItem);
            I.See(Pages.LayoutPage.ViewCartButton);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void MiniCartPage_ViewProductInMiniCart()
        {
            I_LoginAsCustomer();
            I.WaitUntilReady();
            I.Click(Pages.LayoutPage.CartButton);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.ViewCartButton);
            I_RemoveItemsRentCartAndBuyCart();
            I.WaitUntilReady();
            I.Open(TestData.Products.InStock.Url);
            I.WaitUntilReady();
            I.See(Pages.ProductDetailsPage.ProductDetail);
            I.RefreshPage();
            I.WaitUntilReady();
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.Wait(2);
            I.WaitUntilReady();
            I.See(Pages.MiniCartPage.MiniCartContent);
            I.See(Pages.MiniCartPage.ItemDescriptionPanel);
            I.WaitUntilReady();
            I.See(Pages.MiniCartPage.SubTotalLabel);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void VirtualProduct_VerifyVirtualProductInCart() {
            I_ChangeLocation();
            I.Click(Pages.LayoutPage.CartButton);
            I.WaitUntilReady();
            I.Click(Pages.LayoutPage.ViewCartButton);
            I_RemoveItemsRentCartAndBuyCart();
            I_AddItemToCart();
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab);
            I.WaitUntilReady();
            I.SeeEnabled(Pages.ShoppingCartPage.InstallationDropDownList);
        }
    }
}
