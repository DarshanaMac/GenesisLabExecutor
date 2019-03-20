using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace BardotJunior.Tests.MiniCart
{
   partial class MiniCartPageTests : TestBase
    {
        string productname = null;
        public string I_StoreProductName(object element, int index) {
            string ProductName = I.GetTextByIndex(element, index);
            productname = ProductName;
            return ProductName;
        }

        public void I_VerifyProductName(string productname) {

            I.SeeText(Pages.ShoppingCartPage.ProductName, productname);
        }

        public void I_RemoveProductFromShoppingCart() {
            I.Open(Pages.ShoppingCartPage.Url);
            I_HandlePopUp();
            int productcount = I.GetElementCount(Pages.ShoppingCartPage.RemoveLink);

            for (int i=1;i<= productcount;i++) {
                I.Click(Pages.ShoppingCartPage.RemoveLink);
                I.WaitUntilReady();
            }
        }
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
