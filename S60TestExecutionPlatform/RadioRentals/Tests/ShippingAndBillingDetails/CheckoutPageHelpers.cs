using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using OpenQA.Selenium;
using S60TestExecutionPlatform.Utility;

namespace RadioRentals.Tests.ShippingAndBillingDetails
{
    partial class CheckoutPageTests : TestBase
    {
        public void I_RemoveItemsRentCartAndBuyCart()
        {
            int count = I.GetElementCount(Pages.ShoppingCartPage.RentCartCloseButton);
            for (int j = 1; j <= count; j++)
            {
                if (I.SeeExist(Pages.ShoppingCartPage.RentCartCloseButton))
                {
                    I.WaitUntilReady();
                    I.ClickOnElementList(Pages.ShoppingCartPage.RentCartCloseButton, 0);
                    I.WaitUntilReady();
                    I.Click(Pages.ShoppingCartPage.RemoveItemPopUp);
                }
            }
            int CountBuyCart = I.GetElementCount(Pages.ShoppingCartPage.CloseButton);
            I.WaitUntilReady();
            I.Click(Pages.ShoppingCartPage.GoToBuyCartTab);
            for (int n = 1; n <= CountBuyCart; n++)
            {
                if (I.SeeExist(Pages.ShoppingCartPage.CloseButton))
                {
                    I.WaitUntilReady();
                    I.ClickOnElementList(Pages.ShoppingCartPage.CloseButton, 0);
                    I.WaitUntilReady();
                    I.Click(Pages.ShoppingCartPage.RemoveItemPopUp);
                }
            }
        }

        public void I_AddItemToCart()
        {
            I.Open(TestData.Products.InStock.Url);
            I.RefreshPage();
            I.Wait(10);
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.Click(Pages.LayoutPage.CartButton);
            I.WaitUntilReady();
            I.Open(Pages.ShoppingCartPage.Url);
            I.WaitUntilReady();
        }

        public void I_VerifyContactDetailPageAttributes()
        {
            I.See(Pages.CheckoutPage.ContactDetails.FirstNameTextField);
            I.See(Pages.CheckoutPage.ContactDetails.LastNameTextField);
            I.See(Pages.CheckoutPage.ContactDetails.EmailTextField);
            I.See(Pages.CheckoutPage.ContactDetails.PhoneNumberTextField);
        }

        public void I_VerifyBillingDetailsPageAttributes()
        {
            I.See(Pages.CheckoutPage.BillingDetails.BillingDetailsHeaderTitle);
            I.See(Pages.CheckoutPage.BillingDetails.BillingAddressTextField);
            I.See(Pages.CheckoutPage.BillingDetails.BillingCityTextField);
            I.See(Pages.CheckoutPage.BillingDetails.BillingStateTextField);
            I.See(Pages.CheckoutPage.BillingDetails.BillingPostCodeTextField);
            I.See(Pages.CheckoutPage.BillingDetails.BillingNextButton);
        }

        public void I_VerifyPaymentDetailsPageAttributes()
        {
            I.See(Pages.CheckoutPage.PaymentDetails.PaymentDetailsHeaderTitle);
            I.See(Pages.CheckoutPage.PaymentDetails.PaymentMethodsRadioButton);
            I.See(Pages.CheckoutPage.PaymentDetails.CardHolderNameTextField);
            I.See(Pages.CheckoutPage.PaymentDetails.CardNumberTextField);
            I.See(Pages.CheckoutPage.PaymentDetails.ExpiryDateTextField);
            I.See(Pages.CheckoutPage.PaymentDetails.SecurityCodeTextField);
            I.See(Pages.CheckoutPage.PaymentDetails.PaymentNext);
        }

        public string I_GetDeliveryOptionValue(string deliveryStatus)
        {
            switch (deliveryStatus)
            {
                case "Delivery": return "19691645-d59e-4a94-8954-b2365b5288be";
                case "In Store Pick Up": return "947550dc-3831-4f0d-96aa-b43a7bcfd63d";
            }
            return "0";
        }

        public void I_SelectPaymentOption(int PaymentOption)
        {
            switch (PaymentOption)
            {
                case 1:
                    I.Click(Pages.CheckoutPage.PaymentDetails.PaymentOptionVisaRadioButton);
                    break;
                case 2:
                    I.Click(Pages.CheckoutPage.PaymentDetails.PaymentOptionMasterRadioButton);
                    break;
            }
        }

        private object I_GenerateUniqueMailAddressForNewProfile()
        {
            long uniqueNumber = Helper.GetUniqueNumericValue();
            object emailAddress = "rr" + uniqueNumber + "@gmail.com";
            return emailAddress;
        }

        public void I_CreateNewProfile()
        {
            object emailAddress = I_GenerateUniqueMailAddressForNewProfile();
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, Actions.I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, emailAddress);
            I.Fill(Pages.RegisterAccountPage.MobileNumberTextField, TestData.RegisterAccountPage.MobileNumber);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.WaitUntilReady();
        }
    }
}
