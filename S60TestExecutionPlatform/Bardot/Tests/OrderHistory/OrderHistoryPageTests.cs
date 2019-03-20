using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.OrderHistory
{
    partial class OrderHistoryPageTests :TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void OrderHistoryPage_NavigateToOrderHistoryPage() {
            I_CreateNewUser();
            I.Open(Pages.ProductDetailsPage.Url);
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
            //I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 2);
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ShoppingCartPage.CheckoutButton, "ENTER");
            I.WaitUntilReady();
            //Shipping Details Page
            I.Fill(Pages.ShippingAddressPage.FirstNameTextField, TestData.ShippingAddressPage.FirstName);
            I.Fill(Pages.ShippingAddressPage.LastNameTextField, TestData.ShippingAddressPage.LastName);
            I.Fill(Pages.ShippingAddressPage.Address1TextField, TestData.ShippingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "DOWN");
            I.Wait(3);
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "ENTER");
            I.Wait(2);
            I.Fill(Pages.ShippingAddressPage.PhoneTextField, TestData.ShippingAddressPage.ShippingPhoneNumber);
            I_VerifyFillData();
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.WaitUntilReady();
            //Billing Details Page
            I.Fill(Pages.BillingAddressPage.BillingEmailAddressTextField, TestData.BillingAddressPage.EmailAddress);
            I.Fill(Pages.BillingAddressPage.FirstNameTextField, TestData.BillingAddressPage.FirstName);
            I.Fill(Pages.BillingAddressPage.LastNameTextField, TestData.BillingAddressPage.LastName);
            I.Fill(Pages.BillingAddressPage.Address1TextField, TestData.BillingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "DOWN");
            I.Wait(3);
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "ENTER");
            I.Wait(2);
            I.Fill(Pages.BillingAddressPage.BillingPhoneNumber, TestData.BillingAddressPage.BillingPhoneNumber);
            I.Wait(3);
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.NameOnCardTextField, TestData.BillingAddressPage.CardHolderName);
            //I.Click(Pages.BillingAddressPage.VisaIcon);
            I.Wait(2);
            I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.VisaCardNumber);
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList);
            I.Wait(2);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList, I_GetMonthCode((string)TestData.BillingAddressPage.ExpirationMonth));
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList, I_GetYearCode((string)TestData.BillingAddressPage.ExpirationYear));
            I.Fill(Pages.BillingAddressPage.SecurityCodeTextField, TestData.BillingAddressPage.SecurityCode);
            I.Wait(2);
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            I.Wait(7);
            I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            I.Wait(2);
            I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            I.WaitUntilReady();
            I.Open(Pages.OrdersPage.Url);
            I.AmOn(Pages.OrdersPage.Url);
        }

        [Test]
        [Ignore ("It is not allowed to place orders in production")]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Confident)]
        public void OrderHistoryPage_PresenceOfElements() {
            I_CreateNewUser();
            I.Open(Pages.ProductDetailsPage.Url);
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I.Wait(3);
            I_ClickActiveSwatch();
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.Wait(2);
            I.ClickKeyBoardEvent(Pages.ShoppingCartPage.CheckoutButton, "ENTER");
            I.WaitUntilReady();
            //Shipping Details Page
            I.Fill(Pages.ShippingAddressPage.FirstNameTextField, TestData.ShippingAddressPage.FirstName);
            I.Fill(Pages.ShippingAddressPage.LastNameTextField, TestData.ShippingAddressPage.LastName);
            I.Fill(Pages.ShippingAddressPage.Address1TextField, TestData.ShippingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "DOWN");
            I.Wait(4);
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "ENTER");
            I.Wait(2);
            I.Fill(Pages.ShippingAddressPage.PhoneTextField, TestData.ShippingAddressPage.ShippingPhoneNumber);
            I_VerifyFillData();
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.WaitUntilReady();
            //Billing Details Page
            I.WaitUntilReady();
            I.Fill(Pages.BillingAddressPage.BillingEmailAddressTextField, TestData.BillingAddressPage.EmailAddress);
            I.Fill(Pages.BillingAddressPage.FirstNameTextField, TestData.BillingAddressPage.FirstName);
            I.Fill(Pages.BillingAddressPage.LastNameTextField, TestData.BillingAddressPage.LastName);
            I.Fill(Pages.BillingAddressPage.Address1TextField, TestData.BillingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "DOWN");
            I.Wait(2);
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "ENTER");
            I.Fill(Pages.BillingAddressPage.BillingPhoneNumber, TestData.BillingAddressPage.BillingPhoneNumber);
            I.Wait(3);
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.NameOnCardTextField, TestData.BillingAddressPage.CardHolderName);
            I.Click(Pages.BillingAddressPage.VisaIcon);
            I.Wait(2);
            I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.VisaCardNumber);
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList);
            I.Wait(2);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList, I_GetMonthCode((string)TestData.BillingAddressPage.ExpirationMonth));
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList, I_GetYearCode((string)TestData.BillingAddressPage.ExpirationYear));
            I.Fill(Pages.BillingAddressPage.SecurityCodeTextField, TestData.BillingAddressPage.SecurityCode);
            I.Wait(2);
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            I.WaitUntilReady();
            I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            I.WaitUntilReady();
            I.Open(Pages.OrdersPage.Url);
            I.WaitUntilReady();
            I.See(Pages.OrdersPage.OrderPanels);
        }
    }
}
