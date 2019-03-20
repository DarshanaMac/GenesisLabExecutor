using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using System.Diagnostics;

namespace BardotJunior.Tests.Checkout
{ 
    /**
    *
    * This class covers the user actions of the (checkout senario) page of Bardot. 
    * 
    * @author Darshana Konara
    * 
    */

    partial class CheckoutPageTests : TestBase
    {

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRDJ_Confident)]
        public void CheckoutPage_GuestCustomerCheckoutUsingVISACard()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I_HandlePopUp();
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I.Wait(3);
            I_ClickActiveSwatch();
            //I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 2);
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.Open(Pages.CheckoutPage.Url);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.CheckoutAsAGuestButton);
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
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.NameOnCardTextField, TestData.BillingAddressPage.CardHolderName);
           // I.Click(Pages.BillingAddressPage.VisaIcon);
            I.Wait(2);
            I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.GuestUserAccountDetails.VisaCardNumber);
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList);
            I.Wait(2);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList, I_GetMonthCode((string)TestData.BillingAddressPage.ExpirationMonth));
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList, I_GetYearCode((string)TestData.BillingAddressPage.ExpirationYear));
            I.Wait(3);
            I.Fill(Pages.BillingAddressPage.SecurityCodeTextField, TestData.BillingAddressPage.SecurityCode);
            I.Wait(2);
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            //I.WaitUntilReady();
            //I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            //I.WaitUntilReady();
            //I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            //I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void CheckoutPage_GuestCustomerCheckoutUsingMasterCard()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I_HandlePopUp();
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
           // I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 1);
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.Open(Pages.CheckoutPage.Url);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.CheckoutAsAGuestButton);
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
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.NameOnCardTextField, TestData.BillingAddressPage.CardHolderName);
            I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.GuestUserAccountDetails.MasterCardNumber);
           // I.Click(Pages.BillingAddressPage.MasterIcon);
            I.Wait(2);
           // I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.GuestUserAccountDetails.MasterCardNumber);
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
            I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void CheckoutPage_GuestCustomerCheckoutUsingAMEXCard()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I_HandlePopUp();
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
           // I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 2);
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.Open(Pages.CheckoutPage.Url);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.CheckoutAsAGuestButton);
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
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.NameOnCardTextField, TestData.BillingAddressPage.CardHolderName);
           // I.Click(Pages.BillingAddressPage.AmexIcon);
            I.Wait(2);
            I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.GuestUserAccountDetails.AMEXCardNumber);
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList);
            I.Wait(2);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList, I_GetMonthCode((string)TestData.BillingAddressPage.ExpirationMonth));
            I.WaitUntilReady();
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList, I_GetYearCode((string)TestData.BillingAddressPage.ExpirationYear));
            I.Fill(Pages.BillingAddressPage.SecurityCodeTextField, TestData.BillingAddressPage.AMEXSecurityCode);
            I.Wait(2);
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            I.WaitUntilReady();
            I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            I.WaitUntilReady();
            I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void CheckoutPage_GuestCustomerCheckoutUsingPayPal()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I_HandlePopUp();
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
            //I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 0);
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.Open(Pages.CheckoutPage.Url);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.CheckoutAsAGuestButton);
            I.Fill(Pages.ShippingAddressPage.FirstNameTextField, TestData.ShippingAddressPage.FirstName);
            I.Fill(Pages.ShippingAddressPage.LastNameTextField, TestData.ShippingAddressPage.LastName);
            I.Fill(Pages.ShippingAddressPage.Address1TextField, TestData.ShippingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "DOWN");
            I.Wait(3);
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "ENTER");
            I.Wait(2);
            I.Fill(Pages.ShippingAddressPage.PhoneTextField, TestData.ShippingAddressPage.ShippingPhoneNumber);
            I.WaitUntilReady();
            I_VerifyFillData();
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.WaitUntilReady();
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
            I_VerifyFillDataBilling();
            I.Click(Pages.BillingAddressPage.PayPalRadioButton);
            I.WaitUntilReady();
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            I.WaitUntilReady();
            I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            I.Wait(10);
            I.Fill(Pages.PaypalLoginPage.EmailTextField, TestData.PaypalLoginPage.EmailAddress);
            I.Fill(Pages.PaypalLoginPage.PasswordTextField, TestData.PaypalLoginPage.Password);
            I.Click(Pages.PaypalLoginPage.LoginButton);
            I.Wait(20);
            I.Click(Pages.PaypalLoginPage.PayNowButton);
            I.WaitUntilReady();
            I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void CheckoutPage_GuestCustomerCheckoutUsingAfterPay()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I_HandlePopUp();
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I.Wait(3);
           // I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 3);
            I_ClickActiveSwatch();
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.Open(Pages.CheckoutPage.Url);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.CheckoutAsAGuestButton);
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
            I.Wait(3);
            I_VerifyFillData();
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.Wait(3);
            //Billing address
            I.Fill(Pages.BillingAddressPage.BillingEmailAddressTextField, TestData.BillingAddressPage.EmailAddress);
            I.Fill(Pages.BillingAddressPage.FirstNameTextField, TestData.BillingAddressPage.FirstName);
            I.Fill(Pages.BillingAddressPage.LastNameTextField, TestData.BillingAddressPage.LastName);
            I.Fill(Pages.BillingAddressPage.Address1TextField, TestData.BillingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "DOWN");
            I.Wait(3);
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "ENTER");
            I.Fill(Pages.BillingAddressPage.BillingPhoneNumber, TestData.BillingAddressPage.BillingPhoneNumber);
            I_VerifyFillDataBilling();
            //I.Click(Pages.BillingAddressPage.OtherRadioButton);
            I.Click(Pages.BillingAddressPage.AfterPayRadioButton);
            I.Wait(2);
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            I.WaitUntilReady();
            I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            I.Wait(7);
            //3rd party process
            //Process proc = null;
            //proc = new Process();
            //proc.StartInfo.FileName = "Integrations\\Afterpay.exe";
            //proc.StartInfo.CreateNoWindow = false;
            //proc.Start();
            //I.WaitUntilReady();
            //proc.WaitForExit();
            I.Fill(Pages.AfterPayPage.UsernameTextfield,TestData.AfterPayPaymentInfo.EmailAddress);
            I.Click(Pages.AfterPayPage.ContinueButton);
            I.WaitUntilReady();
            I.Fill(Pages.AfterPayPage.PasswordTextField, TestData.AfterPayPaymentInfo.Password);
            I.Click(Pages.AfterPayPage.ContinueButton);
            I.WaitUntilReady();
            I.Click(Pages.AfterPayPage.PopupConfirmation);
            I.Click(Pages.AfterPayPage.TermsAgreedCheckBox);
            I.Click(Pages.AfterPayPage.ConfirmPaymentButton);
            I.Wait(15);
            I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void CheckoutPage_GuestCustomerCheckoutUsingPromotionCode()
        {
            I.Open(Pages.Product.Promotion.Url);
            I_HandlePopUp();
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
            I.Open(Pages.CheckoutPage.Url);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.CheckoutAsAGuestButton);
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
            I.Wait(2);
            I.Click(Pages.BillingAddressPage.PromotionCodePlusButton);
            I.Wait(2);
            I.Fill(Pages.BillingAddressPage.PromotionCodeTextField, TestData.BillingAddressPage.PromotionCode);
            I.Click(Pages.BillingAddressPage.AddPromotionButton);
            I.Wait(3);
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.NameOnCardTextField, TestData.BillingAddressPage.CardHolderName);
            //I.Click(Pages.BillingAddressPage.VisaIcon);
            I.Wait(2);
            I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.GuestUserAccountDetails.VisaCardNumber);
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList);
            I.Wait(2);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList, I_GetMonthCode((string)TestData.BillingAddressPage.ExpirationMonth));
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList, I_GetYearCode((string)TestData.BillingAddressPage.ExpirationYear));
            I.Fill(Pages.BillingAddressPage.SecurityCodeTextField, TestData.BillingAddressPage.SecurityCode);
            I.WaitUntilReady();
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            I.WaitUntilReady();
            I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            I.WaitUntilReady();
            I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void CheckoutPage_GuestCustomerCheckoutUsingGiftCard()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I_HandlePopUp();
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
            //I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 0);
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.Open(Pages.CheckoutPage.Url);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.CheckoutAsAGuestButton);
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
            I.Wait(3);
            I_VerifyFillData();
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.Wait(3);
            //Billing address
            I.Click(Pages.BillingAddressPage.GiftCardPlusButton);
            I.Wait(3);
            I.Fill(Pages.BillingAddressPage.GiftCardNumberTextField, TestData.BillingAddressPage.GiftCardNumber);
            I.Fill(Pages.BillingAddressPage.GiftCardPinTextField, TestData.BillingAddressPage.GiftCardPin);
            I.Click(Pages.BillingAddressPage.GiftCardApplyButton);
            I.Wait(3);
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
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            I.WaitUntilReady();
            I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            I.Wait(2);
            I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRDJ_Confident)]
        public void CheckoutPage_RegisteredCustomerCheckoutUsingVISACard()
        {
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
            I.WaitUntilReady() ;
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
            //I.Wait(7);
            //I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            //I.Wait(2);
            //I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            //I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRDJ_Confident)]
        public void CheckoutPage_RegisteredCustomerCheckoutUsingMasterCard()
        {
            I_CreateNewUser();
            I.Wait(3);
            I.Open(Pages.ProductDetailsPage.Url);
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
            //I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 0);
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
            I.Wait(2);
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.NameOnCardTextField, TestData.BillingAddressPage.CardHolderName);
          //  I.Click(Pages.BillingAddressPage.MasterIcon);
            I.WaitUntilReady();
            I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.MasterCardNumber);
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList);
            I.Wait(2);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList, I_GetMonthCode((string)TestData.BillingAddressPage.ExpirationMonth));
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList, I_GetYearCode((string)TestData.BillingAddressPage.ExpirationYear));
            I.Fill(Pages.BillingAddressPage.SecurityCodeTextField, TestData.BillingAddressPage.SecurityCode);
            I.Wait(2);
            //I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            //I.WaitUntilReady();
            //I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            //I.Wait(2);
            //I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            //I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRDJ_Confident)]
        public void CheckoutPage_RegisteredCustomerCheckoutUsingAMEXCard()
        {
            I_CreateNewUser();
            I.WaitUntilReady();
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
            I.Wait(3);
            I_VerifyFillData();
            I.Wait(3);
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.WaitUntilReady();
            //Billing address
            I.WaitUntilReady();
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
            I.Wait(2);
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.NameOnCardTextField, TestData.BillingAddressPage.CardHolderName);
          //  I.Click(Pages.BillingAddressPage.AmexIcon);
            I.WaitUntilReady();
            I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.AMEXCardNumber);
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList);
            I.Wait(2);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireMonthDropDownList, I_GetMonthCode((string)TestData.BillingAddressPage.ExpirationMonth));
            I.ClickDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.BillingAddressPage.ExpireYearDropDownList, I_GetYearCode((string)TestData.BillingAddressPage.ExpirationYear));
            I.Fill(Pages.BillingAddressPage.SecurityCodeTextField, TestData.BillingAddressPage.AMEXSecurityCode);
            I.Wait(2);
            //I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            //I.WaitUntilReady();
            //I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            //I.Wait(2);
            //I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            //I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRDJ_Confident)]
        public void CheckoutPage_RegisteredCustomerCheckoutUsingPayPal()
        {
            I_CreateNewUser();
            I.Open(Pages.ProductDetailsPage.Url);
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
           // I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 0);
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ShoppingCartPage.CheckoutButton, "ENTER");
            I.WaitUntilReady();
            I.Fill(Pages.ShippingAddressPage.FirstNameTextField, TestData.ShippingAddressPage.FirstName);
            I.Fill(Pages.ShippingAddressPage.LastNameTextField, TestData.ShippingAddressPage.LastName);
            I.Fill(Pages.ShippingAddressPage.Address1TextField, TestData.ShippingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "DOWN");
            I.Wait(3);
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "ENTER");
            I.Wait(2);
            I.Fill(Pages.ShippingAddressPage.PhoneTextField, TestData.ShippingAddressPage.ShippingPhoneNumber);
            I.WaitUntilReady();
            I_VerifyFillData();
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.WaitUntilReady();
            I.Fill(Pages.BillingAddressPage.BillingEmailAddressTextField, TestData.BillingAddressPage.EmailAddress);
            I.Fill(Pages.BillingAddressPage.FirstNameTextField, TestData.BillingAddressPage.FirstName);
            I.Fill(Pages.BillingAddressPage.LastNameTextField, TestData.BillingAddressPage.LastName);
            I.Fill(Pages.BillingAddressPage.Address1TextField, TestData.BillingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "DOWN");
            I.Wait(3);
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "ENTER");
            I.Wait(2);
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.BillingPhoneNumber, TestData.BillingAddressPage.BillingPhoneNumber);
            I_VerifyFillDataBilling();
            I.Wait(10);
            I.Click(Pages.BillingAddressPage.PayPalRadioButton);
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
           // I.WaitUntilReady();
            //I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            //I.Wait(10);
            //I.Fill(Pages.PaypalLoginPage.EmailTextField, TestData.PaypalLoginPage.EmailAddress);
            //I.Fill(Pages.PaypalLoginPage.PasswordTextField, TestData.PaypalLoginPage.Password);
            //I.Click(Pages.PaypalLoginPage.LoginButton);
            //I.Wait(25);
            //I.Click(Pages.PaypalLoginPage.PayNowButton);
            //I.Wait(8);
            //I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            //I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRDJ_Confident)]
        public void CheckoutPage_RegisteredCustomerCheckoutUsingAfterPay()
        {
            I_CreateNewUser();
            I.Open(Pages.ProductDetailsPage.Url);
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
           // I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 1);
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
            I.Wait(2);
            I_VerifyFillData();
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.WaitUntilReady();
            //Billing address
            I.WaitUntilReady();
            I.Fill(Pages.BillingAddressPage.BillingEmailAddressTextField, TestData.BillingAddressPage.EmailAddress);
            I.Fill(Pages.BillingAddressPage.FirstNameTextField, TestData.BillingAddressPage.FirstName);
            I.Fill(Pages.BillingAddressPage.LastNameTextField, TestData.BillingAddressPage.LastName);
            I.Fill(Pages.BillingAddressPage.Address1TextField, TestData.BillingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "DOWN");
            I.Wait(3);
            I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "ENTER");
            I.Wait(2);
            I_VerifyFillDataBilling();
            I.Fill(Pages.BillingAddressPage.BillingPhoneNumber, TestData.BillingAddressPage.BillingPhoneNumber);
           // I.Click(Pages.BillingAddressPage.OtherRadioButton);
            I.Click(Pages.BillingAddressPage.AfterPayRadioButton);
            I.Wait(2);
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            I.WaitUntilReady();
            I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            //I.Wait(10);
            //I.Fill(Pages.AfterPayPage.UsernameTextfield, TestData.AfterPayPaymentInfo.EmailAddress);
            //I.Click(Pages.AfterPayPage.ContinueButton);
            //I.WaitUntilReady();
            //I.Fill(Pages.AfterPayPage.PasswordTextField, TestData.AfterPayPaymentInfo.Password);
            //I.Click(Pages.AfterPayPage.ContinueButton);
            //I.WaitUntilReady();
            //I.Click(Pages.AfterPayPage.PopupConfirmation);
            //I.Click(Pages.AfterPayPage.TermsAgreedCheckBox);
            //I.Click(Pages.AfterPayPage.ConfirmPaymentButton);
            //I.Wait(17);
            //I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            //I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
 
        public void CheckoutPage_RegisteredCustomerCheckoutUsingPromotionCode()
        {
            I_CreateNewUser();
            I.Open(Pages.Product.Promotion.Url);
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
           // I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 2);
            I.Wait(3);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ShoppingCartPage.CheckoutButton, "ENTER");
            //Shipping Details Page
            I.WaitUntilReady();
            I.Fill(Pages.ShippingAddressPage.FirstNameTextField, TestData.ShippingAddressPage.FirstName);
            I.Fill(Pages.ShippingAddressPage.LastNameTextField, TestData.ShippingAddressPage.LastName);
            I.Fill(Pages.ShippingAddressPage.Address1TextField, TestData.ShippingAddressPage.AddressLine1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "DOWN");
            I.Wait(3);
            I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "ENTER");
            I.Wait(2);
            I.Fill(Pages.ShippingAddressPage.PhoneTextField, TestData.ShippingAddressPage.ShippingPhoneNumber);
            I.Wait(3);
            I_VerifyFillData();
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.Wait(3);
            //Billing address
            I.Click(Pages.BillingAddressPage.PromotionCodePlusButton);
            I.Wait(3);
            I.Fill(Pages.BillingAddressPage.PromotionCodeTextField, TestData.BillingAddressPage.PromotionCode);
            I.Wait(2);
            I.Click(Pages.BillingAddressPage.AddPromotionButton);
            I.Wait(3);
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
            I.Click(Pages.BillingAddressPage.VisaIcon);
            I.Wait(2);
            I.Fill(Pages.BillingAddressPage.CardNumberTextField, TestData.BillingAddressPage.GuestUserAccountDetails.VisaCardNumber);
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
            I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            I.Wait(60);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void CheckoutPage_RegisteredCustomerCheckoutUsingGiftCard()
        {
            I_CreateNewUser();
            I.Open(Pages.ProductDetailsPage.Url);
            I.Wait(3);
            I.ClickOnElementList(Pages.ProductDetailsPage.SwatchedColorLinks, 0);
            I_ClickActiveSwatch();
            I.Wait(3);
            //I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, 0);
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
            I.Wait(3);
            I_VerifyFillData();
            I.Click(Pages.ShippingAddressPage.ContinueToPaymentButton);
            I.Wait(3);
            //Billing address
            I.Click(Pages.BillingAddressPage.GiftCardPlusButton);
            I.Wait(3);
            I.Fill(Pages.BillingAddressPage.GiftCardNumberTextField, TestData.BillingAddressPage.GiftCardNumber);
            I.Fill(Pages.BillingAddressPage.GiftCardPinTextField, TestData.BillingAddressPage.GiftCardPin);
            I.Click(Pages.BillingAddressPage.GiftCardApplyButton);
            I.Wait(3);
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
            I.Click(Pages.BillingAddressPage.ContinueToPlaceOrderButton);
            I.WaitUntilReady();
            I.Click(Pages.OrderSummaryPage.PlaceOrderButton);
            I.Wait(2);
            I.See(Pages.OrderConfirmationPage.ConfirmationMessage);
            I.Wait(60);
        }
    }
}