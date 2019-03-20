using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests.CategoryListing
{
    partial class CategoryListingPageTests : TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
       
        public void CategoryListingPage_VerifyTheMegaMenu()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.ClickOnElementList(Pages.HomePage.MegaMenuItem,0);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRDJ_Confident)]
        public void CategoryListingPage_VerifyTheSubCategories()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.WaitUntilReady();
            I.MouseHoverMenuItemByDisplayText(Pages.HomePage.MegaMenuItem, TestData.CategoryListingPage.MenuItemPageHeader);
            I.WaitUntilReady();
            //I.ClickOnElementList(Pages.HomePage.SubMenuItems,1);
            I.SeeText(Pages.CategoryListingPage.PageHeaderTitle, TestData.CategoryListingPage.SubMenuItemPageHeader);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRDJ_Confident)]
        public void CategoryListingPage_ReviewThePageLayout() {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.Wait(7);
            I.ClickOnElementList(Pages.HomePage.MegaMenuItem, 2);
            I.WaitUntilReady();
            I.See(Pages.CategoryListingPage.FilterOptionPanel);
            I.See(Pages.CategoryListingPage.HideFilterButton);           
            I.See(Pages.CategoryListingPage.BreadcrumbPanel);
            I.See(Pages.CategoryListingPage.ProductItemList);
        }
    }
}
