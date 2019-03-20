
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ChangePassword
{
    partial class ChangePasswordPageTests
    {

        /**
        *
        * This class covers the help methods of the Change Password page of Radio Rentals. 
        * 
        * @author Kanchana Liyanagamage
        * 
        */
        public void I_LoginAsCustomer()
        {
            I.Open(Pages.LoginPage.Url);
            I.Fill(Pages.LoginPage.EmailAddressTextField, TestData.LoginPage.ValidEmailAddress);
            I.Fill(Pages.LoginPage.PasswordTextField, TestData.LoginPage.ValidPassword);
            I.Click(Pages.LoginPage.SignInButton);
        }
    }
}
