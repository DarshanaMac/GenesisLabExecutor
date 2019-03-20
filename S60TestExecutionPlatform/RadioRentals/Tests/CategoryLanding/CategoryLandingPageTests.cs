using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using System;

namespace RadioRentals.Tests.CategoryLanding
{
    /**
    *
    * This class covers the user actions of the category landing page of Radio Rentals. 
    * 
    * @author Darshana Konara
    * 
    */
    class CategoryLandingPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CategoryLandingPage_NavigateToCategoryLandingPage()
        {
            I.Open(Pages.CategoryLandingPage.Url);
            I.AmOn(Pages.CategoryLandingPage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CategoryLandingPage_PresenceOfElements()
        {
            I.Open(Pages.CategoryLandingPage.Url);
            I.See(Pages.CategoryLandingPage.HeaderTitle);
            I.SeeInTitle(TestData.CategoryLandingPage.PageTitle);
            I.SeeText(Pages.CategoryLandingPage.SubHeaderTitle, TestData.CategoryLandingPage.SubHeaderTitle); 
        }
        
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CategoryListingPage_NavigateToCategoryListingPage()
        {
            I.Open(Pages.CategoryListingPage.Url);
            I.AmOn(Pages.CategoryListingPage.Url);
            I.See(Pages.CategoryListingPage.FirstItemPanel);
            I.See(Pages.CategoryListingPage.ListItems);
            I.See(Pages.CategoryListingPage.FirstItemName);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CategoryListingPage_PresenceOfElements() {
            I.Open(Pages.CategoryListingPage.Url);
            I.See(Pages.CategoryListingPage.FirstItemPanel);
            I.See(Pages.CategoryListingPage.InStockLink);
            I.See(Pages.CategoryListingPage.RefineSearchPanel);
            I.See(Pages.CategoryListingPage.FilterPanel);
            I.See(Pages.CategoryListingPage.AddCartButton);
            I.See(Pages.CategoryListingPage.WishListButton);
            I.See(Pages.CategoryListingPage.CartIconButton);
            I.See(Pages.CategoryListingPage.BrandNamesLabel);
        }
    }
}