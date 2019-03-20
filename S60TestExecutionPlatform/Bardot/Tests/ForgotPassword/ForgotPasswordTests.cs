using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.ForgotPassword
{
    partial class ForgotPasswordTests :TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority8)]
        public void ForgotPassword_PresenceOfElements() {
            I.Open(Pages.LoginPage.Url);
            I_HandlePopUp();
            I.Click(Pages.ForgotPassword.ForgotPasswordLink);
            I.See(Pages.ForgotPassword.EmailTextField);
            I.See(Pages.ForgotPassword.SendButton);
        }
    }
}
