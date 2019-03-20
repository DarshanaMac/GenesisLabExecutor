using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.Login
{
    class LoginPageTests : TestBase
    {
        public void LoginPage_NavigateToEmailLoginPage() {
            I.Open(Pages.LoginPage.Url);
            I.Fill(Pages.LoginPage.EmailAddressTextField,TestData.Login.UserName);
            I.Fill(Pages.LoginPage.PasswordTextField,TestData.Login.Password);
            I.Click(Pages.LoginPage.LoginButton);
        }
    }
}
