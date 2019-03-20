using System;
using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.Profile
{
    /**
    *
    * This class covers the user actions of the Profile page of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class ProfilePageTests : TestBase
    {

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ProfilePage_NavigateToProfilePage()
        {
            I_LoginAsCustomer();
            I.Open(Pages.ProfilePage.Url);
            I.AmOn(Pages.ProfilePage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ProfilePage_ViewAnExistingProfile()
        {
            I_LoginAsCustomer();
            I.Open(Pages.ProfilePage.Url);
            I.SeeText(Pages.ProfilePage.FirstNameLabel, TestData.Customer.FirstName);
            I.SeeText(Pages.ProfilePage.LastNameLabel, TestData.Customer.LastName);
            I.SeeText(Pages.ProfilePage.EmailAddressLabel, TestData.Customer.EmailAddress);
            I.See(Pages.ProfilePage.LeftNavigation);
            I.See(Pages.ProfilePage.HideButton);
            I.See(Pages.ProfilePage.EditButton);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ProfilePage_EditAnExistingProfile()
        {
            I_CreateNewProfile();
            I.Open(Pages.ProfilePage.Url);
            I.Click(Pages.ProfilePage.EditButton);
            I.Fill(Pages.ProfilePage.FirstNameTextField, TestData.ProfilePage.EditProfile.FirstName);
            I.Fill(Pages.ProfilePage.LastNameTextField, TestData.ProfilePage.EditProfile.LastName);
            I.Fill(Pages.ProfilePage.MobileNumberTextField, TestData.ProfilePage.EditProfile.MobileNumber);
            I.Click(Pages.ProfilePage.SaveButton);
            I.WaitUntilReady();
            I.SeeText(Pages.ProfilePage.FirstNameLabel, TestData.ProfilePage.EditProfile.FirstName);
            I.SeeText(Pages.ProfilePage.LastNameLabel, TestData.ProfilePage.EditProfile.LastName);
            I.SeeText(Pages.ProfilePage.MobileNumberLabel, TestData.ProfilePage.EditProfile.MobileNumber);
        }

    }
}
