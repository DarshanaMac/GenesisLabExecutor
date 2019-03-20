using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ApplyOnline
{
    /**
   *
   * This class covers the user actions of the Residential Details Status section of Apply Online feature
   * of Radio Rentals. 
   * 
   * @author Kanchana Liyanagamage
   * 
   */
    partial class ResidentialDetailsPageTests : TestBase
    {

        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.ApplyOnlne)]
        [Category(Categories.Test)]
        public void ResidentialDetails_NavigateFromYourAddressPageToYouAreNowAtHalfWayPoint() {
            I_GotoResidentialDetailsStatus();
            I.ClickDropDownList(Pages.ResidentialDetailsStatusPage.ResidentialStatusDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsStatusPage.ResidentialStatusDropDownList, I_GetResidentialStatus((string)TestData.ResidentialDetailsStatusPage.ResidentialStatus.Renting));
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordOrAgentsNameTextField, TestData.ResidentialDetailsStatusPage.LandlordAgentsName);
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordPhoneTextField, TestData.ResidentialDetailsStatusPage.LandlordAgentsPhone);
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordAmountTextField, TestData.ResidentialDetailsStatusPage.LandlordAmount);
            I.ClickDropDownList(Pages.ResidentialDetailsStatusPage.LandlordFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsStatusPage.LandlordFrequencyDropDownList, I_GetLandlordFrequency((string)TestData.ResidentialDetailsStatusPage.LandlordFrequency.PerWeek));
            I.Click(Pages.ResidentialDetailsStatusPage.NextButton);
            I.AmOn(Pages.ResidentialDetailsYourAddressPage.Url);
            I.WaitUntilReady();
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
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsYourAddressPage.StateDropDownList, Actions.I_GetState((string)TestData.ResidentialDetailsYourAddressPage.State));
            I.WaitUntilReady();
            I.Fill(Pages.ResidentialDetailsYourAddressPage.PostCodeTextField, TestData.ResidentialDetailsYourAddressPage.PostCode);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.YearsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Years);
            I.Wait(2);
            I.ClickKeyBoardEvent(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.YearsTextField, "TAB");
            I.Wait(3);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.MonthsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Months);
            I.Click(Pages.ResidentialDetailsYourAddressPage.NextButton);
            I.WaitUntilReady();
            //if (I.SeeTextExist(Pages.ResidentialDetailsYourAddressPage.YouEnteredLabel, TestData.ResidentialDetailsYourAddressPage.YouEntered))
            //{
            //    I.See(Pages.ResidentialDetailsYourAddressPage.YouEnteredLabel);
            //    I.Click(Pages.ResidentialDetailsYourAddressPage.NextButton);
            //}
            I.AmOn(Pages.Part1CallMePage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void ResidentialDetails_NavigateToYourAddressPage()
        {
            I_GotoResidentialDetailsStatus();
            I.ClickDropDownList(Pages.ResidentialDetailsStatusPage.ResidentialStatusDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsStatusPage.ResidentialStatusDropDownList, I_GetResidentialStatus((string)TestData.ResidentialDetailsStatusPage.ResidentialStatus.Renting));
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordOrAgentsNameTextField, TestData.ResidentialDetailsStatusPage.LandlordAgentsName);
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordPhoneTextField, TestData.ResidentialDetailsStatusPage.LandlordAgentsPhone);
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordAmountTextField, TestData.ResidentialDetailsStatusPage.LandlordAmount);
            I.ClickDropDownList(Pages.ResidentialDetailsStatusPage.LandlordFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsStatusPage.LandlordFrequencyDropDownList, I_GetLandlordFrequency((string)TestData.ResidentialDetailsStatusPage.LandlordFrequency.PerWeek));
            I.Click(Pages.ResidentialDetailsStatusPage.NextButton);
            I.AmOn(Pages.ResidentialDetailsYourAddressPage.Url);
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void ResidentialDetails_NavigateToCurrentAddressVerificationPage()
        {
            I_GotoResidentialDetailsStatus();
            I.ClickDropDownList(Pages.ResidentialDetailsStatusPage.ResidentialStatusDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsStatusPage.ResidentialStatusDropDownList, I_GetResidentialStatus((string)TestData.ResidentialDetailsStatusPage.ResidentialStatus.Renting));
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordOrAgentsNameTextField, TestData.ResidentialDetailsStatusPage.LandlordAgentsName);
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordPhoneTextField, TestData.ResidentialDetailsStatusPage.LandlordAgentsPhone);
            I.Fill(Pages.ResidentialDetailsStatusPage.LandlordAmountTextField, TestData.ResidentialDetailsStatusPage.LandlordAmount);
            I.ClickDropDownList(Pages.ResidentialDetailsStatusPage.LandlordFrequencyDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsStatusPage.LandlordFrequencyDropDownList, I_GetLandlordFrequency((string)TestData.ResidentialDetailsStatusPage.LandlordFrequency.PerWeek));
            I.Click(Pages.ResidentialDetailsStatusPage.NextButton);
            I.WaitUntilReady();
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
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsYourAddressPage.StateDropDownList, Actions.I_GetState((string)TestData.ResidentialDetailsYourAddressPage.State));
            I.WaitUntilReady();
            I.Fill(Pages.ResidentialDetailsYourAddressPage.PostCodeTextField, TestData.ResidentialDetailsYourAddressPage.PostCode);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.YearsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Years);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.MonthsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Months);
            I.Click(Pages.ResidentialDetailsYourAddressPage.NextButton);
            I.WaitUntilReady();
            if (I.SeeTextExist(Pages.ResidentialDetailsYourAddressPage.YouEnteredLabel, TestData.ResidentialDetailsYourAddressPage.YouEntered))
            {
                I.See(Pages.ResidentialDetailsYourAddressPage.YouEnteredLabel);
                I.Click(Pages.ResidentialDetailsYourAddressPage.NextButton);
            }
        }

        [Test]
        [Category(Categories.ApplyOnlne)]
        public void ResidentialDetails_YouAreNowAtHalfWayPoint()
        {
            I_GotoResidentialDetailsStatus();
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
            I.WaitUntilReady();
            I.SelectValueFromDropDownListRR(Pages.ResidentialDetailsYourAddressPage.StateDropDownList, Actions.I_GetState((string)TestData.ResidentialDetailsYourAddressPage.State));
            I.WaitUntilReady();
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.YearsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Years);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.MonthsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Months);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.PostCodeTextField, TestData.ResidentialDetailsYourAddressPage.PostCode);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.YearsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Years);
            I.Fill(Pages.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.MonthsTextField, TestData.ResidentialDetailsYourAddressPage.LengthOfTimeAtAddress.Months);
            I.Click(Pages.ResidentialDetailsYourAddressPage.NextButton);
            I.WaitUntilReady();
            if (I.SeeTextExist(Pages.ResidentialDetailsYourAddressPage.YouEnteredLabel, TestData.ResidentialDetailsYourAddressPage.YouEntered))
            {
                I.Click(Pages.ResidentialDetailsYourAddressPage.NextButton);
            }
            I.AmOn(Pages.Part1CallMePage.Url);
        }
    }
}