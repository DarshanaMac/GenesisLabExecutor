using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ShaverShop.Web.Tests.Tests.Checkout
{
    /**
 *
 * This class covers the user actions of the shipping/billing details(checkout senario) page of Shaver Shop. 
 * 
 * @author Kanchana Liyanagamage
 * 
 */
    partial class CheckoutPageTests : TestBase
    {

        [Test]
        [Category(Categories.SSA_SmokeTest)]
        public void CheckoutPage_ExistingUserCheckout_PASS_Scenario()
        {
            I_CreateNewUserProfile();
            I.Open(Pages.ProductDetailsPage.Url);
            I.Click(Pages.ProductDetailsPage.AddToCartButon);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.Wait(20);
        }

        [Test]
        [Category(Categories.SSA_SmokeTest)]
        public void CheckoutPage_ExistingUserCheckout_FAIL_Scenario()
        {
            I_CreateNewUserProfile();
            I.Click(Pages.ProductDetailsPage.AddToCartButon);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.Wait(20);
        }


    }
}
