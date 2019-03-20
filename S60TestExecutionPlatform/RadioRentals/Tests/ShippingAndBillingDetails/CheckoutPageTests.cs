using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ShippingAndBillingDetails
{
    /**
    *
    * This class covers the user actions of the shipping/billing details(checkout senario) page of Radio Rentals. 
    * 
    * @author Darshana Konara
    * 
    */
    partial class CheckoutPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CheckoutPage_ProceedToCheckoutProcess()
        {
            I_CreateNewProfile();
            I_AddItemToCart();
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab);
            I.ClickDropDownList(Pages.ShoppingCartPage.DeliveryDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.ShoppingCartPage.DeliveryDropDownList, I_GetDeliveryOptionValue("In Store Pick Up"));
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.SelectStoreButton);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.StoreLocatorPopUp.ShowAllStoresButton);
            I.WaitUntilReady();
            I.ClickOnElementList(Pages.ShoppingCartPage.StoreLocatorPopUp.PickUpAtThisStoreLinkList, 0);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Wait(10);
            I.AmOn(Pages.CheckoutPage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CheckoutPage_PresenceOfElementsOfContactDetailsPage()
        {
            I_CreateNewProfile();
            I_AddItemToCart();
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab);
            I.ClickDropDownList(Pages.ShoppingCartPage.DeliveryDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.ShoppingCartPage.DeliveryDropDownList, I_GetDeliveryOptionValue("In Store Pick Up"));
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.SelectStoreButton);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.StoreLocatorPopUp.ShowAllStoresButton);
            I.WaitUntilReady();
            I.ClickOnElementList(Pages.ShoppingCartPage.StoreLocatorPopUp.PickUpAtThisStoreLinkList, 0);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Wait(10);
            I_VerifyContactDetailPageAttributes();
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CheckoutPage_PresenceOfElementsOfBillingDetailsPage()
        {
            I_CreateNewProfile();
            I_AddItemToCart();
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab);
            I.ClickDropDownList(Pages.ShoppingCartPage.DeliveryDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.ShoppingCartPage.DeliveryDropDownList, I_GetDeliveryOptionValue("In Store Pick Up"));
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.SelectStoreButton);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.StoreLocatorPopUp.ShowAllStoresButton);
            I.WaitUntilReady();
            I.ClickOnElementList(Pages.ShoppingCartPage.StoreLocatorPopUp.PickUpAtThisStoreLinkList, 0);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Wait(10);
            I.Click(Pages.CheckoutPage.ContactDetails.NextButton);
            I.WaitUntilReady();
            I_VerifyBillingDetailsPageAttributes();
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CheckoutPage_PresenceOfElementsOfPaymentDetailsPage()
        {
            I_CreateNewProfile();
            I_AddItemToCart();
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab);
            I.ClickDropDownList(Pages.ShoppingCartPage.DeliveryDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.ShoppingCartPage.DeliveryDropDownList, I_GetDeliveryOptionValue("In Store Pick Up"));
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.SelectStoreButton);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.StoreLocatorPopUp.ShowAllStoresButton);
            I.WaitUntilReady();
            I.ClickOnElementList(Pages.ShoppingCartPage.StoreLocatorPopUp.PickUpAtThisStoreLinkList, 0);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Wait(10);
            I.Click(Pages.CheckoutPage.ContactDetails.NextButton);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.BillingDetails.BillingAddressTextField, TestData.CheckoutPage.BillingDetails.Address);
            I.Fill(Pages.CheckoutPage.BillingDetails.BillingCityTextField, TestData.CheckoutPage.BillingDetails.CityOrSuburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.CheckoutPage.BillingDetails.BillingCityTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.CheckoutPage.BillingDetails.BillingCityTextField, "ENTER");
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.BillingDetails.BillingNextButton);
            I.WaitUntilReady();
            I_VerifyPaymentDetailsPageAttributes();
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CheckoutPage_PresenceOfElementsOfSummaryPage()
        {
            I_CreateNewProfile();
            I_AddItemToCart();
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab);
            I.ClickDropDownList(Pages.ShoppingCartPage.DeliveryDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.ShoppingCartPage.DeliveryDropDownList, I_GetDeliveryOptionValue("In Store Pick Up"));
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.SelectStoreButton);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.StoreLocatorPopUp.ShowAllStoresButton);
            I.WaitUntilReady();
            I.ClickOnElementList(Pages.ShoppingCartPage.StoreLocatorPopUp.PickUpAtThisStoreLinkList, 0);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Wait(10);
            I.Click(Pages.CheckoutPage.ContactDetails.NextButton);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.BillingDetails.BillingAddressTextField, TestData.CheckoutPage.BillingDetails.Address);
            I.Fill(Pages.CheckoutPage.BillingDetails.BillingCityTextField, TestData.CheckoutPage.BillingDetails.CityOrSuburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.CheckoutPage.BillingDetails.BillingCityTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.CheckoutPage.BillingDetails.BillingCityTextField, "ENTER");
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.BillingDetails.BillingNextButton);
            I.WaitUntilReady();
            I_SelectPaymentOption(1);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardHolderNameTextField, TestData.CheckoutPage.PaymentDetails.CardHolderName);
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardNumberTextField, TestData.CheckoutPage.PaymentDetails.CardNumber);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.PaymentDetails.ExpiryDateTextField, TestData.CheckoutPage.PaymentDetails.ExpiryDate);
            I.Fill(Pages.CheckoutPage.PaymentDetails.ExpiryYearTextField, TestData.CheckoutPage.PaymentDetails.ExpiryYear);
            I.Fill(Pages.CheckoutPage.PaymentDetails.SecurityCodeTextField, TestData.CheckoutPage.PaymentDetails.SecurityCode);
            I.Click(Pages.CheckoutPage.PaymentDetails.PaymentNext);
            I.Wait(10);
            I.AmOn(Pages.CheckoutSummaryPage.Url);
            I.See(Pages.CheckoutSummaryPage.ContactDetailsSection);
            I.See(Pages.CheckoutSummaryPage.BillingDetailsSection);
            I.See(Pages.CheckoutSummaryPage.PaymentDetailSection);
            I.See(Pages.CheckoutSummaryPage.EditButton);
            I.See(Pages.CheckoutSummaryPage.ConfirmPaymentButton);
        }


        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CheckoutPage_ProceedToConfirmationPage()
        {
            I_CreateNewProfile();
            I_AddItemToCart();
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab);
            I.ClickDropDownList(Pages.ShoppingCartPage.DeliveryDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.ShoppingCartPage.DeliveryDropDownList, I_GetDeliveryOptionValue("In Store Pick Up"));
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.SelectStoreButton);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.StoreLocatorPopUp.ShowAllStoresButton);
            I.WaitUntilReady();
            I.ClickOnElementList(Pages.ShoppingCartPage.StoreLocatorPopUp.PickUpAtThisStoreLinkList, 0);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.CheckoutButton);
            I.Wait(10);
            I.Click(Pages.CheckoutPage.ContactDetails.NextButton);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.BillingDetails.BillingAddressTextField, TestData.CheckoutPage.BillingDetails.Address);
            I.Fill(Pages.CheckoutPage.BillingDetails.BillingCityTextField, TestData.CheckoutPage.BillingDetails.CityOrSuburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.CheckoutPage.BillingDetails.BillingCityTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.CheckoutPage.BillingDetails.BillingCityTextField, "ENTER");
            I.WaitUntilReady();
            I.Click(Pages.CheckoutPage.BillingDetails.BillingNextButton);
            I.WaitUntilReady();
            I_SelectPaymentOption(1);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardHolderNameTextField, TestData.CheckoutPage.PaymentDetails.CardHolderName);
            I.Fill(Pages.CheckoutPage.PaymentDetails.CardNumberTextField, TestData.CheckoutPage.PaymentDetails.CardNumber);
            I.WaitUntilReady();
            I.Fill(Pages.CheckoutPage.PaymentDetails.ExpiryDateTextField, TestData.CheckoutPage.PaymentDetails.ExpiryDate);
            I.Fill(Pages.CheckoutPage.PaymentDetails.ExpiryYearTextField, TestData.CheckoutPage.PaymentDetails.ExpiryYear);
            I.Fill(Pages.CheckoutPage.PaymentDetails.SecurityCodeTextField, TestData.CheckoutPage.PaymentDetails.SecurityCode);
            I.Click(Pages.CheckoutPage.PaymentDetails.PaymentNext);
            I.Wait(10);
            I.Click(Pages.CheckoutSummaryPage.ConfirmPaymentButton);
            I.Wait(10);
            I.See(Pages.CheckoutSummaryPage.SubmitLabel);
        }
    }
}
