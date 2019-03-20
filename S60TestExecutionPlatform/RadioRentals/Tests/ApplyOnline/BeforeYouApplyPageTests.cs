using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.ApplyOnline
{
    /**
   *
   * This class covers the user actions of the Before You Apply section of Apply Online feature of Radio Rentals. 
   * 
   * @author Kanchana Liyanagamage
   * 
   */
    partial class BeforeYouApplyPageTests : TestBase
    {

        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.ApplyOnlne)]
        [Category(Categories.Demo)]
        [Category(Categories.Test)]
        public void BeforeYouApply_NavigateToBeforeYouApplyPage()
        {
            I.Open(Pages.HomePage.Url);
            I.Click(Pages.LayoutPage.ApplyOnlineButton);
            I.SeeInTitle(TestData.BeforeYouApplyPage.PageTitle);
            I.AmOn(Pages.BeforeYouApplyPage.Url);
            I.WaitUntilReady();
            I.SeeText(Pages.BeforeYouApplyPage.HeaderTitle, TestData.BeforeYouApplyPage.HeaderTitle);
            I.See(Pages.BeforeYouApplyPage.BeginApplicationButton);
        } 
    }
}
