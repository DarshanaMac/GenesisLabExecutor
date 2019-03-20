using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using S60TestExecutionPlatform.Utility;

namespace BardotJunior.Tests.Wishlist
{
    partial class WishlistPageTests : TestBase
    {

        public void I_RemoveProductFromWishlist()
        {
            I.NavigateToPage(Pages.WishlistPage.Url,"Yes");
            int items = I.GetElementCount(Pages.WishlistPage.RemoveButton);

            for (int i = 1; i <= items; i++)
            {
                I.Click(Pages.WishlistPage.RemoveButton);
                I.WaitUntilReady();
            }
        }
        public string I_StoreProductNameFromProductDetailsPage(object element)
        {
            string ProductName = I.GetAttributeText(element);
            return ProductName;
        }

        public void I_HandlePopUp()
        {
            if (I.SeeExist(Pages.LayoutPage.PopUpLabel) == true)
            {
                I.Click(Pages.LayoutPage.IAgreeButton);
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

        static private object I_GenerateUniqueMailAddressForNewProfile()
        {
            long uniqueNumber = Helper.GetUniqueNumericValue();
            object emailAddress = "testbardot" + uniqueNumber + "@s60.com.au";
            return emailAddress;
        }

        public void I_CreateNewUser(object emailAddress)
        {

            I.Open(Pages.RegisterPage.Url);
            I_HandlePopUp();
            I.Fill(Pages.RegisterPage.FirstNameTextField, TestData.RegisterPage.FirstName);
            I.Fill(Pages.RegisterPage.LastNameTextField, TestData.RegisterPage.LastName);
            I.Fill(Pages.RegisterPage.MobileTextField, TestData.RegisterPage.PhoneNumber);
            I.Fill(Pages.RegisterPage.EmailTextField, emailAddress);
            I.Fill(Pages.RegisterPage.PasswordTextField, TestData.RegisterPage.Password);
            I.Fill(Pages.RegisterPage.ConfirmPasswordTextField, TestData.RegisterPage.ConfirmPassword);
            I.Click(Pages.RegisterPage.BardotCheckBox);
            I.Click(Pages.RegisterPage.RegistrationButton);
            I.WaitUntilReady();
        }
    }
}
