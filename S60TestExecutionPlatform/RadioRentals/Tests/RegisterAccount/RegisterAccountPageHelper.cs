using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Base;
using S60TestExecutionPlatform.Core;
using S60TestExecutionPlatform.Utility;
using System;
using System.Collections.Generic;

namespace RadioRentals.Tests.RegisterAccount
{
    /**
    *
    * This class covers the helper methods of the Register Account page of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class RegisterAccountPageTests:TestBase
    {
        private List<string> I_VerifyDropDownListOptionList(string dropDownListElement)
        {
            return I.GetDropDownListOptionList(dropDownListElement);
        }

        public void I_VerifyTitleDropDownListOptions(string dropDownListElement)
        {
            List<string> titleDropDownListOptions = I_VerifyDropDownListOptionList(dropDownListElement);
            String[] titleArray = { "", "Mr", "Mrs", "Miss", "Ms", "Dr" };
            Boolean verify = true;
            for (int i = 0; i < titleDropDownListOptions.Count; i++)
            {
                if (!titleDropDownListOptions[i].Equals(titleArray[i]))
                {
                    verify = false;
                    break;
                }
            }
            if (verify)
                Verification.Pass("TEST PASSED: Title drop down list options are displayed successfully.");
            else
                Verification.Fail("TEST FAILED: Title drop down list options are not displayed successfully.");
        }

        public void I_VerifyDateDropDownListOptions(string dropDownListElement)
        {
            List<string> dateDropDownListOptions = I_VerifyDropDownListOptionList(dropDownListElement);
            String[] DateArray = { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
                "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
            Boolean verify = true;
            for (int i = 0; i < dateDropDownListOptions.Count; i++)
            {
                if (!dateDropDownListOptions[i].Equals(DateArray[i]))
                {
                    verify = false;
                    break;
                }
            }
            if (verify)
                Verification.Pass("TEST PASSED: Date drop down list options are displayed successfully.");
            else
                Verification.Fail("TEST FAILED: Date drop down list options are not displayed successfully.");
        }

        public void I_VerifyMonthDropDownListOptions(string dropDownListElement)
        {
            List<string> monthDropDownListOptions = I_VerifyDropDownListOptionList(dropDownListElement);
            String[] monthArray = { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            Boolean verify = true;
            for (int i = 0; i < monthDropDownListOptions.Count; i++)
            {
                if (!monthDropDownListOptions[i].Equals(monthArray[i]))
                {
                    verify = false;
                    break;
                }
            }
            if (verify)
                Verification.Pass("TEST PASSED: Month drop down list options are displayed successfully.");
            else
                Verification.Fail("TEST FAILED: Month drop down list options are not displayed successfully.");
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

        private object I_GenerateUniqueMailAddressForNewProfile()
        {
            long uniqueText = Helper.GetUniqueNumericValue();
            object emailAddress = "rrp" + uniqueText + "@gmail.com";
            return emailAddress;
        }
    }
}