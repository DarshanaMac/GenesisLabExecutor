using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using System;
using System.Collections.Generic;

namespace RadioRentals.Tests.ProductDetails
{
    /**
    *
    * This class covers the user actions of the product details page of Radio Rentals. 
    * 
    * @author Darshana Konara
    * 
    */
    class ProductDetailsPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        [Category(Categories.Demo)]
        public void ProductDetailsPage_NavigateToTheProductDetailsPage()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I.SeeInTitle(TestData.ProductDetailsPage.PageTitle);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ProductDetailsPage_VerifyProductAttributes()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I.See(Pages.ProductDetailsPage.ProductName);
            I.See(Pages.ProductDetailsPage.DescriptionPanel);
            I.See(Pages.ProductDetailsPage.PostcodeTextField);
            I.See(Pages.ProductDetailsPage.CheckStockButton);
            I.See(Pages.ProductDetailsPage.RentalTermsPanel);
            I.See(Pages.ProductDetailsPage.ItemPrice);
            I.See(Pages.ProductDetailsPage.DeliveryButton);
            I.See(Pages.ProductDetailsPage.ClickAndCollectButton);
            I.See(Pages.ProductDetailsPage.InStoreButton);
            I.See(Pages.ProductDetailsPage.ItemDescription);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ProductDetailsPage_VerifyTheCheckStockInformationPopUp()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I.Fill(Pages.ProductDetailsPage.LocationTextField,TestData.ProductDetailsPage.Location);
            I.Click(Pages.ProductDetailsPage.CheckStockButton);
            I.WaitUntilReady();
            I.See(Pages.ProductDetailsPage.PopupTitle);
            I.See(Pages.ProductDetailsPage.FindStoreButton);
            I.See(Pages.ProductDetailsPage.ListAllStoresLink);
            I.See(Pages.ProductDetailsPage.StoreLinks);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ProductDetailsPage_VerifyTheDeliveryPopUp()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I.Click(Pages.ProductDetailsPage.DeliveryIconLink);
            I.See(Pages.ProductDetailsPage.DeliveryPopUpTitle);
            I.See(Pages.ProductDetailsPage.DeliveryIconLink);
            I.See(Pages.ProductDetailsPage.ClickAndCollectPopUpIcon);
            I.See(Pages.ProductDetailsPage.InStoreButton);
        }
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ProductDetailsPage_NavigateToTermsAndConditionsPage()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I.See(Pages.ProductDetailsPage.TermsAndConditionLink);
            I.Click(Pages.ProductDetailsPage.TermsAndConditionLink);
            I.Click(Pages.ProductDetailsPage.TermsAndConditionPopUpHeader);
        }
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void ProductDetailsPage_VerifyDeliveryAndInstallationTabAndContent()
        {
            I.Open(Pages.ProductDetailsPage.Url);
            I.Click(Pages.ProductDetailsPage.DeliveryAndInstallationLink);
            I.WaitUntilReady();
            I.See(Pages.ProductDetailsPage.DeliveryTabContent);
            I.See(Pages.ProductDetailsPage.RemoveAndDisposalFeeLabel);
        }
    }
}
