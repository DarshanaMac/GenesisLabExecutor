using S60TestExecutionPlatform.Core;
using S60TestExecutionPlatform.Utility;

namespace RadioRentals.Tests.Profile
{
    /**
   *
   * This class covers the helper methods of the Profile page of Radio Rentals. 
   * 
   * @author Kanchana Liyanagamage
   * 
   */
    partial class ProfilePageTests
    {
        public void I_LoginAsCustomer()
        {
            I.Open(Pages.LoginPage.Url);
            I.Fill(Pages.LoginPage.EmailAddressTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.LoginPage.SignInButton);
        }

        public void I_CreateNewProfile()
        {
            object emailAddress = I_GenerateUniqueMailAddressForNewProfile();
            I.Open(Pages.RegisterAccountPage.Url);
            I.ClickDropDownList(Pages.RegisterAccountPage.TitleDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.TitleDropDownList, TestData.RegisterAccountPage.Title);
            I.Fill(Pages.RegisterAccountPage.FirstNameTextField, TestData.RegisterAccountPage.FirstName);
            I.Fill(Pages.RegisterAccountPage.LastNameTextField, TestData.RegisterAccountPage.LastName);
            I.ClickDropDownList(Pages.RegisterAccountPage.DateDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.DateDropDownList, TestData.RegisterAccountPage.Date);
            I.ClickDropDownList(Pages.RegisterAccountPage.MonthDropDownList);
            I.SelectValueFromDropDownListRR(Pages.RegisterAccountPage.MonthDropDownList, Actions.I_GetMonthIndex((string)TestData.RegisterAccountPage.Month));
            I.Fill(Pages.RegisterAccountPage.BirthYearTextField, TestData.RegisterAccountPage.Year);
            I.Fill(Pages.RegisterAccountPage.EmailTextField, emailAddress);
            I.Fill(Pages.RegisterAccountPage.MobileNumberTextField, TestData.RegisterAccountPage.MobileNumber);
            I.Click(Pages.RegisterAccountPage.RegisterButton);
            I.WaitUntilReady();
        }

        private object I_GenerateUniqueMailAddressForNewProfile()
        {
            long uniqueText = Helper.GetUniqueNumericValue();
            object emailAddress = "rrp" + uniqueText + "@gmail.com";
            return emailAddress;
        }
    }
}
