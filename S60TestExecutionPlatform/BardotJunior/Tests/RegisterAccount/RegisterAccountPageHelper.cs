using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using S60TestExecutionPlatform.Utility;

namespace BardotJunior.Tests.RegisterAccount
{
   partial class RegisterAccountPageTests : TestBase
    {

        static private object I_GenerateUniqueMailAddressForNewProfile()
        {
            long uniqueNumber = Helper.GetUniqueNumericValueTest();
            object emailAddress = "test_bardot" + uniqueNumber + "@s60.com.au";
            return emailAddress;
        }

        public string I_GetMonthCode(string month)
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
                case "Octomber": return "10";
                case "November": return "11";
                case "December": return "12";
            }
            return "0";
        }

        public void I_HandlePopUp()
        {
            if (I.SeeExist(Pages.LayoutPage.PopUpLabel) == true)
            {
                I.Click(Pages.LayoutPage.IAgreeButton);
            }
        }
    }
}
