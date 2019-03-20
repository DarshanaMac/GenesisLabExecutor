using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using S60TestExecutionPlatform.Utility;

namespace Bardot.Tests.MyAccount
{
  partial class MyAccountPageTests : TestBase
    {
        public void I_EditProfileDetails() {
            string FirstName = I.GetAttibuteValue(Pages.ProfilePage.FirstNameTextField,"value");
            string LastName = I.GetAttibuteValue(Pages.ProfilePage.LastNameTextField,"value");

            string NewFirstName = FirstName + "Mike";
            string NewLastName = LastName + "Joe";
            string FullName = NewFirstName +" "+ NewLastName;

            I.Fill(Pages.ProfilePage.FirstNameTextField, NewFirstName);
            I.Fill(Pages.ProfilePage.LastNameTextField, NewLastName);
            I.Fill(Pages.ProfilePage.PasswordTextField,TestData.LoginPage.ValidPassword);
            I.Click(Pages.ProfilePage.ApplyButton);
            I.WaitUntilReady();
            I.SeeText(Pages.MyAccountPage.UserNameLabel,FullName);
        }

        static private object I_GenerateUniqueMailAddressForNewProfile()
        {
            long uniqueNumber = Helper.GetUniqueNumericValue();
            object emailAddress = "testbardot" + uniqueNumber + "@s60.com.au";
            return emailAddress;
        }


        public void I_CreateNewUser(object emailAddress) {

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
