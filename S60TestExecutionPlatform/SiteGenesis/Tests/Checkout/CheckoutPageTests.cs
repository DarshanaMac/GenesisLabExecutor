using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.Checkout
{
    partial class CheckoutPageTests : TestBase
    {
        [Test]
        [Category(Categories.SiteGenesisTest)]
        public void CheckoutPage_GuestCustomerCheckoutUsingVISACard()
        {

            I.Open(Pages.ProductDetailsPage.Url);
            I.Click(Pages.LayoutPage.PopUpYesButton);
            I.ClickOnElementList(Pages.ProductDetailsPage.ColourCodeLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SizePanelLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SelectWidthLink, 1);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.NavigateToPage(Pages.ShoppingCartPage.Url, "Yes");
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Click(Pages.CheckoutPage.CheckoutAsGuestButton);
            I.Fill(Pages.ShippingDetailsPage.FirstNameTextField, TestData.ShippingDetailsPage.FirstName);
            I.Fill(Pages.ShippingDetailsPage.LastNameTextField, TestData.ShippingDetailsPage.LastName);
            I.Fill(Pages.ShippingDetailsPage.AddressLineOneTextField, TestData.ShippingDetailsPage.AddressLineOne);
            I.Fill(Pages.ShippingDetailsPage.CityTextFields, TestData.ShippingDetailsPage.City);
            I.Fill(Pages.ShippingDetailsPage.ZipCodeTextField, TestData.ShippingDetailsPage.ZipCode);
            I.SelectValue(Pages.ShippingDetailsPage.StateDropDownList,TestData.ShippingDetailsPage.State);
            I.Fill(Pages.ShippingDetailsPage.PhoneTextField, TestData.ShippingDetailsPage.Phone);
            I.Click(Pages.ShippingDetailsPage.ContinueToBillingButton);
            I.Fill(Pages.BillingDetailsPage.FirstNameTextField, TestData.BillingDetailsPage.FirstName);
            I.Fill(Pages.BillingDetailsPage.LastNameTextField, TestData.BillingDetailsPage.LastName);
            I.Fill(Pages.BillingDetailsPage.AddressLineOneTextField, TestData.BillingDetailsPage.AddressLineOne);
            I.Fill(Pages.BillingDetailsPage.CityTextField, TestData.BillingDetailsPage.City);
            I.Fill(Pages.BillingDetailsPage.ZipcodeTextField, TestData.BillingDetailsPage.ZipCode);
            I.Fill(Pages.BillingDetailsPage.EmailTextField, TestData.BillingDetailsPage.EmailAddress);
            I.Fill(Pages.BillingDetailsPage.CardNameTextField, TestData.BillingDetailsPage.NameOnCard);
            I.SelectValue(Pages.BillingDetailsPage.CardTypeDropDownList, TestData.BillingDetailsPage.CardType);
            I.Fill(Pages.BillingDetailsPage.NumberTextField, TestData.BillingDetailsPage.CardNumber);
            I.Fill(Pages.BillingDetailsPage.SecurityCodeTextField, TestData.BillingDetailsPage.SecurityCode);
            I.Click(Pages.BillingDetailsPage.ContinueToPlaceOrder);
            I.Click(Pages.PlaceOrderPage.PlaceOrderButton);
        }

        [Test]
        public void CheckoutPage_GuestCustomerCheckoutUsingMasterCard()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I.Click(Pages.LayoutPage.PopUpYesButton);
            I.ClickOnElementList(Pages.ProductDetailsPage.ColourCodeLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SizePanelLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SelectWidthLink, 1);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.NavigateToPage(Pages.ShoppingCartPage.Url, "Yes");
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Click(Pages.CheckoutPage.CheckoutAsGuestButton);
            I.Fill(Pages.ShippingDetailsPage.FirstNameTextField, TestData.ShippingDetailsPage.FirstName);
            I.Fill(Pages.ShippingDetailsPage.LastNameTextField, TestData.ShippingDetailsPage.LastName);
            I.Fill(Pages.ShippingDetailsPage.AddressLineOneTextField, TestData.ShippingDetailsPage.AddressLineOne);
            I.Fill(Pages.ShippingDetailsPage.CityTextFields, TestData.ShippingDetailsPage.City);
            I.Fill(Pages.ShippingDetailsPage.ZipCodeTextField, TestData.ShippingDetailsPage.ZipCode);
            I.SelectValue(Pages.ShippingDetailsPage.StateDropDownList,TestData.ShippingDetailsPage.State);
            I.Fill(Pages.ShippingDetailsPage.PhoneTextField, TestData.ShippingDetailsPage.Phone);
            I.Click(Pages.ShippingDetailsPage.ContinueToBillingButton);
            I.Fill(Pages.BillingDetailsPage.FirstNameTextField, TestData.BillingDetailsPage.FirstName);
            I.Fill(Pages.BillingDetailsPage.LastNameTextField, TestData.BillingDetailsPage.LastName);
            I.Fill(Pages.BillingDetailsPage.AddressLineOneTextField, TestData.BillingDetailsPage.AddressLineOne);
            I.Fill(Pages.BillingDetailsPage.CityTextField, TestData.BillingDetailsPage.City);
            I.Fill(Pages.BillingDetailsPage.ZipcodeTextField, TestData.BillingDetailsPage.ZipCode);
            I.Fill(Pages.BillingDetailsPage.EmailTextField, TestData.BillingDetailsPage.EmailAddress);
            I.Fill(Pages.BillingDetailsPage.CardNameTextField, TestData.BillingDetailsPage.NameOnCard);
            I.SelectValue(Pages.BillingDetailsPage.CardTypeDropDownList, TestData.BillingDetailsPage.CardTypeMaster);
            I.Fill(Pages.BillingDetailsPage.NumberTextField, TestData.BillingDetailsPage.CardNumber);
            I.Fill(Pages.BillingDetailsPage.SecurityCodeTextField, TestData.BillingDetailsPage.SecurityCode);
            I.Click(Pages.BillingDetailsPage.ContinueToPlaceOrder);
            I.Click(Pages.PlaceOrderPage.PlaceOrderButton);
        }

        [Test]
        public void CheckoutPage_GuestCustomerCheckoutUsingAMEXCard() {
            I.Open(Pages.ProductDetailsPage.Url);
            I.Click(Pages.LayoutPage.PopUpYesButton);
            I.ClickOnElementList(Pages.ProductDetailsPage.ColourCodeLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SizePanelLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SelectWidthLink, 1);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.NavigateToPage(Pages.ShoppingCartPage.Url, "Yes");
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Click(Pages.CheckoutPage.CheckoutAsGuestButton);
            I.Fill(Pages.ShippingDetailsPage.FirstNameTextField, TestData.ShippingDetailsPage.FirstName);
            I.Fill(Pages.ShippingDetailsPage.LastNameTextField, TestData.ShippingDetailsPage.LastName);
            I.Fill(Pages.ShippingDetailsPage.AddressLineOneTextField, TestData.ShippingDetailsPage.AddressLineOne);
            I.Fill(Pages.ShippingDetailsPage.CityTextFields, TestData.ShippingDetailsPage.City);
            I.Fill(Pages.ShippingDetailsPage.ZipCodeTextField, TestData.ShippingDetailsPage.ZipCode);
            I.SelectValue(Pages.ShippingDetailsPage.StateDropDownList, TestData.ShippingDetailsPage.State);
            I.Fill(Pages.ShippingDetailsPage.PhoneTextField, TestData.ShippingDetailsPage.Phone);
            I.Click(Pages.ShippingDetailsPage.ContinueToBillingButton);
            I.Fill(Pages.BillingDetailsPage.FirstNameTextField, TestData.BillingDetailsPage.FirstName);
            I.Fill(Pages.BillingDetailsPage.LastNameTextField, TestData.BillingDetailsPage.LastName);
            I.Fill(Pages.BillingDetailsPage.AddressLineOneTextField, TestData.BillingDetailsPage.AddressLineOne);
            I.Fill(Pages.BillingDetailsPage.CityTextField, TestData.BillingDetailsPage.City);
            I.Fill(Pages.BillingDetailsPage.ZipcodeTextField, TestData.BillingDetailsPage.ZipCode);
            I.Fill(Pages.BillingDetailsPage.EmailTextField, TestData.BillingDetailsPage.EmailAddress);
            I.Fill(Pages.BillingDetailsPage.CardNameTextField, TestData.BillingDetailsPage.NameOnCard);
            I.SelectValue(Pages.BillingDetailsPage.CardTypeDropDownList, TestData.BillingDetailsPage.CardTypeAMEX);
            I.Fill(Pages.BillingDetailsPage.NumberTextField, TestData.BillingDetailsPage.CardNumber);
            I.Fill(Pages.BillingDetailsPage.SecurityCodeTextField, TestData.BillingDetailsPage.SecurityCode);
            I.Click(Pages.BillingDetailsPage.ContinueToPlaceOrder);
            I.Click(Pages.PlaceOrderPage.PlaceOrderButton);
        }

        [Test]
        public void CheckoutPage_GuestCustomerCheckoutUsingDiscoverCard() {
            I.Open(Pages.ProductDetailsPage.Url);
            I.Click(Pages.LayoutPage.PopUpYesButton);
            I.ClickOnElementList(Pages.ProductDetailsPage.ColourCodeLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SizePanelLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SelectWidthLink, 1);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.NavigateToPage(Pages.ShoppingCartPage.Url, "Yes");
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Click(Pages.CheckoutPage.CheckoutAsGuestButton);
            I.Fill(Pages.ShippingDetailsPage.FirstNameTextField, TestData.ShippingDetailsPage.FirstName);
            I.Fill(Pages.ShippingDetailsPage.LastNameTextField, TestData.ShippingDetailsPage.LastName);
            I.Fill(Pages.ShippingDetailsPage.AddressLineOneTextField, TestData.ShippingDetailsPage.AddressLineOne);
            I.Fill(Pages.ShippingDetailsPage.CityTextFields, TestData.ShippingDetailsPage.City);
            I.Fill(Pages.ShippingDetailsPage.ZipCodeTextField, TestData.ShippingDetailsPage.ZipCode);
            I.SelectValue(Pages.ShippingDetailsPage.StateDropDownList, TestData.ShippingDetailsPage.State);
            I.Fill(Pages.ShippingDetailsPage.PhoneTextField, TestData.ShippingDetailsPage.Phone);
            I.Click(Pages.ShippingDetailsPage.ContinueToBillingButton);
            I.Fill(Pages.BillingDetailsPage.FirstNameTextField, TestData.BillingDetailsPage.FirstName);
            I.Fill(Pages.BillingDetailsPage.LastNameTextField, TestData.BillingDetailsPage.LastName);
            I.Fill(Pages.BillingDetailsPage.AddressLineOneTextField, TestData.BillingDetailsPage.AddressLineOne);
            I.Fill(Pages.BillingDetailsPage.CityTextField, TestData.BillingDetailsPage.City);
            I.Fill(Pages.BillingDetailsPage.ZipcodeTextField, TestData.BillingDetailsPage.ZipCode);
            I.Fill(Pages.BillingDetailsPage.EmailTextField, TestData.BillingDetailsPage.EmailAddress);
            I.Fill(Pages.BillingDetailsPage.CardNameTextField, TestData.BillingDetailsPage.NameOnCard);
            I.SelectValue(Pages.BillingDetailsPage.CardTypeDropDownList, TestData.BillingDetailsPage.CardTypeDiscover);
            I.Fill(Pages.BillingDetailsPage.NumberTextField, TestData.BillingDetailsPage.CardNumber);
            I.Fill(Pages.BillingDetailsPage.SecurityCodeTextField, TestData.BillingDetailsPage.SecurityCode);
            I.Click(Pages.BillingDetailsPage.ContinueToPlaceOrder);
            I.Click(Pages.PlaceOrderPage.PlaceOrderButton);
        }

        public void CheckoutPage_GuestCustomerCheckoutUsingPaypal() {
            I.Open(Pages.ProductDetailsPage.Url);
            I.Click(Pages.LayoutPage.PopUpYesButton);
            I.ClickOnElementList(Pages.ProductDetailsPage.ColourCodeLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SizePanelLink, 0);
            I.ClickOnElementList(Pages.ProductDetailsPage.SelectWidthLink, 1);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.NavigateToPage(Pages.ShoppingCartPage.Url, "Yes");
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Click(Pages.CheckoutPage.CheckoutAsGuestButton);
            I.Fill(Pages.ShippingDetailsPage.FirstNameTextField, TestData.ShippingDetailsPage.FirstName);
            I.Fill(Pages.ShippingDetailsPage.LastNameTextField, TestData.ShippingDetailsPage.LastName);
            I.Fill(Pages.ShippingDetailsPage.AddressLineOneTextField, TestData.ShippingDetailsPage.AddressLineOne);
            I.Fill(Pages.ShippingDetailsPage.CityTextFields, TestData.ShippingDetailsPage.City);
            I.Fill(Pages.ShippingDetailsPage.ZipCodeTextField, TestData.ShippingDetailsPage.ZipCode);
            I.SelectValue(Pages.ShippingDetailsPage.StateDropDownList, TestData.ShippingDetailsPage.State);
            I.Fill(Pages.ShippingDetailsPage.PhoneTextField, TestData.ShippingDetailsPage.Phone);
            I.Click(Pages.ShippingDetailsPage.ContinueToBillingButton);
            I.Fill(Pages.BillingDetailsPage.FirstNameTextField, TestData.BillingDetailsPage.FirstName);
            I.Fill(Pages.BillingDetailsPage.LastNameTextField, TestData.BillingDetailsPage.LastName);
            I.Fill(Pages.BillingDetailsPage.AddressLineOneTextField, TestData.BillingDetailsPage.AddressLineOne);
            I.Fill(Pages.BillingDetailsPage.CityTextField, TestData.BillingDetailsPage.City);
            I.Fill(Pages.BillingDetailsPage.ZipcodeTextField, TestData.BillingDetailsPage.ZipCode);
            I.Fill(Pages.BillingDetailsPage.EmailTextField, TestData.BillingDetailsPage.EmailAddress);
            I.Click(Pages.BillingDetailsPage.PaypalRadioButton);
            I.Click(Pages.BillingDetailsPage.ContinueToPlaceOrder);
            I.Click(Pages.PlaceOrderPage.PlaceOrderButton);
        }

    }
}
