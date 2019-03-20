using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using S60TestExecutionPlatform.Utility;
using System;
using System.Runtime.CompilerServices;

namespace ShaverShop.Web.Tests.Tests.Checkout
{

 /**
 *
 * This class covers the helper actions of the shipping/billing details(checkout senario) page of Shaver Shop. 
 * 
 * @author Kanchana Liyanagamage
 * 
 */
    partial class CheckoutPageTests : TestBase
    {

        public object I_CreateNewUserProfile()
        {
            object emailAddress = I_GenerateUniqueMailAddressForNewProfile();
            I.Open(Pages.RegisterAccountPage.Url);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, emailAddress);
            I.Fill(Pages.RegisterAccountPage.ConfirmEmailTextField, emailAddress);
            I.Fill(Pages.RegisterAccountPage.PasswordTextField, TestData.RegisterAccountPage.Password);
            I.Fill(Pages.RegisterAccountPage.ConfirmPasswordTextField, TestData.RegisterAccountPage.Password);
            I.WaitUntilReady();
            I.Click(Pages.RegisterAccountPage.ApplyButton);
            //I.Click(Pages.AccountPage.LogoutLink);
            return emailAddress;
        }

        public object I_CreateNewUserProfileForExistingUser()
        {
            object emailAddress = I_GenerateUniqueMailAddressForNewProfile().ToString();
            I.Open(Pages.RegisterAccountPage.Url);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, emailAddress);
            I.Fill(Pages.RegisterAccountPage.ConfirmEmailTextField, emailAddress);
            I.Fill(Pages.RegisterAccountPage.PasswordTextField, TestData.RegisterAccountPage.Password);
            I.Fill(Pages.RegisterAccountPage.ConfirmPasswordTextField, TestData.RegisterAccountPage.Password);
            I.WaitUntilReady();
            I.Click(Pages.RegisterAccountPage.ApplyButton);
            I.WaitUntilReady();
            I.Click(Pages.AccountPage.LogoutLink);
            return emailAddress;
        }

        public void I_FillNewAddressDetails()
        {
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.AddressDetails.FirstNameTextField, TestData.CheckoutPage.FirstName);
            I.Fill(Pages.CheckoutPage.AddressDetails.LastNameTextField, TestData.CheckoutPage.LastName);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.AddressDetails.Address1TextField, TestData.CheckoutPage.Address1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.Address1TextField,"TAB");
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.Address1TextField, "ENTER");
            // I.Fill(Pages.CheckoutPage.AddressDetails.Address2TextField, TestData.CheckoutPage.Address2);
            I.ClickDropDownListSSA(Pages.CheckoutPage.AddressDetails.CountryDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListSSA(Pages.CheckoutPage.AddressDetails.CountryDropDownList, I_GetCountryCode((string)TestData.CheckoutPage.Country));
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.AddressDetails.StateTextField, TestData.CheckoutPage.State);
            I.Fill(Pages.CheckoutPage.AddressDetails.SuburbTextField, TestData.CheckoutPage.Suburb);
            I.Fill(Pages.CheckoutPage.AddressDetails.PostCodeTextField, TestData.CheckoutPage.PostCode);
            I.Fill(Pages.CheckoutPage.AddressDetails.PhoneTextField, TestData.CheckoutPage.Phone);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.PhoneTextField, "TAB");
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.PhoneTextField, "TAB");
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.ContinueToStep2Button, "ENTER");
            I.WaitUntilReady();
        }

        public void I_FillPaymentDetailsVisa()
        {
            I.See(Pages.CheckoutPage.PaymentDetails.PaymentDetailsPageHeaderTitle);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardHolderNameTextField, TestData.CheckoutPage.PaymentDetails.CardHolderName);
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardNumberTextField, TestData.CheckoutPage.PaymentDetails.CardNumber);
            I.ClickDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryMonthDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryMonthDropDownList, I_GetMonthCode((string)TestData.CheckoutPage.PaymentDetails.ExpiryMonth));
            I.ClickDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryYearDropDownList, TestData.CheckoutPage.PaymentDetails.ExpiryYear);
            I.Fill(Pages.CheckoutPage.PaymentDetails.SecurityCodeTextField, TestData.CheckoutPage.PaymentDetails.SecurityCode);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.PlaceOrderButton);
            I.WaitUntilReady();
            I.See(Pages.OrderConfirmationPage.OrderConfirmationPageHeaderTitle);
        }

        public void I_AddGiftCardToShoppingCart()
        {
            I.Open(Pages.GiftCardPurchasePage.Url);
            I.Fill(Pages.GiftCardPurchasePage.YourNameTextField, TestData.GiftCardPurchasePage.YourName);
            I.Fill(Pages.GiftCardPurchasePage.FriendsNameTextField, TestData.GiftCardPurchasePage.FriendsName);
            I.Fill(Pages.GiftCardPurchasePage.FriendsEmailTextField, TestData.GiftCardPurchasePage.FriendsEmail);
            I.Fill(Pages.GiftCardPurchasePage.ConfirmFriendsEmailTextField, TestData.GiftCardPurchasePage.ConfirmFriendsEmail);
            I.Fill(Pages.GiftCardPurchasePage.MessageTextField, TestData.GiftCardPurchasePage.Message);
            I.Fill(Pages.GiftCardPurchasePage.AmountTextField, TestData.GiftCardPurchasePage.Amount);
            I.Click(Pages.GiftCardPurchasePage.AddToCartButton);
        }

        public void I_FillPaymentDetailsWithAfterPay()
        {
            I.See(Pages.CheckoutPage.PaymentDetails.PaymentDetailsPageHeaderTitle);
            I.ClickRadioButton(Pages.CheckoutPage.PaymentDetails.AfterPayRadioButton);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.PlaceOrderButton);
        }

        public void I_FillPaymentDetailsWithPayPal()
        {
            I.See(Pages.CheckoutPage.PaymentDetails.PaymentDetailsPageHeaderTitle);
            I.ClickRadioButton(Pages.CheckoutPage.PaymentDetails.PayPalRadioButon);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.PlaceOrderButton);
            I.Wait(7);
          //  I.Click(Pages.PayPalPage.Process.PayButton);
            I.Wait(30);
          // I.SwitchToFrame(Pages.PayPalPage.PayPalLogin.Frame,"name");
            I.Fill(Pages.PayPalPage.PayPalLogin.UsernameTextField,TestData.PayPalLoginPage.Username);
            I.Fill(Pages.PayPalPage.PayPalLogin.PasswordTextField, TestData.PayPalLoginPage.Password);
            I.Click(Pages.PayPalPage.PayPalLogin.LoginButton);
            I.Wait(10);
            I.Click(Pages.PayPalPage.PayPalReview.PayNowButton);
            I.Wait(7);
            I.See(Pages.OrderConfirmationPage.OrderConfirmationPageHeaderTitle);
        }

        public void I_LoginAsExistingUser(object username)
        {
            I.Fill(Pages.LoginPage.UserNameTextField, username);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.RegisterAccountPage.Password);
            I.Click(Pages.LoginPage.LoginButton);
        }
     
        public void I_ProcessCheckout()
        {
            I.Open(Pages.Product.Shipster.Url);
            I.Click(Pages.ProductDetailsPage.AddToCartButon);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I_FillNewAddressDetails();
            I.Open(Pages.AccountPage.Url);
            I.Click(Pages.AccountPage.LogoutLink);
        }

        public void I_FillPaymentDetailsWithMasterCard()
        {
            I.See(Pages.CheckoutPage.PaymentDetails.PaymentDetailsPageHeaderTitle);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardHolderNameTextField, TestData.CheckoutPage.PaymentDetails.CardHolderName);
            I.ClickDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardTypeDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardTypeDropDownList, I_PaymentMethod((string)TestData.CheckoutPage.PaymentDetails.MasterCardType));
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardNumberTextField, TestData.CheckoutPage.PaymentDetails.MasterCardNumber);
            I.ClickDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryMonthDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryMonthDropDownList, I_GetMonthCode((string)TestData.CheckoutPage.PaymentDetails.ExpiryMonth));
            I.ClickDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryYearDropDownList, TestData.CheckoutPage.PaymentDetails.ExpiryYear);
            I.Fill(Pages.CheckoutPage.PaymentDetails.SecurityCodeTextField, TestData.CheckoutPage.PaymentDetails.SecurityCode);
            I.Click(Pages.CheckoutPage.PlaceOrderButton);
            I.WaitUntilReady();
            I.See(Pages.OrderConfirmationPage.OrderConfirmationPageHeaderTitle);
        }

        public void I_EditBillingAddress()
        {
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.AddressDetails.EditAddressButton);
            I.Fill(Pages.CheckoutPage.AddressDetails.Address1TextField, TestData.CheckoutPage.NewAddress.Address1);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.Address1TextField,"TAB");
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.Address1TextField, "ENTER");
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.PhoneTextField, "TAB");
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.PhoneTextField, "TAB");
            I.ClickKeyBoardEvent(Pages.CheckoutPage.AddressDetails.ContinueToStep2Button, "ENTER");
        }

        public void I_FillBiilingDetailsWithGiftCard()
        {
            I.See(Pages.CheckoutPage.PaymentDetails.PaymentDetailsPageHeaderTitle);
            I.WaitUntilReady();
            I.Check(Pages.CheckoutPage.PaymentDetails.DoYouHaveCouponCheckBox);
            I.Fill(Pages.CheckoutPage.PaymentDetails.GiftVoucherTextField, TestData.CheckoutPage.PaymentDetails.GiftCardNumber);
            I.Fill(Pages.CheckoutPage.PaymentDetails.PinTextField, TestData.CheckoutPage.PaymentDetails.Pin);
            I.Click(Pages.CheckoutPage.PaymentDetails.ApplyButton);
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardHolderNameTextField, TestData.CheckoutPage.PaymentDetails.CardHolderName);
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardNumberTextField, TestData.CheckoutPage.PaymentDetails.CardNumber);
            I.ClickDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryMonthDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryMonthDropDownList, I_GetMonthCode((string)TestData.CheckoutPage.PaymentDetails.ExpiryMonth));
            I.ClickDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryYearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.CheckoutPage.PaymentDetails.CardExpiryYearDropDownList, TestData.CheckoutPage.PaymentDetails.ExpiryYear);
            I.Fill(Pages.CheckoutPage.PaymentDetails.SecurityCodeTextField, TestData.CheckoutPage.PaymentDetails.SecurityCode);
            I.Click(Pages.CheckoutPage.PlaceOrderButton);
            I.WaitUntilReady();
            I.See(Pages.OrderConfirmationPage.OrderConfirmationPageHeaderTitle);
        }

        public void I_FillPaymentDetailsWithZipPay()
        {
            I.See(Pages.CheckoutPage.PaymentDetails.PaymentDetailsPageHeaderTitle);
            I.ClickRadioButton(Pages.CheckoutPage.PaymentDetails.ZipPayRadioButton);
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.PlaceOrderButton);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        static private object I_GenerateUniqueMailAddressForNewProfile()
        {
            long uniqueNumber = Helper.GetUniqueNumericValue();
            object emailAddress = "rr" + uniqueNumber + "@gmail.com";
            return emailAddress;
        }

        public string I_GetCountryCode(string country)
        {
            switch (country)
            {
                case "Australia": return "au";
                case "Afghanistan": return "af";
                case "Albania": return "al";
                case "Argentina": return "ar";
                case "March": return "3";
            }
            return "0";
        }

        public string I_GetMonthCode(string month)
        {
            switch (month)
            {
                case "January": return "1";
                case "February": return "2";
                case "March": return "3";
                case "April": return "4";
                case "May": return "5";
                case "June": return "6";
                case "July": return "7";
                case "August": return "8";
                case "September": return "9";
                case "October": return "10";
                case "November": return "11";
                case "December": return "12";
            }
            return "0";
        }

        public string I_PaymentMethod(string method)
        {

            switch (method)
            {
                case "Visa": return "Visa";
                case "American Express": return "Amex";
                case "Master Card": return "Master";
            }
            return "0";
        }

    }
}
