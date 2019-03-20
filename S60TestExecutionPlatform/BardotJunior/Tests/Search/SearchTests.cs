using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests
{
    /**
    *
    * This class covers the user actions of the Search of Bardot. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class SearchTests : TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority6)]
        public void Search_VerifySearchResults()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.WaitUntilReady();
            I.Click(Pages.HomePage.SearchLink);
            I.WaitUntilReady();
            I.Fill(Pages.HomePage.SearchTextField, TestData.Search.SearchText);
            I.Click(Pages.HomePage.SearchButton);
            I.WaitUntilReady();
            I.SeePartialText(Pages.HomePage.SearchResultBreadcrumb, TestData.Search.SearchResultBreadcrumbText);
        }   
    }
}
