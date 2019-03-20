using NUnit.Framework;
using OpenQA.Selenium;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using System;

namespace RadioRentals.Tests.Login
{
    /**
    *
    * This class covers the user actions of the Login page of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    public class LoginPageTests : TestBase
    {

        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.Regression)]
        public void LoginPage_NavigateToLoginPage()
        {
            I.Open(Pages.LoginPage.Url);
            I.AmOn(Pages.LoginPage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.Regression)]
        public void LoginPage_PresenceOfElements()
        {
            I.Open(Pages.LoginPage.Url);
            I.SeeText(Pages.LoginPage.HeaderTitle, TestData.LoginPage.HeaderTitle);
            I.See(Pages.LoginPage.EmailAddressTextField);
            I.See(Pages.LoginPage.PasswordTextField);
            I.See(Pages.LoginPage.RememberMeCheckbox);
            I.See(Pages.LoginPage.ForgotYourPasswordLink);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.Demo)]
        public void LoginPage_LoginWithValidEmailAndCorrectPassword()
        {
            I.Open(Pages.LoginPage.Url);
            I.Fill(Pages.LoginPage.EmailAddressTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.LoginPage.SignInButton);
            I.WaitUntilReady();
            I.DontSeeLinkText(Pages.LayoutPage.SignOutLink, TestData.LayoutPage.LoginLinkText);
        }

        [Test]
        [Category(Categories.Regression)]
        public void LoginPage_LoginWithValidEmailInIncorrectFormatAndCorrectPassword()
        {
            I.Open(Pages.LoginPage.Url);
            I.Fill(Pages.LoginPage.EmailAddressTextField, TestData.LoginPage.ValidEmailAddressIncorrectFormat);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.LoginPage.SignInButton);
            I.SeeText(Pages.LoginPage.WrongUsernameOrPasswordValidationMessage, TestData.LoginPage.WrongUsernameOrPasswordMessageText);
        }

        [Test]
        [Category(Categories.Regression)]
        public void LoginPage_LoginWithValidEmailInCorrectFormatAndIncorrectPassword()
        {
            I.Open(Pages.LoginPage.Url);
            I.Fill(Pages.LoginPage.EmailAddressTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.InvalidPassword);
            I.Click(Pages.LoginPage.SignInButton);
            I.SeeText(Pages.LoginPage.WrongUsernameOrPasswordValidationMessage, TestData.LoginPage.WrongUsernameOrPasswordMessageText);
        }

        [Test]
        [Category(Categories.Regression)]
        public void LoginPage_BlankFieldsOrNullValues()
        {
            I.Open(Pages.LoginPage.Url);
            I.ClearText(Pages.LoginPage.EmailAddressTextField);
            I.Fill(Pages.LoginPage.EmailAddressTextField, "");
            I.ClearText(Pages.LoginPage.PasswordTextField);
            I.Fill(Pages.LoginPage.PasswordTextField, "");
            I.Click(Pages.LoginPage.SignInButton);
            I.SeeText(Pages.LoginPage.EmailRequiredFieldValidationMessage, TestData.LoginPage.RequiredFieldValidationMessageText);
        }

        [Test]
        [Category(Categories.Regression)]
        public void LoginPage_LoginWithInvalidEmailAndPassword()
        {
            I.Open(Pages.LoginPage.Url);
            I.Fill(Pages.LoginPage.EmailAddressTextField,TestData.LoginPage.InvalidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.InvalidPassword);
            I.Click(Pages.LoginPage.SignInButton);
            I.SeeText(Pages.LoginPage.WrongUsernameOrPasswordValidationMessage, TestData.LoginPage.WrongUsernameOrPasswordMessageText);
        }

        [Test]
        [Category(Categories.Regression)]
        public void LoginPage_PasswordEncryption()
        {
            I.Open(Pages.LoginPage.Url);
            I.SeeAttributeValue(Pages.LoginPage.PasswordTextField, "type", "password");
        }

        [Test]
        [Category(Categories.Regression)]
        public void LoginPage_RememberMeRemembersEmailAndPassword()
        {
            I.Open(Pages.LoginPage.Url);
            I.Fill(Pages.LoginPage.EmailAddressTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Check(Pages.LoginPage.RememberMeCheckbox);
            I.Click(Pages.LoginPage.SignInButton);
            I.WaitUntilReady();
            I.Click(Pages.LayoutPage.LoginLink);
            I.WaitUntilReady();
            I.Click(Pages.LayoutPage.SignOutLink);
            I.Open(Pages.LoginPage.Url);
            I.SeeTextValue(Pages.LoginPage.EmailAddressTextField, TestData.LoginPage.ValidEmailAddress);
            I.SeeTextValue(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
        }
    }
}