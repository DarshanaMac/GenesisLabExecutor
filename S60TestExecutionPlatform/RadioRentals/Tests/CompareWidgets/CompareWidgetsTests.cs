using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using S60TestExecutionPlatform.Element;
namespace RadioRentals.Tests.CompareWidgets
{
    /**
    *
    * This class covers the user actions of the compare widget page of Radio Rentals. 
    * 
    * @author Darshana Konara
    * 
    */
    partial class CompareWidgetsTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CompareWidgetsPage_VerifyComparePanelForTwoComparedProducts()
        {
            I.Open(Pages.CategoryLandingPage.Url);
            I.RefreshPage();
            I_ClickProductCompare(0);
            I_ClickProductCompare(1);
            I.Click(Pages.CompareWidgetsPage.PanelTitle);
            I_CompareProductNames(0, 1);
            I.See(Pages.CompareWidgetsPage.PanelTitle);
            I.See(Pages.CompareWidgetsPage.CompareButton);
            I.See(Pages.CompareWidgetsPage.CompareButton);
            I.See(Pages.CompareWidgetsPage.ClearAllButton);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CompareWidgetsPage_NavigateToCompareNowPage()
        {
            I.Open(Pages.CategoryLandingPage.Url);
            I_ClickProductCompare(0);
            I.Click(Pages.CompareWidgetsPage.PanelTitle);
            I.WaitUntilReady();
            I.See(Pages.CompareWidgetsPage.PanelTitle);
            I.See(Pages.CompareWidgetsPage.CompareButton);
            I.See(Pages.CompareWidgetsPage.CompareButton);
            I.See(Pages.CompareWidgetsPage.ClearAllButton);
            I.WaitUntilReady();
            I.Click(Pages.CompareWidgetsPage.CompareButton);
            I.AmOn(Pages.CompareWidgetsPage.Url);
            I.See(Pages.CompareWidgetsPage.ComparePageHeaderTitle);
            I.See(Pages.CompareWidgetsPage.RemoveAllButton);
        }
    }
}
