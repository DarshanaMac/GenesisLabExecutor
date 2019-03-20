using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests.RefundFlow
{
  partial  class RefundFlowTests :TestBase
    {
        [Test]
        public void RefundFlow_RefundProduct() {
            I.Open(Pages.BusinessManagerLoginPage.Url);
            I.Fill(Pages.BusinessManagerLoginPage.UsernameTextField,TestData.LoginPage.Username);
            I.Fill(Pages.BusinessManagerLoginPage.PasswordTextField,TestData.LoginPage.Password);
            I.Click(Pages.BusinessManagerLoginPage.LoginButton);
            I.Click(Pages.BusinessManagerPage.MerchantToolsLink);
            I.Click(Pages.BusinessManagerPage.OrderingLink);
            I.Click(Pages.BusinessManagerPage.OrdersLink);
            I.Fill(Pages.OrdersPage.OrderNuberTextField,TestData.OrdersPage.OrderNumber);
            I.Click(Pages.OrdersPage.OrderSearchButton);
            I_CheckOderStatus();
            I.Click(Pages.ScheduleJobs.ExportJobsLink);
            I.Wait(2);
            I.Click(Pages.ScheduleJobs.RunNowButton);
            I.WaitUntilReady();
            I_CustomerSuiteLogin();
            I_CheckExportJobStatus();
            I_RefundProductCustomerSuite();
            I_ExecuteRefundJob();
            I_CheckRefundStatusCustomerSuite();
        }
    }
}
