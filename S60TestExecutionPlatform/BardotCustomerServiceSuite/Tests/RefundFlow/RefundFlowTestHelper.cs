using NUnit.Framework;
using OpenQA.Selenium;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Base;
using S60TestExecutionPlatform.Core;
using System.Linq;

namespace Bardot.Tests.RefundFlow
{
    partial class RefundFlowTests :TestBase
    {
        public void I_CheckOderStatus()
        {
            bool OrderNumber = I.PrecenceOfElement(Pages.OrdersPage.OrderNumberLink);
            if (OrderNumber.Equals(true))
            {
                string paymentstatus=I.GetAttributeText(Pages.OrdersPage.PaidStatusText);
                if (paymentstatus.Equals("PAID")) {
                    I.Open(Pages.ScheduleJobs.Url);
                    I.Wait(3);
                }
            }
        }

        public void I_CheckOrderExportJobStatus() {
            string exportjobstatus = I.GetAttributeText(Pages.ScheduleJobs.JobExportStatusLabel);
            if (exportjobstatus.Contains("OK")) {
                I.Open(Pages.CustomerSuitePage.Url);
            }
        }

        public void I_CustomerSuiteLogin() {
            I.NavigateToPage(Pages.CustomerSuitePage.Url,"Yes");
            I.Fill(Pages.CustomerSuitePage.UsernameTextField,TestData.CustomerSuiteLoginPage.Username) ;
            I.Fill(Pages.CustomerSuitePage.PasswordTextField,TestData.CustomerSuiteLoginPage.Password);
            I.Click(Pages.CustomerSuitePage.LogonButton);
        }

        public void I_CheckExportJobStatus() {
            I.Fill(Pages.CustomerSuitePage.OrderNoTextField,TestData.OrdersPage.OrderNumber);
            I.Click(Pages.CustomerSuitePage.SearchButton);
            I.Wait(3);
            string exportstatus = I.GetAttributeText(Pages.CustomerSuitePage.ExportStatus);
            if (exportstatus.Contains("EXPORTED")) {
                I.Click(Pages.CustomerSuitePage.RefundButton);
            }
        }

        public void I_RefundProductCustomerSuite() {
            I.Wait(2);
            I.Click(Pages.CustomerSuitePage.PlusMinusIcon);
            I.Fill(Pages.CustomerSuitePage.QtyTextField, TestData.CustomerSuitePage.Quantity);
            I.Wait(2);
            I.Click(Pages.CustomerSuitePage.CorrectSignButton);
            I.SelectValue(Pages.CustomerSuitePage.ReturnReasonCodeDropDownList1, I_GetResonCode((string)TestData.CustomerSuitePage.ReturnReasonCode1));
            I.SelectValue(Pages.CustomerSuitePage.ReturnReasonCodeDropDownList2, I_GetResonCode((string)TestData.CustomerSuitePage.ReturnReasonCode2));
            string refundtype = TestData.CustomerSuitePage.PaymentType;
            if (refundtype.Contains("Adyen"))
            {
                I.Click(Pages.CustomerSuitePage.RefundAdyenButton);
                I.Wait(3);
            }
            else {
               I.Click(Pages.CustomerSuitePage.RefundCreditNotesButton);
                I.Wait(3);
            }
            I.Click(Pages.CustomerSuitePage.RefundConfirmPopUpButton);
            I.Wait(3);
            I.AcceptJavascriptPopup();
            I.Click(Pages.CustomerSuitePage.RefundCompletedCheckBox);
        }

        public void I_ExecuteRefundJob() {
            I.Open(Pages.BusinessManagerLoginPage.Url);
            I.Fill(Pages.BusinessManagerLoginPage.UsernameTextField, TestData.LoginPage.Username);
            I.Fill(Pages.BusinessManagerLoginPage.PasswordTextField, TestData.LoginPage.Password);
            I.Click(Pages.BusinessManagerLoginPage.LoginButton);

            I.Click(Pages.BusinessManagerPage.AdministrationLink);
            I.Click(Pages.BusinessManagerPage.OperationsLink);
            I.Click(Pages.BusinessManagerPage.JobSchedulesLink);
            I.Wait(3);
            I.Click(Pages.ScheduleJobs.RefundJobLink);
            I.Wait(2);
            I.Click(Pages.ScheduleJobs.RunNowButton);
            I.Wait(3);
           
        }

        public void I_CheckRefundStatusCustomerSuite() {
            I_CustomerSuiteLogin();
            I.Fill(Pages.CustomerSuitePage.OrderNoTextField, TestData.OrdersPage.OrderNumber);
            I.Click(Pages.CustomerSuitePage.SearchButton);
            I.Click(Pages.CustomerSuitePage.RefundButton);
            I.WaitUntilReady();
            string textLog = I.GetAttributeText(Pages.CustomerSuitePage.RefundProceedLabel);
            if (textLog.Contains("Refund Processed")) {
                I.Click(Pages.CustomerSuitePage.Logoutlink);
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    I.RefreshPage();
                    I.WaitUntilReady();
                    I.Fill(Pages.CustomerSuitePage.OrderNoTextField, TestData.OrdersPage.OrderNumber);
                    I.Click(Pages.CustomerSuitePage.SearchButton);
                    I.Click(Pages.CustomerSuitePage.RefundButton);
                    I.Wait(3);
                    string textLognew = I.GetAttributeText(Pages.CustomerSuitePage.RefundProceedLabel);
                    if (textLognew.Contains("Refund Processed"))
                        break;
                }
                string statuslog = I.GetAttributeText(Pages.CustomerSuitePage.RefundProceedLabel);
                if (statuslog.Contains("Refund Processed"))
                {
                    I.Click(Pages.CustomerSuitePage.Logoutlink);
                }
                else {
                    Verification.Fail("Cannot find Refund Processed text");
                }
            }
        }

        public string I_GetResonCode(string reason)
        {
            switch (reason)
            {
                case "FAULTY/DAMAGED": return "16";
                case "LOST PARCEL": return "18";
                case "TOO BIG": return "21";
                case "NOT WHAT I EXPECTED": return "23";
                case "TOO SMALL": return "24";
                case "INCORRECT ITEM": return "25";
                case "UNSUITABLE GIFT": return "27";
                case "OVERSELL": return "30";
            }
            return "0";
        }
    }
}
