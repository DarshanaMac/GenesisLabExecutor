using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.StoreLocator
{
    partial class StoreLocatorPageTests
    {
        public void I_CompareSearchAndResult() {

            if (I.SeeExist(Pages.StoreLocatorPage.ViewAllStoresLink))
            {
                S60TestExecutionPlatform.Base.Verification.Pass("TEST PASSED: Element does exist in the page.");
            }
            else {
                S60TestExecutionPlatform.Base.Verification.Fail("TEST FAILED: Element does not exist in the page.");
            }
        }
    }
}
