using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ApplyOnline
{
    /**
    *
    * This class covers the user actions of the Personal Details section of Apply Online feature
    * of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class PersonalDetailsPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.ApplyOnlne)]
        public void PersonalDetails_NavigateFromApplyFromPageToResidentialStatusPage() {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.ApplyOnlineButton);
            I.Check(Pages.BeforeYouApplyPage.TermsAndConditionsCheckbox);
            I.Click(Pages.BeforeYouApplyPage.BeginApplicationButton);
            I.AmOn(Pages.PersonalDetailsApplyFromPage.Url);
            I.WaitUntilReady();
            I.Click(Pages.PersonalDetailsApplyFromPage.InStoreRadioButton);
            I.Fill(Pages.PersonalDetailsApplyFromPage.SelectAStore, TestData.PersonalDetailsApplyFromPage.Store);
            I.ClickRadioButton(Pages.PersonalDetailsApplyFromPage.AreYouBeingAssistedByASalesPersonAndDoYouKnowTheirName.No);
            I.Click(Pages.PersonalDetailsApplyFromPage.NextButton);
            I.AmOn(Pages.PersonalDetailsContactDetailsPage.Url);
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList, TestData.PersonalDetailsContactDetailsPage.Title);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.FirstNameTextField, TestData.PersonalDetailsContactDetailsPage.FirstName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MiddleNameTextField, TestData.PersonalDetailsContactDetailsPage.MiddleName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.LastNameTextField, TestData.PersonalDetailsContactDetailsPage.LastName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.EmailTextField, TestData.PersonalDetailsContactDetailsPage.Email);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.ConfirmMailTextField, TestData.PersonalDetailsContactDetailsPage.ConfirmEmail);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.AreaCodeTextField, TestData.PersonalDetailsContactDetailsPage.AreadCode);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.HomePhoneNumberTextField, TestData.PersonalDetailsContactDetailsPage.HomePhoneNumber);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MobilePhoneTextField, TestData.PersonalDetailsContactDetailsPage.MobilePhone);
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList, TestData.PersonalDetailsContactDetailsPage.PreferredContactTime);
            I.Click(Pages.PersonalDetailsContactDetailsPage.NextButton);
            I.AmOn(Pages.PersonalDetailsInrentAccountPage.Url);
            I.WaitUntilReady();
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.AreYouCurrentlyOrHaveYouEverBeenAnInRentCustomer.InRentCustomerRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.DoYouHaveYourAccountNumberOrInRentCardNumber.YesRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.Type.AccountNumberRadioButton);
            I.Fill(Pages.PersonalDetailsInrentAccountPage.NumberTextField, TestData.PersonalDetailsInrentAccountPage.Number);
            I.Click(Pages.PersonalDetailsInrentAccountPage.NextButton);
            I.WaitUntilReady();
            if (I.SeeExist(Pages.PersonalDetailsInrentAccountPage.ConfirmationToProceedPopUp))
            {
                I.Click(Pages.PersonalDetailsInrentAccountPage.IWillCompleteThisApplicationButton);
            }
            I.AmOn(Pages.PersonalDetailsInformationPage.Url);
            I.Wait(10);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.GenderDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.GenderDropDownList, I_GetGenderType((string)TestData.PersonalDetailsInformationPage.Gender));
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.DateDropDownList, (string)TestData.PersonalDetailsInformationPage.Date);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.MonthDropDownList, I_GetMonthIndex((string)TestData.PersonalDetailsInformationPage.Month));
            I.Fill(Pages.PersonalDetailsInformationPage.DateOfBirthYearTextField, TestData.PersonalDetailsInformationPage.Year);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.IdentificationTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdentificationTypeDropDownList, I_GetIdentificationType((string)TestData.PersonalDetailsInformationPage.ItentificationType));
            I.Fill(Pages.PersonalDetailsInformationPage.IdentifcationNumber, TestData.PersonalDetailsInformationPage.IdentificationNumber);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.IdentificationExpiryDayDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdentificationExpiryDayDropDownList, TestData.PersonalDetailsInformationPage.ItentificationExpiryDate);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.IdentificationExpiryMonthDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdentificationExpiryMonthDropDownList, I_GetMonthIndex((string)TestData.PersonalDetailsInformationPage.ItentificationExpiryMonth));
            I.Fill(Pages.PersonalDetailsInformationPage.IdentificationExpiryYear, TestData.PersonalDetailsInformationPage.ItentificationExpiryYear);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.IdShowWhereYouAreCurrentlyLivingDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdShowWhereYouAreCurrentlyLivingDropDownList, I_GetIdShowCurrentlyLiving((string)TestData.PersonalDetailsInformationPage.DoesYourIdShowWhereYouAreCurrentlyLiving.Yes));
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.MaritalStatusDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.MaritalStatusDropDownList, I_GetMaritalStatus((string)TestData.PersonalDetailsInformationPage.MartialStatus.Single));
            I.ClickRadioButton(Pages.PersonalDetailsInformationPage.HaveYouEverChangedYourNameVisaMarriageDeedPoolOrViaAnyOtherMeans.NoRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInformationPage.AreYouAnAustralianCitizenOrAPermanentAustralianResident.YesRadioButton);
            I.Click(Pages.PersonalDetailsInformationPage.NextButton);
            I.Wait(10);
            I.AmOn(Pages.ResidentialDetailsStatusPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void PersonalDetails_NavigateToApplyFromPage()
        {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.ApplyOnlineButton);
            I.Check(Pages.BeforeYouApplyPage.TermsAndConditionsCheckbox);
            I.Click(Pages.BeforeYouApplyPage.BeginApplicationButton);
            I.AmOn(Pages.PersonalDetailsApplyFromPage.Url);            
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void PersonalDetails_NavigateToContactDetailsPage() {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.ApplyOnlineButton);
            I.Check(Pages.BeforeYouApplyPage.TermsAndConditionsCheckbox);
            I.Click(Pages.BeforeYouApplyPage.BeginApplicationButton);
            I.Click(Pages.PersonalDetailsApplyFromPage.InStoreRadioButton);
            I.Fill(Pages.PersonalDetailsApplyFromPage.SelectAStore, TestData.PersonalDetailsApplyFromPage.Store);
            I.ClickRadioButton(Pages.PersonalDetailsApplyFromPage.AreYouBeingAssistedByASalesPersonAndDoYouKnowTheirName.No);
            I.Click(Pages.PersonalDetailsApplyFromPage.NextButton);
            I.AmOn(Pages.PersonalDetailsContactDetailsPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void PersonalDetails_NavigateToInrentAccountPage()
        {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.ApplyOnlineButton);
            I.Check(Pages.BeforeYouApplyPage.TermsAndConditionsCheckbox);
            I.Click(Pages.BeforeYouApplyPage.BeginApplicationButton);
            I.Click(Pages.PersonalDetailsApplyFromPage.InStoreRadioButton);
            I.Fill(Pages.PersonalDetailsApplyFromPage.SelectAStore, TestData.PersonalDetailsApplyFromPage.Store);
            I.ClickRadioButton(Pages.PersonalDetailsApplyFromPage.AreYouBeingAssistedByASalesPersonAndDoYouKnowTheirName.No);
            I.Click(Pages.PersonalDetailsApplyFromPage.NextButton);
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList, TestData.PersonalDetailsContactDetailsPage.Title);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.FirstNameTextField, TestData.PersonalDetailsContactDetailsPage.FirstName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MiddleNameTextField, TestData.PersonalDetailsContactDetailsPage.MiddleName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.LastNameTextField, TestData.PersonalDetailsContactDetailsPage.LastName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.EmailTextField, TestData.PersonalDetailsContactDetailsPage.Email);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.ConfirmMailTextField, TestData.PersonalDetailsContactDetailsPage.ConfirmEmail);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.AreaCodeTextField, TestData.PersonalDetailsContactDetailsPage.AreadCode);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.HomePhoneNumberTextField, TestData.PersonalDetailsContactDetailsPage.HomePhoneNumber);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MobilePhoneTextField, TestData.PersonalDetailsContactDetailsPage.MobilePhone);
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList, TestData.PersonalDetailsContactDetailsPage.PreferredContactTime);
            I.Click(Pages.PersonalDetailsContactDetailsPage.NextButton);
            I.AmOn(Pages.PersonalDetailsInrentAccountPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void PersonalDetails_NavigateToConfirmationToProceedPopUp()
        {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.ApplyOnlineButton);
            I.Check(Pages.BeforeYouApplyPage.TermsAndConditionsCheckbox);
            I.Click(Pages.BeforeYouApplyPage.BeginApplicationButton);
            I.Click(Pages.PersonalDetailsApplyFromPage.InStoreRadioButton);
            I.Fill(Pages.PersonalDetailsApplyFromPage.SelectAStore, TestData.PersonalDetailsApplyFromPage.Store);
            I.ClickRadioButton(Pages.PersonalDetailsApplyFromPage.AreYouBeingAssistedByASalesPersonAndDoYouKnowTheirName.No);
            I.Click(Pages.PersonalDetailsApplyFromPage.NextButton);
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList, TestData.PersonalDetailsContactDetailsPage.Title);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.FirstNameTextField, TestData.PersonalDetailsContactDetailsPage.FirstName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MiddleNameTextField, TestData.PersonalDetailsContactDetailsPage.MiddleName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.LastNameTextField, TestData.PersonalDetailsContactDetailsPage.LastName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.EmailTextField, TestData.PersonalDetailsContactDetailsPage.Email);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.ConfirmMailTextField, TestData.PersonalDetailsContactDetailsPage.ConfirmEmail);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.AreaCodeTextField, TestData.PersonalDetailsContactDetailsPage.AreadCode);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.HomePhoneNumberTextField, TestData.PersonalDetailsContactDetailsPage.HomePhoneNumber);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MobilePhoneTextField, TestData.PersonalDetailsContactDetailsPage.MobilePhone);
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList, TestData.PersonalDetailsContactDetailsPage.PreferredContactTime);
            I.Click(Pages.PersonalDetailsContactDetailsPage.NextButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.AreYouCurrentlyOrHaveYouEverBeenAnInRentCustomer.InRentCustomerRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.DoYouHaveYourAccountNumberOrInRentCardNumber.YesRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.Type.AccountNumberRadioButton);
            I.Fill(Pages.PersonalDetailsInrentAccountPage.NumberTextField, TestData.PersonalDetailsInrentAccountPage.Number);
            I.Click(Pages.PersonalDetailsInrentAccountPage.NextButton);
            I.WaitUntilReady();
            if (I.SeeExist(Pages.PersonalDetailsInrentAccountPage.ConfirmationToProceedPopUp))
            {
                I.See(Pages.PersonalDetailsInrentAccountPage.ConfirmationToProceedPopUp);               
            }           
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void PersonalDetails_NavigateToInformationPage()
        {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.ApplyOnlineButton);
            I.Check(Pages.BeforeYouApplyPage.TermsAndConditionsCheckbox);
            I.Click(Pages.BeforeYouApplyPage.BeginApplicationButton);
            I.Click(Pages.PersonalDetailsApplyFromPage.InStoreRadioButton);
            I.Fill(Pages.PersonalDetailsApplyFromPage.SelectAStore, TestData.PersonalDetailsApplyFromPage.Store);
            I.ClickRadioButton(Pages.PersonalDetailsApplyFromPage.AreYouBeingAssistedByASalesPersonAndDoYouKnowTheirName.No);
            I.Click(Pages.PersonalDetailsApplyFromPage.NextButton);
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList, TestData.PersonalDetailsContactDetailsPage.Title);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.FirstNameTextField, TestData.PersonalDetailsContactDetailsPage.FirstName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MiddleNameTextField, TestData.PersonalDetailsContactDetailsPage.MiddleName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.LastNameTextField, TestData.PersonalDetailsContactDetailsPage.LastName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.EmailTextField, TestData.PersonalDetailsContactDetailsPage.Email);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.ConfirmMailTextField, TestData.PersonalDetailsContactDetailsPage.ConfirmEmail);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.AreaCodeTextField, TestData.PersonalDetailsContactDetailsPage.AreadCode);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.HomePhoneNumberTextField, TestData.PersonalDetailsContactDetailsPage.HomePhoneNumber);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MobilePhoneTextField, TestData.PersonalDetailsContactDetailsPage.MobilePhone);
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList, TestData.PersonalDetailsContactDetailsPage.PreferredContactTime);
            I.Click(Pages.PersonalDetailsContactDetailsPage.NextButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.AreYouCurrentlyOrHaveYouEverBeenAnInRentCustomer.InRentCustomerRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.DoYouHaveYourAccountNumberOrInRentCardNumber.YesRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.Type.AccountNumberRadioButton);
            I.Fill(Pages.PersonalDetailsInrentAccountPage.NumberTextField, TestData.PersonalDetailsInrentAccountPage.Number);
            I.Click(Pages.PersonalDetailsInrentAccountPage.NextButton);
            I.WaitUntilReady();
            if (I.SeeExist(Pages.PersonalDetailsInrentAccountPage.ConfirmationToProceedPopUp)) {
                I.Click(Pages.PersonalDetailsInrentAccountPage.IWillCompleteThisApplicationButton);
            }
            I.WaitUntilReady();
            I.AmOn(Pages.PersonalDetailsInformationPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void PersonalDetails_NavigateToResidentialStatusPage()
        {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.ApplyOnlineButton);
            I.Check(Pages.BeforeYouApplyPage.TermsAndConditionsCheckbox);
            I.Click(Pages.BeforeYouApplyPage.BeginApplicationButton);
            I.Click(Pages.PersonalDetailsApplyFromPage.InStoreRadioButton);
            I.Fill(Pages.PersonalDetailsApplyFromPage.SelectAStore, TestData.PersonalDetailsApplyFromPage.Store);
            I.ClickRadioButton(Pages.PersonalDetailsApplyFromPage.AreYouBeingAssistedByASalesPersonAndDoYouKnowTheirName.No);
            I.Click(Pages.PersonalDetailsApplyFromPage.NextButton);
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.TitleDropDownList, TestData.PersonalDetailsContactDetailsPage.Title);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.FirstNameTextField, TestData.PersonalDetailsContactDetailsPage.FirstName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MiddleNameTextField, TestData.PersonalDetailsContactDetailsPage.MiddleName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.LastNameTextField, TestData.PersonalDetailsContactDetailsPage.LastName);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.EmailTextField, TestData.PersonalDetailsContactDetailsPage.Email);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.ConfirmMailTextField, TestData.PersonalDetailsContactDetailsPage.ConfirmEmail);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.AreaCodeTextField, TestData.PersonalDetailsContactDetailsPage.AreadCode);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.HomePhoneNumberTextField, TestData.PersonalDetailsContactDetailsPage.HomePhoneNumber);
            I.Fill(Pages.PersonalDetailsContactDetailsPage.MobilePhoneTextField, TestData.PersonalDetailsContactDetailsPage.MobilePhone);
            I.ClickDropDownList(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsContactDetailsPage.PreferredContactTimeDropDownList, TestData.PersonalDetailsContactDetailsPage.PreferredContactTime);
            I.Click(Pages.PersonalDetailsContactDetailsPage.NextButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.AreYouCurrentlyOrHaveYouEverBeenAnInRentCustomer.InRentCustomerRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.DoYouHaveYourAccountNumberOrInRentCardNumber.YesRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInrentAccountPage.Type.AccountNumberRadioButton);
            I.Fill(Pages.PersonalDetailsInrentAccountPage.NumberTextField, TestData.PersonalDetailsInrentAccountPage.Number);
            I.Click(Pages.PersonalDetailsInrentAccountPage.NextButton);
            I.WaitUntilReady();
            if (I.SeeExist(Pages.PersonalDetailsInrentAccountPage.ConfirmationToProceedPopUp))
            {
                I.Click(Pages.PersonalDetailsInrentAccountPage.IWillCompleteThisApplicationButton);
            }
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.GenderDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.GenderDropDownList, I_GetGenderType((string)TestData.PersonalDetailsInformationPage.Gender));
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.DateDropDownList, (string)TestData.PersonalDetailsInformationPage.Date);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.MonthDropDownList, I_GetMonthIndex((string)TestData.PersonalDetailsInformationPage.Month));
            I.Fill(Pages.PersonalDetailsInformationPage.DateOfBirthYearTextField, TestData.PersonalDetailsInformationPage.Year);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.IdentificationTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdentificationTypeDropDownList, I_GetIdentificationType((string)TestData.PersonalDetailsInformationPage.ItentificationType));
            I.Fill(Pages.PersonalDetailsInformationPage.IdentifcationNumber, TestData.PersonalDetailsInformationPage.IdentificationNumber);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.IdentificationExpiryDayDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdentificationExpiryDayDropDownList, TestData.PersonalDetailsInformationPage.ItentificationExpiryDate);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.IdentificationExpiryMonthDropDownList);
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdentificationExpiryMonthDropDownList, I_GetMonthIndex((string)TestData.PersonalDetailsInformationPage.ItentificationExpiryMonth));
            I.Fill(Pages.PersonalDetailsInformationPage.IdentificationExpiryYear, TestData.PersonalDetailsInformationPage.ItentificationExpiryYear);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.IdShowWhereYouAreCurrentlyLivingDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdShowWhereYouAreCurrentlyLivingDropDownList, I_GetIdShowCurrentlyLiving((string)TestData.PersonalDetailsInformationPage.DoesYourIdShowWhereYouAreCurrentlyLiving.Yes));
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.MaritalStatusDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.MaritalStatusDropDownList, I_GetMaritalStatus((string)TestData.PersonalDetailsInformationPage.MartialStatus.Single));
            I.ClickRadioButton(Pages.PersonalDetailsInformationPage.HaveYouEverChangedYourNameVisaMarriageDeedPoolOrViaAnyOtherMeans.NoRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInformationPage.AreYouAnAustralianCitizenOrAPermanentAustralianResident.YesRadioButton);
            I.Click(Pages.PersonalDetailsInformationPage.NextButton);
            I.Wait(8);
            I.AmOn(Pages.ResidentialDetailsStatusPage.Url);
        }
    }
}
