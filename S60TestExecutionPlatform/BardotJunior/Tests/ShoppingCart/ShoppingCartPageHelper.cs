using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests.ShoppingCart
{
    partial class ShoppingCartPageTests : TestBase
    {
        public void I_HandlePopUp()
        {
            if (I.SeeExist(Pages.LayoutPage.PopUpLabel) == true)
            {
                I.Click(Pages.LayoutPage.IAgreeButton);
            }
        }

        public void I_ClickActiveSwatch()
        {
            int listCount = I.GetElementCount(Pages.ProductDetailsPage.SwatchesSizeLinks);
            for (int i = 0; i <= listCount; i++)
            {
                I.ClickOnElementList(Pages.ProductDetailsPage.SwatchesSizeLinks, i);
                if (I.PrecenceOfElement(Pages.ProductDetailsPage.AddToCartButton) == true)
                {
                    break;
                }
            }
        }
    }
}
