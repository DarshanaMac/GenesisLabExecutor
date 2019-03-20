using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ForgotYourPassword
{
    /**
   *
   * This class covers the user actions of the Forgot Your Password page of Radio Rentals. 
   * 
   * @author Kanchana Liyanagamage
   * 
   */
    partial class ForgotYourPasswordPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ForgotYourPasswordPage_NavigateToForgotYourPasswordPage()
        {
            I.Open(Pages.LoginPage.Url);
            I.Click(Pages.LoginPage.ForgotYourPasswordLink);
            I.AmOn(Pages.ForgotYourPasswordPage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ForgotYourPasswordPage_PresenceOfElements()
        {
            I.Open(Pages.LoginPage.Url);
            I.Click(Pages.LoginPage.ForgotYourPasswordLink);
            I.SeeText(Pages.ForgotYourPasswordPage.HeaderTitle, TestData.ForgotYourPasswordPage.HeaderTitle);
            I.See(Pages.ForgotYourPasswordPage.EmailTextField);
            I.See(Pages.ForgotYourPasswordPage.SendButton);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ForgotYourPasswordPage_SubmitForgotYourPasswordRequest()
        {
            I.Open(Pages.LoginPage.Url);
            I.Click(Pages.LoginPage.ForgotYourPasswordLink);
            I.Fill(Pages.ForgotYourPasswordPage.EmailTextField, TestData.LoginPage.ValidEmailAddress);
            I.Click(Pages.ForgotYourPasswordPage.SendButton);
            I.AmOn(Pages.SubmitForgotYourPasswordPage.Url);
        }
    }
}
