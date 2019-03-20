using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using System;

namespace RadioRentals.Tests.ChangePassword
{
    /**
    *
    * This class covers the user actions of the Change Password page of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class ChangePasswordPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ChangePasswordPage_NavigateChangePasswordPage()
        {
            I_LoginAsCustomer();
            I.Open(Pages.ChangePasswordPage.Url);
            I.AmOn(Pages.ChangePasswordPage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ChangePasswordPage_PresenceOfElements()
        {
            I_LoginAsCustomer();
            I.Open(Pages.ChangePasswordPage.Url);
            I.See(Pages.ChangePasswordPage.OldPasswordTextField);
            I.See(Pages.ChangePasswordPage.NewPasswordTextField);
            I.See(Pages.ChangePasswordPage.PasswordConfirmField);
            I.See(Pages.ChangePasswordPage.SaveButton);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ChangePasswordPage_ChangeOfPassword()
        {
            I_LoginAsCustomer();
            I.Open(Pages.ChangePasswordPage.Url);
            I.Fill(Pages.ChangePasswordPage.OldPasswordTextField, TestData.LoginPage.ValidPassword);
            I.Fill(Pages.ChangePasswordPage.NewPasswordTextField, "Test@123");
            I.Fill(Pages.ChangePasswordPage.PasswordConfirmField, "Test@123");
            I.Click(Pages.ChangePasswordPage.SaveButton);
            I.Click(Pages.LayoutPage.LoginLink);
            I.WaitUntilReady();
            I.Click(Pages.LayoutPage.SignOutLink);
            I_LoginAsCustomer();
            I.Fill(Pages.LoginPage.EmailAddressTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, "Test@123");
            I.Click(Pages.LoginPage.SignInButton);
            I.WaitUntilReady();
            I.Open(Pages.ChangePasswordPage.Url);
            I.Fill(Pages.ChangePasswordPage.OldPasswordTextField, "Test@123");
            I.Fill(Pages.ChangePasswordPage.NewPasswordTextField, TestData.LoginPage.ValidPassword);
            I.Fill(Pages.ChangePasswordPage.PasswordConfirmField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.ChangePasswordPage.SaveButton);
            I.AmOn(Pages.HomePage.Url);
        }
    }
}
