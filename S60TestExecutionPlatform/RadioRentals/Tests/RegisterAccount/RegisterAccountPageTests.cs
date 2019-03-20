using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.RegisterAccount
{
    /**
   *
   * This class covers the user actions of the Register Account page of Radio Rentals. 
   * 
   * @author Kanchana Liyanagamage
   * 
   */
    partial class RegisterAccountPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void RegisterAccountPage_NavigateToRegisterAccountPages()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.AmOn(Pages.RegisterAccountPage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void RegisterAccountPage_PresenceOfElements()
        {
            I.Open(Pages.RegisterAccountPage.Url);           
            I.See(Pages.RegisterAccountPage.FirstNameTextField);
            I.See(Pages.RegisterAccountPage.LastNameTextField);         
            I.See(Pages.RegisterAccountPage.BirthYearTextField);
            I.See(Pages.RegisterAccountPage.EmailTextField);
            I.See(Pages.RegisterAccountPage.MobileNumberTextField);
            I.See(Pages.RegisterAccountPage.VipCardNumberTextField);
            I.See(Pages.RegisterAccountPage.AccountNumberTextField);
            I.See(Pages.RegisterAccountPage.RegisterButton);
            I.See(Pages.RegisterAccountPage.EmailAddressTextField);
            I.See(Pages.RegisterAccountPage.PasswordTextField);
            I.See(Pages.RegisterAccountPage.SignInButton);
            I.See(Pages.RegisterAccountPage.RememberMeCheckbox);
            I.See(Pages.RegisterAccountPage.ForgotYourPasswordLink);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.Demo)]
        public void RegisterAccountPage_CreateProfileWithMandatoryFields()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, I_GenerateUniqueMailAddressForNewProfile());
            I.Fill(Pages.RegisterAccountPage.MobileNumberTextField, TestData.RegisterAccountPage.MobileNumber);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.WaitUntilReady();
            I.SeePartialText(Pages.ThankYouPage.WelcomeMessage, TestData.ThankYouPage.WelcomeMessageText);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void RegisterAccountPage_CreateProfileWithAllFields()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, I_GenerateUniqueMailAddressForNewProfile());
            I.Fill(Pages.RegisterAccountPage.MobileNumberTextField, TestData.RegisterAccountPage.MobileNumber);
            I.Fill(Pages.RegisterAccountPage.VipCardNumberTextField, TestData.RegisterAccountPage.VipCardNumber);
            I.Fill(Pages.RegisterAccountPage.AccountNumberTextField, TestData.RegisterAccountPage.AccountNumber);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.WaitUntilReady();
            I.SeePartialText(Pages.ThankYouPage.WelcomeMessage, TestData.ThankYouPage.WelcomeMessageText);
        }

        [Test]
        [Category(Categories.Regression)]
        [Ignore("Tooltip is not appear for a longtime.")]
        public void RegisterAccountPage_AvailabiltyOfTooltips()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.Click(Pages.RegisterAccountPage.MobileNumberToolIcon);
            I.SeeText(Pages.RegisterAccountPage.MobileNumberTooltip, TestData.RegisterAccountPage.MobileNumberTooltipMessage);
            I.Click(Pages.RegisterAccountPage.VipCardNumberTooltipIcon);
            I.SeeText(Pages.RegisterAccountPage.VipCardNumberToolTip, TestData.RegisterAccountPage.VipCardNumberTooltipMessage);
            I.Click(Pages.RegisterAccountPage.AccountNumberTooltipIcon);
            I.SeeText(Pages.RegisterAccountPage.AccountNumberToolTip, TestData.RegisterAccountPage.AccountNumberToolTipMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_RequiredFieldsValidations()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.SeeText(Pages.RegisterAccountPage.TitleRequiredFieldValidationMessageLabel, TestData.RegisterAccountPage.RequiredFieldValidationMessage);
            I.SeeText(Pages.RegisterAccountPage.FirstNameRequiredFieldValidationMessageLabel, TestData.RegisterAccountPage.RequiredFieldValidationMessage);
            I.SeeText(Pages.RegisterAccountPage.LastNameRequiredFieldValidationMessageLabel, TestData.RegisterAccountPage.RequiredFieldValidationMessage);
            I.SeeText(Pages.RegisterAccountPage.EmailFieldValidationMessageLabel, TestData.RegisterAccountPage.RequiredFieldValidationMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_TitleDropDownListOptionList()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I_VerifyTitleDropDownListOptions((string)Pages.RegisterAccountPage.TitleDropDownList);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_MinimumCharacterLimit()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.Fill(Pages.RegisterAccountPage.AccountNumberTextField, TestData.RegisterAccountPage.IncorrectAccountNumber);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.SeeText(Pages.RegisterAccountPage.AccountNumberCustomErrorValidationMessageLabel, TestData.RegisterAccountPage.AccountNumberValidationTextMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_NamesWithDigitsAndSpecialCharacters()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstNameWitDigitsAndSpecialCharacters);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastNameWitDigitsAndSpecialCharacters);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, TestData.RegisterAccountPage.NewCustomer.EmailAddress1);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.SeePartialText(Pages.RegisterAccountPage.FirstNameRequiredFieldValidationMessageLabel, TestData.RegisterAccountPage.CharacterValidationTextMessage);
            I.SeePartialText(Pages.RegisterAccountPage.LastNameRequiredFieldValidationMessageLabel, TestData.RegisterAccountPage.CharacterValidationTextMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_DateDropDownListOptionList()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I_VerifyDateDropDownListOptions((string)Pages.RegisterAccountPage.DateDropDownList);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_MonthDropDownListOptionList()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I_VerifyMonthDropDownListOptions((string)Pages.RegisterAccountPage.MonthDropDownList);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_AccuracyOfTheDOBIfMonthEndDateIsChosen()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.InvalidBirthDate.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.InvalidBirthDate.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, TestData.RegisterAccountPage.NewCustomer.EmailAddress1);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.SeeText(Pages.RegisterAccountPage.DateOfBirthDayFieldValidationMessageLabel, TestData.RegisterAccountPage.DateOfBirthDayValidationTextMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_FutureDateSelection()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.FutureDate);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, TestData.RegisterAccountPage.NewCustomer.EmailAddress1);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.SeeText(Pages.RegisterAccountPage.DateOfBirthYearFieldValidationMessageLabel, TestData.RegisterAccountPage.DateOfBirthYearValidationTextMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_AccuracyOfDateOfBirthYear()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.PastYear);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, TestData.RegisterAccountPage.NewCustomer.EmailAddress1);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.SeeText(Pages.RegisterAccountPage.DateOfBirthYearFieldValidationMessageLabel, TestData.RegisterAccountPage.PastYearValidationTextMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_EmailIdOfAnExistingAccount()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, TestData.RegisterAccountPage.ExistingEmail);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.SeeText(Pages.RegisterAccountPage.ErrorMessageLabel, TestData.RegisterAccountPage.ExistingEmailAddressValidationTextMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_EmailIdIncorrectFormat()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, TestData.RegisterAccountPage.IncorrectFormatEmail);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.SeeText(Pages.RegisterAccountPage.EmailFieldValidationMessageLabel, TestData.RegisterAccountPage.IncorrectFormatEmailAddressValidationTextMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_MobileNumberIncorrectFormat()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, TestData.RegisterAccountPage.NewCustomer.EmailAddress1);
            I.Fill(Pages.RegisterAccountPage.MobileNumberTextField, TestData.RegisterAccountPage.IncorrectMobileNumber);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            Driver.WaitUnitReady();
            I.SeeText(Pages.RegisterAccountPage.MobileNumberFieldValidationMessageLabel, TestData.RegisterAccountPage.IncorrectFormatMobileNumberValidationTextMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_VIPNumberIncorrectFormat()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, TestData.RegisterAccountPage.NewCustomer.EmailAddress1);
            I.Fill(Pages.RegisterAccountPage.VipCardNumberTextField, TestData.RegisterAccountPage.InccorrectVipNumber);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.WaitUntilReady();
            I.SeeText(Pages.RegisterAccountPage.VipCardNumberFieldValidationMessageLabel, TestData.RegisterAccountPage.NumericFieldValidationTextMessage);
        }

        [Test]
        [Category(Categories.Regression)]
        public void RegisterAccountPage_AccountNumberIncorrectFormat()
        {
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, TestData.RegisterAccountPage.NewCustomer.EmailAddress1);
            I.Fill(Pages.RegisterAccountPage.AccountNumberTextField, TestData.RegisterAccountPage.IncorrectAccountNumber);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.WaitUntilReady();
            I.SeeText(Pages.RegisterAccountPage.AccountNumberCustomErrorValidationMessageLabel, TestData.RegisterAccountPage.AccountNumberValidationTextMessage);
        }
    }
}