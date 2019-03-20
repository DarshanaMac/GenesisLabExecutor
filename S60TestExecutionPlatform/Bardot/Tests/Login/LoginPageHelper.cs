using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using S60TestExecutionPlatform.Utility;

namespace Bardot.Tests.Login
{
   partial class LoginPageTests : TestBase
    {

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
        }

        public void I_HandlePopUp()
        {
            if (I.SeeExist(Pages.LayoutPage.PopUpLabel) == true)
            {
                I.Click(Pages.LayoutPage.IAgreeButton);
            }
        }
    }
}
