using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ApplyOnline
{
    /**
    *
    * This class covers the user actions of the Referee Details Status section of Apply Online feature
    * of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class RefereeDetailsPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.ApplyOnlne)]
        [Category(Categories.Test)]
        public void RefereeDetails_NavigateFromRefereeDetailsPageToSubmitApplyOnlineApplication()
        {
            I_GotoHalfWayPointOfApplyOnline();
            I_GotoYouAreAlmostFinishedPointOfApplyOnline();
            I.Click(Pages.Part2CallMePage.ContinueNowButton);
            I.WaitUntilReady();
            I.AmOn(Pages.RefereeDetailsPage.Url);
            I.WaitUntilReady();
            I.ClickRadioButton(Pages.RefereeDetailsPage.FirstReference.DoYouHaveAnyOfTheirDetailsNow.YesRadioButton);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.FirstNameTextField, TestData.RefereeDetailsPage.FirstReference.FirstName);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.SurnameTextField, TestData.RefereeDetailsPage.FirstReference.Surname);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.TheirRelationshipToYouTextField, TestData.RefereeDetailsPage.FirstReference.Relationship);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.PhoneCodeTextField, TestData.RefereeDetailsPage.FirstReference.PhoneCode);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.PhoneNumberTextField, TestData.RefereeDetailsPage.FirstReference.PhoneNumber);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.MobileNumberTextField, TestData.RefereeDetailsPage.FirstReference.MobileNumber);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.UnitNoTextField, TestData.RefereeDetailsPage.FirstReference.UnitNo);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.StreetNoTextField, TestData.RefereeDetailsPage.FirstReference.StreetNo);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.StreetNameTextField, TestData.RefereeDetailsPage.FirstReference.StreetName);
            I.ClickDropDownList(Pages.RefereeDetailsPage.FirstReference.StreetTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RefereeDetailsPage.FirstReference.StreetTypeDropDownList, Actions.I_GetStreetType((string)TestData.RefereeDetailsPage.FirstReference.StreetType));
            I.Fill(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, TestData.RefereeDetailsPage.FirstReference.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, "TAB");
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.RefereeDetailsPage.FirstReference.StateDropDownList);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.PostCodeTextField, TestData.RefereeDetailsPage.FirstReference.PostCode);
            I.SelectValueFromDropDownListRR(Pages.RefereeDetailsPage.FirstReference.StateDropDownList, Actions.I_GetState((string)TestData.RefereeDetailsPage.FirstReference.State));
            I.ClickRadioButton(Pages.RefereeDetailsPage.SecondReference.DoYouHaveAnyOfTheirDetailsNow.NoRadioButton);
            I.ClickRadioButton(Pages.RefereeDetailsPage.ThirdReference.DoYouHaveAnyOfTheirDetailsNow.NoRadioButton);
            I.Click(Pages.RefereeDetailsPage.NextButton);
            I.WaitUntilReady();
            I.Click(Pages.ApplyOnlineSubmitPage.AcknowledgeCheckBox);
            I.WaitUntilReady();
            I.Click(Pages.ApplyOnlineSubmitPage.SubmitButton);
            I.Wait(90);
            I.AmOn(Pages.ApplyOnlineThankYouPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void RefereeDetails_NavigateToRefereeDetailsPage()
        {
            I_GotoHalfWayPointOfApplyOnline();
            I_GotoYouAreAlmostFinishedPointOfApplyOnline();
            I.Click(Pages.Part2CallMePage.ContinueNowButton);
            I.WaitUntilReady();
            I.AmOn(Pages.RefereeDetailsPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void RefereeDetails_NavigateToSubmitOnlineApplicationPage()
        {
            I_GotoHalfWayPointOfApplyOnline();
            I_GotoYouAreAlmostFinishedPointOfApplyOnline();
            I.Click(Pages.Part2CallMePage.ContinueNowButton);
            I.WaitUntilReady();
            I.ClickRadioButton(Pages.RefereeDetailsPage.FirstReference.DoYouHaveAnyOfTheirDetailsNow.YesRadioButton);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.FirstNameTextField, TestData.RefereeDetailsPage.FirstReference.FirstName);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.SurnameTextField, TestData.RefereeDetailsPage.FirstReference.Surname);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.TheirRelationshipToYouTextField, TestData.RefereeDetailsPage.FirstReference.Relationship);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.PhoneCodeTextField, TestData.RefereeDetailsPage.FirstReference.PhoneCode);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.PhoneNumberTextField, TestData.RefereeDetailsPage.FirstReference.PhoneNumber);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.MobileNumberTextField, TestData.RefereeDetailsPage.FirstReference.MobileNumber);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.UnitNoTextField, TestData.RefereeDetailsPage.FirstReference.UnitNo);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.StreetNoTextField, TestData.RefereeDetailsPage.FirstReference.StreetNo);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.StreetNameTextField, TestData.RefereeDetailsPage.FirstReference.StreetName);
            I.ClickDropDownList(Pages.RefereeDetailsPage.FirstReference.StreetTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RefereeDetailsPage.FirstReference.StreetTypeDropDownList, Actions.I_GetStreetType((string)TestData.RefereeDetailsPage.FirstReference.StreetType));
            I.Fill(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, TestData.RefereeDetailsPage.FirstReference.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, "TAB");
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.RefereeDetailsPage.FirstReference.StateDropDownList);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, TestData.RefereeDetailsPage.FirstReference.Suburb);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.PostCodeTextField, TestData.RefereeDetailsPage.FirstReference.PostCode);
            I.ClickDropDownList(Pages.RefereeDetailsPage.FirstReference.StateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RefereeDetailsPage.FirstReference.StateDropDownList, Actions.I_GetState((string)TestData.RefereeDetailsPage.FirstReference.State));
            I.ClickRadioButton(Pages.RefereeDetailsPage.SecondReference.DoYouHaveAnyOfTheirDetailsNow.NoRadioButton);
            I.ClickRadioButton(Pages.RefereeDetailsPage.ThirdReference.DoYouHaveAnyOfTheirDetailsNow.NoRadioButton);
            I.Click(Pages.RefereeDetailsPage.NextButton);
            I.WaitUntilReady();
            I.AmOn(Pages.ApplyOnlineSubmitPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void RefereeDetails_SubmitApplyOnlineApplication()
        {
            I_GotoHalfWayPointOfApplyOnline();
            I_GotoYouAreAlmostFinishedPointOfApplyOnline();
            I.Click(Pages.Part2CallMePage.ContinueNowButton);
            I.WaitUntilReady();
            I.ClickRadioButton(Pages.RefereeDetailsPage.FirstReference.DoYouHaveAnyOfTheirDetailsNow.YesRadioButton);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.FirstNameTextField, TestData.RefereeDetailsPage.FirstReference.FirstName);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.SurnameTextField, TestData.RefereeDetailsPage.FirstReference.Surname);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.TheirRelationshipToYouTextField, TestData.RefereeDetailsPage.FirstReference.Relationship);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.PhoneCodeTextField, TestData.RefereeDetailsPage.FirstReference.PhoneCode);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.PhoneNumberTextField, TestData.RefereeDetailsPage.FirstReference.PhoneNumber);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.MobileNumberTextField, TestData.RefereeDetailsPage.FirstReference.MobileNumber);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.UnitNoTextField, TestData.RefereeDetailsPage.FirstReference.UnitNo);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.StreetNoTextField, TestData.RefereeDetailsPage.FirstReference.StreetNo);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.StreetNameTextField, TestData.RefereeDetailsPage.FirstReference.StreetName);
            I.ClickDropDownList(Pages.RefereeDetailsPage.FirstReference.StreetTypeDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RefereeDetailsPage.FirstReference.StreetTypeDropDownList, Actions.I_GetStreetType((string)TestData.RefereeDetailsPage.FirstReference.StreetType));
            I.Fill(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, TestData.RefereeDetailsPage.FirstReference.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, "TAB");
            I.WaitUntilReady();
            I.ClickDropDownList(Pages.RefereeDetailsPage.FirstReference.StateDropDownList);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.SuburbTextField, TestData.RefereeDetailsPage.FirstReference.Suburb);
            I.Fill(Pages.RefereeDetailsPage.FirstReference.PostCodeTextField, TestData.RefereeDetailsPage.FirstReference.PostCode);
            I.ClickDropDownList(Pages.RefereeDetailsPage.FirstReference.StateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RefereeDetailsPage.FirstReference.StateDropDownList, Actions.I_GetState((string)TestData.RefereeDetailsPage.FirstReference.State));
            I.ClickRadioButton(Pages.RefereeDetailsPage.SecondReference.DoYouHaveAnyOfTheirDetailsNow.NoRadioButton);
            I.ClickRadioButton(Pages.RefereeDetailsPage.ThirdReference.DoYouHaveAnyOfTheirDetailsNow.NoRadioButton);
            I.Click(Pages.RefereeDetailsPage.NextButton);
            I.WaitUntilReady();
            I.Click(Pages.ApplyOnlineSubmitPage.AcknowledgeCheckBox);
            I.Click(Pages.ApplyOnlineSubmitPage.SubmitButton);
            I.WaitUntilReady();
            I.WaitUntilReady();
            I.AmOn(Pages.ApplyOnlineThankYouPage.Url);
        }
    }
}