using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ApplyOnline
{
    partial class IncomeExpenseDetailsPageTests : TestBase
    {
        /**
        *
        * This class covers the user actions of the Income Expense Details Section of Apply Online feature
        * of Radio Rentals. 
        * 
        * @author Kanchana Liyanagamage
        * 
        */

        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.ApplyOnlne)]
        [Category(Categories.Test)]
        public void IncomeExpenseDetails_NavigateFromOccupationPageToNavigateToYouAreAlmostFinishedPoint() {
            I_GotoHalfWayPointOfApplyOnline();
            I.Click(Pages.Part1CallMePage.ContinueNowButton);
            I.AmOn(Pages.OccupationPage.Url);
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.OccupationPage.YourCurrentOccupationDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.YourCurrentOccupationDropDownList, I_GetYourCurrentOccupationType((string)TestData.OccupationPage.YourCurrentOccupation));
            I.ClickDropDownList(Pages.OccupationPage.EmployementTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.EmployementTypeDropDownList, I_GetEmploymentType((string)TestData.OccupationPage.EmployementType));
            I.Fill(Pages.OccupationPage.JobTitleTextField, TestData.OccupationPage.YourJobTitle);
            I.Fill(Pages.OccupationPage.WorkContactPhoneAreaCodeTextField, TestData.OccupationPage.WorkContactPhoneCode);
            I.Fill(Pages.OccupationPage.WorkContactPhoneNumberTextField, TestData.OccupationPage.WorkContactPhoneNumber);
            I.Fill(Pages.OccupationPage.EmployersBusinessNameTextField, TestData.OccupationPage.EmployersBusinessName);
            I.Fill(Pages.OccupationPage.UnitNoTextField, TestData.OccupationPage.UnitNo);
            I.Fill(Pages.OccupationPage.StreetNoTextField, TestData.OccupationPage.StreetNo);
            I.Fill(Pages.OccupationPage.StreetNameTextField, TestData.OccupationPage.StreetName);
            I.ClickDropDownList(Pages.OccupationPage.StreetTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StreetTypeDropDownList, Actions.I_GetStreetType((string)TestData.OccupationPage.StreetType));
            I.Fill(Pages.OccupationPage.SuburbTextField, TestData.OccupationPage.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "TAB");
            I.ClickDropDownList(Pages.OccupationPage.StateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StateDropDownList, Actions.I_GetState((string)TestData.OccupationPage.State));
            I.Fill(Pages.OccupationPage.PostCodeTextField, TestData.OccupationPage.PostCode);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.YearsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Years);
            I.Wait(2);
            I.ClickKeyBoardEvent(Pages.OccupationPage.TimeAtCurrentEmployer.YearsTextField, "TAB");
            I.Wait(3);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.MonthsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Months);
            
            I.Click(Pages.OccupationPage.NextButton);
            I.WaitUntilReady();
            I.AmOn(Pages.IncomeInformationPage.Url);
            I.WaitUntilReady();
            I.Fill(Pages.IncomeInformationPage.WagesTextField, TestData.IncomeInformationPage.Wages);
            I.ClickDropDownList(Pages.IncomeInformationPage.WagesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.WagesFrequencyDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Fill(Pages.IncomeInformationPage.GovernmentPaymentsTextField, TestData.IncomeInformationPage.GovernmentPayments);
            I.ClickDropDownList(Pages.IncomeInformationPage.GovernmentPaymentDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.GovernmentPaymentDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Fill(Pages.IncomeInformationPage.YourIncomeFromOtherSourcesTextField, TestData.IncomeInformationPage.Wages);
            I.ClickDropDownList(Pages.IncomeInformationPage.YourIncomeFromOtherSourceDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.YourIncomeFromOtherSourceDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Click(Pages.IncomeInformationPage.NextButton);
            I.WaitUntilReady();
            I.AmOn(Pages.LivingExpensesPage.Url);
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.LivingExpensesPage.DependentChildrenDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.DependentChildrenDropDownList, I_GetDependentChildrenCount((string)TestData.LivingExpensesPage.DependentChildren));
            I.ClickDropDownList(Pages.LivingExpensesPage.DoYouRunAVehicleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.DoYouRunAVehicleDropDownList, I_GetRunVehicleType((string)TestData.LivingExpensesPage.DoYouRunAVehicle));
            I.Fill(Pages.LivingExpensesPage.WaterRatesTextField, TestData.LivingExpensesPage.WaterRates);
            I.ClickDropDownList(Pages.LivingExpensesPage.WaterFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.WaterFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.UtilitiesTextField, TestData.LivingExpensesPage.Utilities);
            I.ClickDropDownList(Pages.LivingExpensesPage.UtilitiesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.UtilitiesFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.PhoneAndInternetTextField, TestData.LivingExpensesPage.PhoneAndInternet);
            I.ClickDropDownList(Pages.LivingExpensesPage.PhoneAndInternetDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.PhoneAndInternetDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.GroceriesTextField, TestData.LivingExpensesPage.Groceries);
            I.ClickDropDownList(Pages.LivingExpensesPage.GroceriesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.GroceriesFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.MedicalAndPharmaceuticalTextField, TestData.LivingExpensesPage.MedicalAndPharmaceutical);
            I.ClickDropDownList(Pages.LivingExpensesPage.MedicalAndPharmaceuticalFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.MedicalAndPharmaceuticalFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.OtherExpensesTexField, TestData.LivingExpensesPage.OtherExpenses);
            I.ClickDropDownList(Pages.LivingExpensesPage.OtherExpensesDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.OtherExpensesDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Click(Pages.LivingExpensesPage.NextButton);
            I.WaitUntilReady();
            I.AmOn(Pages.OtherExpensesPage.Url);
            I.WaitUntilReady();
            I.ClickRadioButton(Pages.OtherExpensesPage.DoYouHaveAnyCreditCardsOrStoreCards.NoRadioButton);
            I.ClickRadioButton(Pages.OtherExpensesPage.DoYouHaveAnyLoans.NoRadioButton);
            I.ClickRadioButton(Pages.OtherExpensesPage.DoYouForeseeYourFinancialSituation.NoRadioButton);
            I.Click(Pages.OtherExpensesPage.NextButton);
            I.AmOn(Pages.Part2CallMePage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void IncomeExpenseDetails_NavigateToOccupationPage()
        {
            I_GotoHalfWayPointOfApplyOnline();
            I.Click(Pages.Part1CallMePage.ContinueNowButton);
            I.AmOn(Pages.OccupationPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void IncomeExpenseDetails_NavigateToIncomeInformationPage()
        {
            I_GotoHalfWayPointOfApplyOnline();
            I.Click(Pages.Part1CallMePage.ContinueNowButton);
            I.ClickDropDownList(Pages.OccupationPage.YourCurrentOccupationDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.YourCurrentOccupationDropDownList, I_GetYourCurrentOccupationType((string)TestData.OccupationPage.YourCurrentOccupation));
            I.ClickDropDownList(Pages.OccupationPage.EmployementTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.EmployementTypeDropDownList, I_GetEmploymentType((string)TestData.OccupationPage.EmployementType));
            I.Fill(Pages.OccupationPage.JobTitleTextField, TestData.OccupationPage.YourJobTitle);
            I.Fill(Pages.OccupationPage.WorkContactPhoneAreaCodeTextField, TestData.OccupationPage.WorkContactPhoneCode);
            I.Fill(Pages.OccupationPage.WorkContactPhoneNumberTextField, TestData.OccupationPage.WorkContactPhoneNumber);
            I.Fill(Pages.OccupationPage.EmployersBusinessNameTextField, TestData.OccupationPage.EmployersBusinessName);
            I.Fill(Pages.OccupationPage.UnitNoTextField, TestData.OccupationPage.UnitNo);
            I.Fill(Pages.OccupationPage.StreetNoTextField, TestData.OccupationPage.StreetNo);
            I.Fill(Pages.OccupationPage.StreetNameTextField, TestData.OccupationPage.StreetName);
            I.ClickDropDownList(Pages.OccupationPage.StreetTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StreetTypeDropDownList, Actions.I_GetStreetType((string)TestData.OccupationPage.StreetType));
            I.Fill(Pages.OccupationPage.SuburbTextField, TestData.OccupationPage.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "TAB");
            I.ClickDropDownList(Pages.OccupationPage.StateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StateDropDownList, Actions.I_GetState((string)TestData.OccupationPage.State));
            I.Fill(Pages.OccupationPage.PostCodeTextField, TestData.OccupationPage.PostCode);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.YearsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Years);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.MonthsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Months);
            I.Click(Pages.OccupationPage.NextButton);
            I.WaitUntilReady();
            I.AmOn(Pages.IncomeInformationPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void IncomeExpenseDetails_NavigateToLivingExpensesPage()
        {
            I_GotoHalfWayPointOfApplyOnline();
            I.Click(Pages.Part1CallMePage.ContinueNowButton);
            I.ClickDropDownList(Pages.OccupationPage.YourCurrentOccupationDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.YourCurrentOccupationDropDownList, I_GetYourCurrentOccupationType((string)TestData.OccupationPage.YourCurrentOccupation));
            I.ClickDropDownList(Pages.OccupationPage.EmployementTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.EmployementTypeDropDownList, I_GetEmploymentType((string)TestData.OccupationPage.EmployementType));
            I.Fill(Pages.OccupationPage.JobTitleTextField, TestData.OccupationPage.YourJobTitle);
            I.Fill(Pages.OccupationPage.WorkContactPhoneAreaCodeTextField, TestData.OccupationPage.WorkContactPhoneCode);
            I.Fill(Pages.OccupationPage.WorkContactPhoneNumberTextField, TestData.OccupationPage.WorkContactPhoneNumber);
            I.Fill(Pages.OccupationPage.EmployersBusinessNameTextField, TestData.OccupationPage.EmployersBusinessName);
            I.Fill(Pages.OccupationPage.UnitNoTextField, TestData.OccupationPage.UnitNo);
            I.Fill(Pages.OccupationPage.StreetNoTextField, TestData.OccupationPage.StreetNo);
            I.Fill(Pages.OccupationPage.StreetNameTextField, TestData.OccupationPage.StreetName);
            I.ClickDropDownList(Pages.OccupationPage.StreetTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StreetTypeDropDownList, Actions.I_GetStreetType((string)TestData.OccupationPage.StreetType));
            I.Fill(Pages.OccupationPage.SuburbTextField, TestData.OccupationPage.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "TAB");
            I.ClickDropDownList(Pages.OccupationPage.StateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StateDropDownList, Actions.I_GetState((string)TestData.OccupationPage.State));
            I.Fill(Pages.OccupationPage.PostCodeTextField, TestData.OccupationPage.PostCode);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.YearsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Years);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.MonthsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Months);
            I.Click(Pages.OccupationPage.NextButton);
            I.WaitUntilReady();
            I.Fill(Pages.IncomeInformationPage.WagesTextField, TestData.IncomeInformationPage.Wages);
            I.ClickDropDownList(Pages.IncomeInformationPage.WagesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.WagesFrequencyDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Fill(Pages.IncomeInformationPage.GovernmentPaymentsTextField, TestData.IncomeInformationPage.GovernmentPayments);
            I.ClickDropDownList(Pages.IncomeInformationPage.GovernmentPaymentDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.GovernmentPaymentDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Fill(Pages.IncomeInformationPage.YourIncomeFromOtherSourcesTextField, TestData.IncomeInformationPage.Wages);
            I.ClickDropDownList(Pages.IncomeInformationPage.YourIncomeFromOtherSourceDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.YourIncomeFromOtherSourceDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Click(Pages.IncomeInformationPage.NextButton);
            I.WaitUntilReady();
            I.AmOn(Pages.LivingExpensesPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void IncomeExpenseDetails_NavigateToOtherExpensesPage()
        {
            I_GotoHalfWayPointOfApplyOnline();
            I.Click(Pages.Part1CallMePage.ContinueNowButton);
            I.ClickDropDownList(Pages.OccupationPage.YourCurrentOccupationDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.YourCurrentOccupationDropDownList, I_GetYourCurrentOccupationType((string)TestData.OccupationPage.YourCurrentOccupation));
            I.ClickDropDownList(Pages.OccupationPage.EmployementTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.EmployementTypeDropDownList, I_GetEmploymentType((string)TestData.OccupationPage.EmployementType));
            I.Fill(Pages.OccupationPage.JobTitleTextField, TestData.OccupationPage.YourJobTitle);
            I.Fill(Pages.OccupationPage.WorkContactPhoneAreaCodeTextField, TestData.OccupationPage.WorkContactPhoneCode);
            I.Fill(Pages.OccupationPage.WorkContactPhoneNumberTextField, TestData.OccupationPage.WorkContactPhoneNumber);
            I.Fill(Pages.OccupationPage.EmployersBusinessNameTextField, TestData.OccupationPage.EmployersBusinessName);
            I.Fill(Pages.OccupationPage.UnitNoTextField, TestData.OccupationPage.UnitNo);
            I.Fill(Pages.OccupationPage.StreetNoTextField, TestData.OccupationPage.StreetNo);
            I.Fill(Pages.OccupationPage.StreetNameTextField, TestData.OccupationPage.StreetName);
            I.ClickDropDownList(Pages.OccupationPage.StreetTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StreetTypeDropDownList, Actions.I_GetStreetType((string)TestData.OccupationPage.StreetType));
            I.Fill(Pages.OccupationPage.SuburbTextField, TestData.OccupationPage.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "TAB");
            I.ClickDropDownList(Pages.OccupationPage.StateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StateDropDownList, Actions.I_GetState((string)TestData.OccupationPage.State));
            I.Fill(Pages.OccupationPage.PostCodeTextField, TestData.OccupationPage.PostCode);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.YearsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Years);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.MonthsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Months);
            I.Click(Pages.OccupationPage.NextButton);
            I.WaitUntilReady();
            I.Fill(Pages.IncomeInformationPage.WagesTextField, TestData.IncomeInformationPage.Wages);
            I.ClickDropDownList(Pages.IncomeInformationPage.WagesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.WagesFrequencyDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Fill(Pages.IncomeInformationPage.GovernmentPaymentsTextField, TestData.IncomeInformationPage.GovernmentPayments);
            I.ClickDropDownList(Pages.IncomeInformationPage.GovernmentPaymentDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.GovernmentPaymentDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Fill(Pages.IncomeInformationPage.YourIncomeFromOtherSourcesTextField, TestData.IncomeInformationPage.Wages);
            I.ClickDropDownList(Pages.IncomeInformationPage.YourIncomeFromOtherSourceDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.YourIncomeFromOtherSourceDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Click(Pages.IncomeInformationPage.NextButton);
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.LivingExpensesPage.DependentChildrenDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.DependentChildrenDropDownList, I_GetDependentChildrenCount((string)TestData.LivingExpensesPage.DependentChildren));
            I.ClickDropDownList(Pages.LivingExpensesPage.DoYouRunAVehicleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.DoYouRunAVehicleDropDownList, I_GetRunVehicleType((string)TestData.LivingExpensesPage.DoYouRunAVehicle));
            I.Fill(Pages.LivingExpensesPage.WaterRatesTextField, TestData.LivingExpensesPage.WaterRates);
            I.ClickDropDownList(Pages.LivingExpensesPage.WaterFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.WaterFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.UtilitiesTextField, TestData.LivingExpensesPage.Utilities);
            I.ClickDropDownList(Pages.LivingExpensesPage.UtilitiesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.UtilitiesFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.PhoneAndInternetTextField, TestData.LivingExpensesPage.PhoneAndInternet);
            I.ClickDropDownList(Pages.LivingExpensesPage.PhoneAndInternetDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.PhoneAndInternetDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.GroceriesTextField, TestData.LivingExpensesPage.Groceries);
            I.ClickDropDownList(Pages.LivingExpensesPage.GroceriesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.GroceriesFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.MedicalAndPharmaceuticalTextField, TestData.LivingExpensesPage.MedicalAndPharmaceutical);
            I.ClickDropDownList(Pages.LivingExpensesPage.MedicalAndPharmaceuticalFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.MedicalAndPharmaceuticalFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.OtherExpensesTexField, TestData.LivingExpensesPage.OtherExpenses);
            I.ClickDropDownList(Pages.LivingExpensesPage.OtherExpensesDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.OtherExpensesDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Click(Pages.LivingExpensesPage.NextButton);
            I.WaitUntilReady();
            I.AmOn(Pages.OtherExpensesPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void IncomeExpenseDetails_NavigateToYouAreAlmostFinishedPoint()
        {
            I_GotoHalfWayPointOfApplyOnline();
            I.Click(Pages.Part1CallMePage.ContinueNowButton);
            I.ClickDropDownList(Pages.OccupationPage.YourCurrentOccupationDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.YourCurrentOccupationDropDownList, I_GetYourCurrentOccupationType((string)TestData.OccupationPage.YourCurrentOccupation));
            I.ClickDropDownList(Pages.OccupationPage.EmployementTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.EmployementTypeDropDownList, I_GetEmploymentType((string)TestData.OccupationPage.EmployementType));
            I.Fill(Pages.OccupationPage.JobTitleTextField, TestData.OccupationPage.YourJobTitle);
            I.Fill(Pages.OccupationPage.WorkContactPhoneAreaCodeTextField, TestData.OccupationPage.WorkContactPhoneCode);
            I.Fill(Pages.OccupationPage.WorkContactPhoneNumberTextField, TestData.OccupationPage.WorkContactPhoneNumber);
            I.Fill(Pages.OccupationPage.EmployersBusinessNameTextField, TestData.OccupationPage.EmployersBusinessName);
            I.Fill(Pages.OccupationPage.UnitNoTextField, TestData.OccupationPage.UnitNo);
            I.Fill(Pages.OccupationPage.StreetNoTextField, TestData.OccupationPage.StreetNo);
            I.Fill(Pages.OccupationPage.StreetNameTextField, TestData.OccupationPage.StreetName);
            I.ClickDropDownList(Pages.OccupationPage.StreetTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StreetTypeDropDownList, Actions.I_GetStreetType((string)TestData.OccupationPage.StreetType));
            I.Fill(Pages.OccupationPage.SuburbTextField, TestData.OccupationPage.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.OccupationPage.SuburbTextField, "TAB");
            I.ClickDropDownList(Pages.OccupationPage.StateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.OccupationPage.StateDropDownList, Actions.I_GetState((string)TestData.OccupationPage.State));
            I.Fill(Pages.OccupationPage.PostCodeTextField, TestData.OccupationPage.PostCode);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.YearsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Years);
            I.Fill(Pages.OccupationPage.TimeAtCurrentEmployer.MonthsTextField, TestData.OccupationPage.TimeAtCurrentEmployer.Months);
            I.Click(Pages.OccupationPage.NextButton);
            I.WaitUntilReady();
            I.Fill(Pages.IncomeInformationPage.WagesTextField, TestData.IncomeInformationPage.Wages);
            I.ClickDropDownList(Pages.IncomeInformationPage.WagesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.WagesFrequencyDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Fill(Pages.IncomeInformationPage.GovernmentPaymentsTextField, TestData.IncomeInformationPage.GovernmentPayments);
            I.ClickDropDownList(Pages.IncomeInformationPage.GovernmentPaymentDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.GovernmentPaymentDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Fill(Pages.IncomeInformationPage.YourIncomeFromOtherSourcesTextField, TestData.IncomeInformationPage.Wages);
            I.ClickDropDownList(Pages.IncomeInformationPage.YourIncomeFromOtherSourceDropDownList);
            I.SelectValueFromDropDownListRR(Pages.IncomeInformationPage.YourIncomeFromOtherSourceDropDownList, I_GetFrequency((string)TestData.IncomeInformationPage.Frequency));
            I.Click(Pages.IncomeInformationPage.NextButton);
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.LivingExpensesPage.DependentChildrenDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.DependentChildrenDropDownList, I_GetDependentChildrenCount((string)TestData.LivingExpensesPage.DependentChildren));
            I.ClickDropDownList(Pages.LivingExpensesPage.DoYouRunAVehicleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.DoYouRunAVehicleDropDownList, I_GetRunVehicleType((string)TestData.LivingExpensesPage.DoYouRunAVehicle));
            I.Fill(Pages.LivingExpensesPage.WaterRatesTextField, TestData.LivingExpensesPage.WaterRates);
            I.ClickDropDownList(Pages.LivingExpensesPage.WaterFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.WaterFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.UtilitiesTextField, TestData.LivingExpensesPage.Utilities);
            I.ClickDropDownList(Pages.LivingExpensesPage.UtilitiesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.UtilitiesFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.PhoneAndInternetTextField, TestData.LivingExpensesPage.PhoneAndInternet);
            I.ClickDropDownList(Pages.LivingExpensesPage.PhoneAndInternetDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.PhoneAndInternetDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.GroceriesTextField, TestData.LivingExpensesPage.Groceries);
            I.ClickDropDownList(Pages.LivingExpensesPage.GroceriesFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.GroceriesFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.MedicalAndPharmaceuticalTextField, TestData.LivingExpensesPage.MedicalAndPharmaceutical);
            I.ClickDropDownList(Pages.LivingExpensesPage.MedicalAndPharmaceuticalFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.MedicalAndPharmaceuticalFrequencyDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Fill(Pages.LivingExpensesPage.OtherExpensesTexField, TestData.LivingExpensesPage.OtherExpenses);
            I.ClickDropDownList(Pages.LivingExpensesPage.OtherExpensesDropDownList);
            I.SelectValueFromDropDownListRR(Pages.LivingExpensesPage.OtherExpensesDropDownList, I_GetExpenseFrequency((string)TestData.LivingExpensesPage.ExpenseFrequency));
            I.Click(Pages.LivingExpensesPage.NextButton);
            I.WaitUntilReady();
            I.ClickRadioButton(Pages.OtherExpensesPage.DoYouHaveAnyCreditCardsOrStoreCards.NoRadioButton);
            I.ClickRadioButton(Pages.OtherExpensesPage.DoYouHaveAnyLoans.NoRadioButton);
            I.ClickRadioButton(Pages.OtherExpensesPage.DoYouForeseeYourFinancialSituation.NoRadioButton);
            I.Click(Pages.OtherExpensesPage.NextButton);
            I.AmOn(Pages.Part2CallMePage.Url);
        }
    }
}
