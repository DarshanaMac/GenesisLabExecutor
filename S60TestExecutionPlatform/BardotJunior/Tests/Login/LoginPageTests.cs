using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests.Login
{
   partial class LoginPageTests :TestBase
    {
        
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void LoginPage_NavigateToEmailLoginPage()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.Click(Pages.LayoutPage.LoginIcon);
            I.AmOn(Pages.LoginPage.Url);
        }
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void LoginPage_LoginWithValidUsernameAndPassword()
        {
            object emailAddress = I_GenerateUniqueMailAddressForNewProfile();

            I_CreateNewUser(emailAddress);
            I.WaitUntilReady();
            I.Click(Pages.LayoutPage.LogoutLink);
            I.Open(Pages.HomePage.Url);
            I.WaitUntilReady();
            I.Click(Pages.LayoutPage.LoginIcon);
            I.Fill(Pages.LoginPage.EmailTextField, emailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.LoginPage.LoginButton);
            I.WaitUntilReady();
            I.See(Pages.MyAccountPage.UserPanel);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        public void LoginPage_VerifyTheLoginIconAfterUserLoginToTheSystem()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.Click(Pages.LayoutPage.LoginIcon);
            I.Fill(Pages.LoginPage.EmailTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.LoginPage.LoginButton);
            I.See(Pages.MyAccountPage.UserPanel);
            I.See(Pages.MyAccountPage.ViewOrderPanel);
            I.See(Pages.MyAccountPage.LogOutLink);
        }
    }
}
