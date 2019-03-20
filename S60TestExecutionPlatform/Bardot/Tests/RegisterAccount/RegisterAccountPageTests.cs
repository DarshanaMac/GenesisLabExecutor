using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.RegisterAccount
{
    

    partial class RegisterAccountPageTests : TestBase
    {
        object emailAddress = I_GenerateUniqueMailAddressForNewProfile();

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority4)]
        public void RegisterAccountPage_NavigateToRegisterAccountPage()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.MouseHoverMenuItemByDisplayText(Pages.LayoutPage.LoginIcon, TestData.LayoutPage.LoginText);
            I.Click(Pages.LayoutPage.RegisterLink);
            I.See(Pages.RegisterPage.RegisterPageHeaderText);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority4)]
        public void RegisterAccountPage_PresenceOfElements()
        {
            I.Open(Pages.RegisterPage.Url);
            I_HandlePopUp();
            I.See(Pages.RegisterPage.FirstNameTextField);
            I.See(Pages.RegisterPage.LastNameTextField);
            I.See(Pages.RegisterPage.MobileTextField);
            I.SeeDropDownListForSFCC(Pages.RegisterPage.DateOfBirthDropDownList);
            I.SeeDropDownListForSFCC(Pages.RegisterPage.MonthDropDownList);
            I.SeeDropDownListForSFCC(Pages.RegisterPage.YearDropDownList);
            I.See(Pages.RegisterPage.EmailTextField);
            I.See(Pages.RegisterPage.PasswordTextField);
            I.See(Pages.RegisterPage.ConfirmPasswordTextField);
            I.See(Pages.RegisterPage.PreferencesPanel);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority4)]
        public void RegisterAccountPage_CreateAnAccount()
        {
            I.Open(Pages.RegisterPage.Url);
            I_HandlePopUp();
            I.Fill(Pages.RegisterPage.FirstNameTextField, TestData.RegisterPage.FirstName);
            I.Fill(Pages.RegisterPage.LastNameTextField, TestData.RegisterPage.LastName);
            I.Fill(Pages.RegisterPage.MobileTextField, TestData.RegisterPage.PhoneNumber);
            I.ClickDropDownListSSA(Pages.RegisterPage.DateOfBirthDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListSSA(Pages.RegisterPage.DateOfBirthDropDownList, 5);
            I.WaitUntilReady();
            I.ClickDropDownListSSA(Pages.RegisterPage.MonthDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListSSA(Pages.RegisterPage.MonthDropDownList, I_GetMonthCode((string)TestData.RegisterPage.Month));
            I.WaitUntilReady();
            I.ClickDropDownListSSA(Pages.RegisterPage.YearDropDownList);
            I.SelectValueFromDropDownListSSA(Pages.RegisterPage.YearDropDownList,TestData.RegisterPage.Year);
            I.WaitUntilReady();
            I.Fill(Pages.RegisterPage.EmailTextField, emailAddress);
            I.Fill(Pages.RegisterPage.PasswordTextField, TestData.RegisterPage.Password);
            I.Fill(Pages.RegisterPage.ConfirmPasswordTextField, TestData.RegisterPage.ConfirmPassword);
            I.Check(Pages.RegisterPage.BardotCheckBox);
            I.Click(Pages.RegisterPage.RegistrationButton);
            I.See(Pages.MyAccountPage.UserPanel);
        }


        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority4)]
        public void RegisterAccountPage_CreateAnAccountWithMandatoryFields() {
      
            I.Open(Pages.RegisterPage.Url);
            I_HandlePopUp();
            I.Fill(Pages.RegisterPage.FirstNameTextField, TestData.RegisterPage.FirstName);
            I.Fill(Pages.RegisterPage.LastNameTextField, TestData.RegisterPage.LastName);
            I.Fill(Pages.RegisterPage.MobileTextField, TestData.RegisterPage.PhoneNumber);
            I.Fill(Pages.RegisterPage.EmailTextField,emailAddress);
            I.Fill(Pages.RegisterPage.PasswordTextField, TestData.RegisterPage.Password);
            I.Fill(Pages.RegisterPage.ConfirmPasswordTextField, TestData.RegisterPage.ConfirmPassword);
            I.Check(Pages.RegisterPage.BardotCheckBox);
            I.Click(Pages.RegisterPage.RegistrationButton);
            I.See(Pages.MyAccountPage.UserPanel);
        }
    }
}
