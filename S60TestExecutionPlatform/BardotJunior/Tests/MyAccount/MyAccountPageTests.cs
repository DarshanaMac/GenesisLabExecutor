using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests.MyAccount
{
    partial class MyAccountPageTests :TestBase
    {

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void MyAccountPage_VerifyThePresenceOfMyAccountNavigation() {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.Click(Pages.LayoutPage.LoginIcon);
            I.Fill(Pages.LoginPage.EmailTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.LoginPage.LoginButton);
            I.See(Pages.MyAccountPage.UserPanel);
            I.AmOn(Pages.MyAccountPage.Url);
            I.See(Pages.MyAccountPage.PersonalDataTile);
            I.See(Pages.MyAccountPage.ViewOrderPanel);
            I.See(Pages.MyAccountPage.AddressesTile);
            I.See(Pages.MyAccountPage.WishlistTile);
            I.See(Pages.MyAccountPage.PaymentSettingsTile);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void MyAccountPage_ViewAnExistingProfile() {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.Click(Pages.LayoutPage.LoginIcon);
            I.Fill(Pages.LoginPage.EmailTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.LoginPage.LoginButton);
            I.Click(Pages.MyAccountPage.PersonalDataTile);
            I.AmOn(Pages.ProfilePage.Url);
            I.See(Pages.ProfilePage.FirstNameTextField);
            I.See(Pages.ProfilePage.LastNameTextField);
            I.See(Pages.ProfilePage.MobileTextField);
            I.See(Pages.ProfilePage.DayDropDownList);
            I.See(Pages.ProfilePage.MonthDropDownList);
            I.See(Pages.ProfilePage.YearDropDownList);
            I.See(Pages.ProfilePage.EmailTextField);
            I.See(Pages.ProfilePage.PasswordTextField);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void MyAccountPage_EditProfile() {
            object emailAddress = I_GenerateUniqueMailAddressForNewProfile();
            I_CreateNewUser(emailAddress);
            I.Click(Pages.MyAccountPage.PersonalDataTile);
            I.AmOn(Pages.ProfilePage.Url);
            I_EditProfileDetails();
        }
    }
}
