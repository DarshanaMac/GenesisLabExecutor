using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ApplyOnline
{
    /**
    *
    * This class covers the helper methods which are used in IncomeExpenseDetailsPageTests.cs
    * of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class IncomeExpenseDetailsPageTests
    {
        public void I_GotoHalfWayPointOfApplyOnline()
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
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdentificationExpiryMonthDropDownList, I_GetMonthIndex((string)TestData.PersonalDetailsInformationPage.ItentificationExpiryMonth));
            I.Fill(Pages.PersonalDetailsInformationPage.IdentificationExpiryYear, TestData.PersonalDetailsInformationPage.ItentificationExpiryYear);
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.IdShowWhereYouAreCurrentlyLivingDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.IdShowWhereYouAreCurrentlyLivingDropDownList, I_GetIdShowCurrentlyLiving((string)TestData.PersonalDetailsInformationPage.DoesYourIdShowWhereYouAreCurrentlyLiving.Yes));
            I.ClickDropDownList(Pages.PersonalDetailsInformationPage.MaritalStatusDropDownList);
            I.SelectValueFromDropDownListRR(Pages.PersonalDetailsInformationPage.MaritalStatusDropDownList, I_GetMaritalStatus((string)TestData.PersonalDetailsInformationPage.MartialStatus.Single));
            I.ClickRadioButton(Pages.PersonalDetailsInformationPage.HaveYouEverChangedYourNameVisaMarriageDeedPoolOrViaAnyOtherMeans.NoRadioButton);
            I.ClickRadioButton(Pages.PersonalDetailsInformationPage.AreYouAnAustralianCitizenOrAPermanentAustralianResident.YesRadioButton);
            I.Click(Pages.PersonalDetailsInformationPage.NextButton);
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.ResidentialDetailsStatusPage.ResidentialStatusDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsStatusPage.ResidentialStatusDropDownList, I_GetResidentialStatus((string)TestData.ResidentialDetailsStatusPage.ResidentialStatus.Renting));
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordOrAgentsNameTextField, TestData.ResidentialDetailsStatusPage.LandlordAgentsName);
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordPhoneTextField, TestData.ResidentialDetailsStatusPage.LandlordAgentsPhone);
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordAmountTextField, TestData.ResidentialDetailsStatusPage.LandlordAmount);
            I.ClickDropDownList(Pages.ResidentialDetailsStatusPage.LandlordFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsStatusPage.LandlordFrequencyDropDownList, I_GetLandlordFrequency((string)TestData.ResidentialDetailsStatusPage.LandlordFrequency.PerWeek));
            I.Click(Pages.ResidentialDetailsStatusPage.NextButton);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.PropertyOrBuildingNameTextField, TestData.ResidentialDetailsYourAddressPage.PropertyOrBuildingName);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.UnitNoTextField, TestData.ResidentialDetailsYourAddressPage.UnitNo);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.HouseNoTextField, TestData.ResidentialDetailsYourAddressPage.HouseNo);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.StreetNameTextField, TestData.ResidentialDetailsYourAddressPage.StreetName);
            I.ClickDropDownList(Pages.ResidentialDetailsYourAddressPage.StreetTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsYourAddressPage.StreetTypeDropDownList, Actions.I_GetStreetType((string)TestData.ResidentialDetailsYourAddressPage.StreetType));
            I.Fill(Pages.ResidentialDetailsYourAddressPage.SuburbTextField, TestData.ResidentialDetailsYourAddressPage.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ResidentialDetailsYourAddressPage.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.ResidentialDetailsYourAddressPage.SuburbTextField, "TAB");
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.ResidentialDetailsYourAddressPage.StateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsYourAddressPage.StateDropDownList, Actions.I_GetState((string)TestData.ResidentialDetailsYourAddressPage.State));
            I.Fill(Pages.ResidentialDetailsYourAddressPage.PostCodeTextField, TestData.ResidentialDetailsYourAddressPage.PostCode);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.YearsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Years);
            I.Wait(2);
            I.ClickKeyBoardEvent(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.YearsTextField, "TAB");
            I.Wait(3);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.MonthsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Months);
            I.Click(Pages.ResidentialDetailsYourAddressPage.NextButton);
            I.WaitUntilReady();            
            I.Click(Pages.Part1CallMePage.ContinueNowButton);
        }

        public string I_GetYourCurrentOccupationType(string occupationType)
        {
            switch (occupationType)
            {
                case "Employed": return "E | Employed";
                case "Self-Employed": return "Z | Self-Employed";
                case "Receiving Government Payments": return "P | Receiving Government Payments";
                case "Other Occupation": return "O | Other Occupation";

            }
            return "0";
        }

        public string I_GetEmploymentType(string employmentType)
        {
            switch (employmentType)
            {
                case "Full Time": return "F | Full Time";
                case "Part Time": return "P | Part Time";
                case "Casual": return "C | Casual";
                case "Company Director": return "D | Company Director";

            }
            return "0";
        }

        public string I_GetFrequency(string fequency)
        {
            switch (fequency)
            {
                case "per week": return "W | per week";
                case "per fortnight": return "F | per fortnight";
                case "per month": return "M | per month";
            }
            return "0";
        }

        public string I_GetDependentChildrenCount(string childrenCount)
        {
            switch (childrenCount)
            {
                case "None": return "0";
                case "1": return "1";
                case "2": return "2";
                case "3": return "3";
                case "5": return "4";
                case "5+": return "5";
            }
            return null;
        }

        public string I_GetRunVehicleType(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Yes, It's under Finance": return "F | Yes, It's under Finance";
                case "Yes, I own it Freehold": return "O | Yes, I own it Freehold";
                case "No, I do not run a vehicle": return "N | No, I do not run a vehicle";
            }
            return null;
        }

        public string I_GetExpenseFrequency(string frequency)
        {
            switch (frequency)
            {
                case "weekly": return "W | weekly";
                case "fortnightly": return "F | fortnightly";
                case "monthly": return "M | monthly";
                case "quarterly": return "Q | quarterly";
                case "yearly": return "Y | yearly";
            }
            return null;
        }

        public string I_GetResidentialStatus(string residentialStatus)
        {
            switch (residentialStatus)
            {
                case "Renting": return "R | Renting";
                case "Fully own home - no mortgage": return "F | Fully own home - no mortgage";

            }
            return "0";
        }
        public string I_GetGenderType(string gender)
        {
            switch (gender)
            {
                case "Male": return "M | Male";
                case "Female": return "F | Female";

            }
            return "0";
        }

        public string I_GetIdentificationType(string type)
        {
            switch (type)
            {
                case "Australian Drivers License": return "DL | Australian Drivers License";
                case "Firearm License (with address)": return "FL | Firearm License (with address)";

            }
            return "0";
        }

        public string I_GetMonthIndex(string month)
        {
            switch (month)
            {
                case "January": return "1";
                case "February": return "2";
                case "March": return "3";
                case "April": return "4";
                case "May": return "5";
                case "June": return "6";
                case "July": return "7";
                case "August": return "8";
                case "September": return "9";
                case "October": return "10";
                case "November": return "11";
                case "December": return "12";
            }
            return "0";
        }
        public string I_GetMaritalStatus(string status)
        {
            switch (status)
            {
                case "Single": return "S | Single";
                case "Defacto": return "D | Defacto";
            }
            return "0";
        }

        public string I_GetIdShowCurrentlyLiving(string preferene)
        {
            switch (preferene)
            {
                case "Yes": return "True";
                case "No": return "False";
            }
            return "0";
        }

        public string I_GetLandlordFrequency(string frequency)
        {
            switch (frequency)
            {
                case "per week": return "W | per week";
                case "per fortnight": return "F | per fortnight";
            }
            return "0";
        }
    }
}
