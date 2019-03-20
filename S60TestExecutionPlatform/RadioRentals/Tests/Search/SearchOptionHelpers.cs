using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.Search
{
    partial class SearchOptionPageTests : TestBase
    {
        public void I_GetSearchItemCount()
        {
            int count = I.GetElementCount(Pages.SearchOptionPage.SearchResultList);
            if (count > 0)
            {
                I.See(Pages.SearchOptionPage.SearchResultPannel);
                I.See(Pages.SearchOptionPage.SearchResultList);
            }
        }
    }
}
