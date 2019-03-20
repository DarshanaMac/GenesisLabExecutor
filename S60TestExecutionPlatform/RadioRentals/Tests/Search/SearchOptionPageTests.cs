using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.Search
{

    /**
    *
    * This class covers the user actions of the search option page of Radio Rentals. 
    * 
    * @author Darshana Konara
    * 
    */
    partial class SearchOptionPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void SearchPage_VerifySuccessfulSearchAnItem()
        {
            I.Open(Pages.HomePage.Url);
            I.Fill(Pages.LayoutPage.SearchTextField, TestData.SearchItemPage.Item);
            I.Click(Pages.LayoutPage.SearchButton);
            I.SeePartialText(Pages.SearchOptionPage.SearchResultTitle, TestData.SearchItemPage.SearchResult);
            I_GetSearchItemCount();
            I.See(Pages.SearchOptionPage.FilterPannel);
        }
    }
}
