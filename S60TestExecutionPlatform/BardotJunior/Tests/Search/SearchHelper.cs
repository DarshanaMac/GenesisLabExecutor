using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests
{
    partial class SearchTests : TestBase
    {
        public void I_HandlePopUp()
        {
            if (I.SeeExist(Pages.LayoutPage.PopUpLabel) == true)
            {
                I.Click(Pages.LayoutPage.IAgreeButton);
            }
        }
    }
}
