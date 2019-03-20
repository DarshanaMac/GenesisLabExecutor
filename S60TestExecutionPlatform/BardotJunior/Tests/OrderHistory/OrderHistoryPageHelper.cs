using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using S60TestExecutionPlatform.Utility;

namespace BardotJunior.Tests.OrderHistory 
{
    partial class OrderHistoryPageTests : TestBase
    {
        public void I_CreateNewUser()
        {
            object emailAddress = I_GenerateUniqueMailAddressForNewProfile();
            I.Open(Pages.RegisterPage.Url);
            I_HandlePopUp();
            I.Fill(Pages.RegisterPage.FirstNameTextField, TestData.RegisterPage.FirstName);
            I.Fill(Pages.RegisterPage.LastNameTextField, TestData.RegisterPage.LastName);
            I.Fill(Pages.RegisterPage.MobileTextField, TestData.RegisterPage.PhoneNumber);
            I.Fill(Pages.RegisterPage.EmailTextField, emailAddress);
            I.Fill(Pages.RegisterPage.PasswordTextField, TestData.RegisterPage.Password);
            I.Fill(Pages.RegisterPage.ConfirmPasswordTextField, TestData.RegisterPage.ConfirmPassword);
            I.Check(Pages.RegisterPage.BardotCheckBox);
            I.Click(Pages.RegisterPage.RegistrationButton);
            I.WaitUntilReady();
            I.See(Pages.MyAccountPage.UserPanel);
        }

        static private object I_GenerateUniqueMailAddressForNewProfile()
        {
            long uniqueNumber = Helper.GetUniqueNumericValueTest();
            object emailAddress = "test_bardot" + uniqueNumber + "@s60.com.au";
            return emailAddress;
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

        public string I_GetYearCode(string year)
        {
            switch (year)
            {
                case "2018": return "2018";
                case "2019": return "2019";
                case "2020": return "2020";

            }
            return "0";
        }

        public void I_HandlePopUp()
        {
            if (I.SeeExist(Pages.LayoutPage.PopUpLabel) == true)
            {
                I.Click(Pages.LayoutPage.IAgreeButton);
            }
        }

        public void I_VerifyFillData()
        {
            I.WaitUntilReady();
            string textContent = I.GetAttibuteValue(Pages.ShippingAddressPage.CityTextField, "value");
            if (string.IsNullOrWhiteSpace(textContent))
            {
                I.Fill(Pages.ShippingAddressPage.Address1TextField, TestData.ShippingAddressPage.AddressLine1);
                I.WaitUntilReady();
                I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "DOWN");
                I.ClickKeyBoardEvent(Pages.ShippingAddressPage.Address1TextField, "ENTER");
                I.WaitUntilReady();
            }
        }

        public void I_ClickActiveSwatch()
        {
            int listCount = I.GetElementCount(Pages.ProductDetailsPage.SwatchesSizeLinks);
            for (int i = 0; i <= listCount; i++)
            {
                I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, i);
                if (I.PrecenceOfElement(Pages.ProductDetailsPage.AddToCartButton) == true)
                {
                    break;
                }
            }
        }


        public void I_VerifyFillDataBilling()
        {
            I.WaitUntilReady();
            string textContent = I.GetAttibuteValue(Pages.BillingAddressPage.CityTextField, "value");
            if (string.IsNullOrWhiteSpace(textContent))
            {
                I.Fill(Pages.BillingAddressPage.Address1TextField, TestData.BillingAddressPage.AddressLine1);
                I.WaitUntilReady();
                I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "DOWN");
                I.ClickKeyBoardEvent(Pages.BillingAddressPage.Address1TextField, "ENTER");
                I.WaitUntilReady();
            }
        }
    }
}
