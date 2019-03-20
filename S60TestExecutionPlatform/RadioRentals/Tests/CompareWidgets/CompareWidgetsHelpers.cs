using NUnit.Framework;
using OpenQA.Selenium;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace RadioRentals.Tests.CompareWidgets
{
    partial class CompareWidgetsTests : TestBase
    {
        public string I_StoreProductName(object element,int index) {
            string ProductName = I.GetTextByIndex(element, index);
            return ProductName;
        }

        public void I_CompareProductNames(int firstIndex,int secondIndex) {
            string ProductOne=I_StoreProductName(Pages.CategoryLandingPage.Product, firstIndex);
            string ProductTwo=I_StoreProductName(Pages.CategoryLandingPage.Product, secondIndex);
            string ProductPanelOne = I.GetTextByIndex(Pages.CategoryLandingPage.PanelProduct, secondIndex);
            string ProductPanelTwo = I.GetTextByIndex(Pages.CategoryLandingPage.PanelProduct, firstIndex);
            if (ProductOne.Equals(ProductPanelOne) && ProductTwo.Equals(ProductPanelTwo)) {
                I.WaitUntilReady();
            }
        }

        public void I_ClickProductCompare(int index) {
            I.ScrollBrowser("0", "250");
            I.ClickOnElementList(Pages.CategoryLandingPage.CompareCheckBox,index);
        }
    
        public void I_VerifyOnComparePage(int firstIndex, int secondIndex) {
            string ProductOne = I_StoreProductName(Pages.CategoryLandingPage.Product, firstIndex);
            string ProductTwo = I_StoreProductName(Pages.CategoryLandingPage.Product, secondIndex); 
            I.SeeItemExistOnElementList(Pages.CompareWidgetsPage.ProductsOnComparePage, ProductOne,0);
            I.SeeItemExistOnElementList(Pages.CompareWidgetsPage.ProductsOnComparePage, ProductTwo,1);
        }
    }
}
