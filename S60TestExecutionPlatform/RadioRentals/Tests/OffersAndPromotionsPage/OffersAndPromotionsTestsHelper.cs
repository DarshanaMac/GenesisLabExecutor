using NUnit.Framework;
using OpenQA.Selenium;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using System;
using System.Collections.Generic;

namespace RadioRentals.Tests.OffersAndPromotionsPage
{
    partial class OffersAndPromotionsPageTests : TestBase
    {

        public void I_FillClaimForm()
        {
            I.ClickDropDownList(Pages.ClaimSubmitPage.StoreDropDownList);
            I.SelectValueFromDropDownListRR(Pages.ClaimSubmitPage.StoreDropDownList, TestData.ClaimSubmitPage.StoreValue);
            I.Fill(Pages.ClaimSubmitPage.FirstNameTextField, TestData.ClaimSubmitPage.FirstName);
            I.Fill(Pages.ClaimSubmitPage.LastNameTextField, TestData.ClaimSubmitPage.LastName);
            I.Fill(Pages.ClaimSubmitPage.StreetNameTextField, TestData.ClaimSubmitPage.StreetAddress);
            I.Fill(Pages.ClaimSubmitPage.SuburbTextField, TestData.ClaimSubmitPage.Suburb);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ClaimSubmitPage.SuburbTextField, "DOWN");
            I.ClickKeyBoardEvent(Pages.ClaimSubmitPage.SuburbTextField, "TAB");
            I.Fill(Pages.ClaimSubmitPage.PhoneNumberTextField, TestData.ClaimSubmitPage.PhoneNumber);
            I.Fill(Pages.ClaimSubmitPage.EmailTextField, TestData.ClaimSubmitPage.Email);
            I.Fill(Pages.ClaimSubmitPage.ConfirmEmailTextField, TestData.ClaimSubmitPage.ConfirmEmail);
            I.Fill(Pages.ClaimSubmitPage.RetailTextField, TestData.ClaimSubmitPage.RetailValue);
            I.Fill(Pages.ClaimSubmitPage.AccountNumberTextField, TestData.ClaimSubmitPage.AccountNumber);
            I.Fill(Pages.ClaimSubmitPage.TransactionDateTextField, TestData.ClaimSubmitPage.TransactionDate);
            I.WaitUntilReady();
            I.ClickKeyBoardEvent(Pages.ClaimSubmitPage.TransactionDateTextField, "TAB");
            I.Check(Pages.ClaimSubmitPage.AcceptTermsAndConditionsCheckBox);
            I.Check(Pages.ClaimSubmitPage.IWishToBeExcludedCheckBox);
            I.Click(Pages.ClaimSubmitPage.SubmitButton);
        }

        public object I_GetTodayDate()
        {
            //string thisDate1 = DateTime.Today.ToShortDateString()..Replace('/','-');
            string year = DateTime.Today.Year.ToString();
            string month = DateTime.Today.Month.ToString();
            string date = DateTime.Today.Day.ToString();
            object today = date + "-" + month + "-" + year;
            return today;
        }

        public void I_CheckRedeemOffer(object element)
        {
            string Element = element.ToString();

            int titlecount = I.GetElementCount(Pages.OffersAndPromotionsPage.PromotionTile);
            for (int i = 0; i <= titlecount; i++)
            {
                I.ClickOnElementList(Pages.OffersAndPromotionsPage.PromotionTile, i);
                int countElement = I.GetElementCount(Pages.OfferDetailsPage.RedeemOfferButton);

                if (countElement == 1)
                {
                    I.Click(Pages.OfferDetailsPage.RedeemOfferButton);
                    break;
                }
                else
                {
                    Driver.Instance.Navigate().Back();
                }
            }
        }
    }
}
