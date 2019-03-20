using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;
using System;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace RadioRentals.Tests.Catalogue
{

    /**
    *
    * This class covers the user actions of the catalogue page of Radio Rentals. 
    * 
    * @author Darshana Konara
    * 
    */

    class CataloguePageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CataloguePage_NavigationToCataloguePage()
        {
            I.Open(Pages.CataloguePage.Url);
            I.AmOn(Pages.CataloguePage.Url);
        }

        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CataloguePage_PresenceOfElements()
        {
            I.Open(Pages.CataloguePage.Url);
            I.See(Pages.CataloguePage.HeaderTitle);
            I.SwitchToFrame(Pages.CataloguePage.CatelogueFrame,"id");
        }
    }
}
