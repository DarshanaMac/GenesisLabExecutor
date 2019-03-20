using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.Careers
{
    class CareersPageTests : TestBase
    {
        [Test]
        [Category(Categories.RR_SmokeTest)]
        public void CareerPage_NavigationToTheCareerPage()
        {
            I.Open(Pages.CareersPage.Url);
            I.AmOn(Pages.CareersPage.Url);
            I.See(Pages.CareersPage.HeaderTitle);
        }
    }
}
