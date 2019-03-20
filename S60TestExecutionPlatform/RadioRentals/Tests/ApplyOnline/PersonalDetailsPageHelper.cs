
namespace RadioRentals.Tests.ApplyOnline
{
    /**
    *
    * This class covers the helper methods which are used in PersonalDetailsPageTests.cs
    * of Radio Rentals. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class PersonalDetailsPageTests
    {
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

    }
}