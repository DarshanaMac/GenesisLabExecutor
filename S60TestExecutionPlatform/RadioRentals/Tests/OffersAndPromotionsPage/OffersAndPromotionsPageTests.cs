using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.OffersAndPromotionsPage
{
    /**
    *
    * This class covers the user actions of the offers and promotions page of Radio Rentals. 
    * 
    * @author Darshana Konara
    * 
    */
    partial class OffersAndPromotionsPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void OffersAndPromotionsPage_NavigationToOffersAndPromotionsPage()
        {
            I.Open(Pages.OffersAndPromotionsPage.Url);
            I.AmOn(Pages.OfferDetailsPage.Url);
            I_CheckRedeemOffer(Pages.OfferDetailsPage.RedeemOfferButton);
            I.WaitUntilReady();          
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void OffersAndPromotionsPage_NavigationToClaimAndOfferPage()
        {
            I.Open(Pages.OffersAndPromotionsPage.Url);
            I.WaitUntilReady();
            I_CheckRedeemOffer(Pages.OfferDetailsPage.RedeemOfferButton);
            I.WaitUntilReady();
            I.See(Pages.ClaimAndAnOfferPage.ClaimAnOfferHeaderTitle);
            I.Click(Pages.ClaimAndAnOfferPage.ProceedToNextStep);
            I.WaitUntilReady();
            I.AmOn(Pages.ClaimSubmitPage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void OffersAndPromotionsPage_SubmitClaimForm()
        {
            I.Open(Pages.OffersAndPromotionsPage.Url);
            //I.ClickOnElementList(Pages.OffersAndPromotionsPage.PromotionTile, 0);
            I_CheckRedeemOffer(Pages.OfferDetailsPage.RedeemOfferButton);
            I.WaitUntilReady();
           // I.Click(Pages.OfferDetailsPage.RedeemOfferButton);
            I.WaitUntilReady();
            I.Click(Pages.ClaimAndAnOfferPage.ProceedToNextStep);
            I.WaitUntilReady();
            I_FillClaimForm();
        }
    }
}
