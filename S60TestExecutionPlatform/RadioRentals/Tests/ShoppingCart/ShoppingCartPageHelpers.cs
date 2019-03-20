using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace RadioRentals.Tests.ShoppingCart
{
    partial class ShoppingCartPageTests : TestBase
    {
        public void I_LoginAsCustomer()
        {
            I.Open(Pages.LoginPage.Url);
            I.Fill(Pages.LoginPage.EmailAddressTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.LoginPage.SignInButton);
        }

        public void I_RemoveItems()
        {
            if (I.SeeExist(Pages.ShoppingCartPage.CloseButton))
            {
                int count = I.GetElementCount(Pages.ShoppingCartPage.CloseButton);
                for (int j = 1; j <= count; j++)
                {
                    I.ClickOnElementList(Pages.ShoppingCartPage.CloseButton, 0);
                    I.WaitUntilReady();
                    I.Click(Pages.ShoppingCartPage.RemoveItemPopUp);
                }
            }
        }

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
            I.Open(TestData.Products.VirtualProduct.Url);
            I.RefreshPage();
            I.WaitUntilReady();
            I.Click(Pages.ProductDetailsPage.AddToCartButton);
            I.Open(Pages.ShoppingCartPage.Url);
        }

        public void I_ChangeLocation() {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.LocationButton);
            I.WaitUntilReady();
            I.Fill(Pages.LayoutPage.LocationCodeTextField, TestData.Location.Name);
            I.ClickKeyBoardEvent(Pages.LayoutPage.LocationCodeTextField, "TAB");
            I.Click(Pages.LayoutPage.LocationSaveButton);
            I.WaitUntilReady();
        }

        public string I_SetInstallation(string option)
        {
            switch (option)
            {
                case "1YR 24/7 PHONE SUPPORT": return "RRW_IADRPCP3::1YR 24/7 PHONE SUPPORT::$130.00";
                case "1YR 24/7 PHONE SUPPORT + 2HRS IN HOME SUPPORT": return "RRW_IADRPCP1::1YR 24/7 PHONE SUPPORT + 2HRS IN HOME SUPPORT::$420.00";
                case "1YR 24/7 PHONE SUPPORT + 3HRS IN HOME SUPPORT": return "RRW_IADRPCP2::1YR 24/7 PHONE SUPPORT + 3HRS IN HOME SUPPORT::$565.00";
            }
            return "0";
        }

        public void I_VerifyInstallationItem()
        {

            string itemname = I.RememberText(Pages.ShoppingCartPage.InstallationDropDownListValue);
            I.SeeText(Pages.ShoppingCartPage.SummaryInstallationItem, itemname);
            I.SeeText(Pages.ShoppingCartPage.SummaryInstallationItemPrice, TestData.ShoppingCartByOrRentPage.VirtualProductInstallationPrice);
        }

    }
}
