using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests
{
    public static class Actions
    {
        public static string I_GetStreetType(string streetType)
        {
            switch (streetType)
            {
                case "Court": return "CT | Court";
                case "Avenue": return "AVE | Avenue";
            }
            return "0";
        }

        public static string I_GetState(string state)
        {
            switch (state)
            {
                case "Australian Capital Territory": return "ACT";
                case "New South Wales": return "NSW";
                case "Northern Territory": return "NT";
                case "Queensland": return "QLD";
                case "South Australia": return "SA";
                case "Tasmania": return "TAS";
                case "Victoria": return "VIC";
                case "Western Australia": return "WA";
            }
            return "0";
        }

        public static string I_GetMonthIndex(string month)
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
    }
}