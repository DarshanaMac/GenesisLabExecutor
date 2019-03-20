using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests
{
    /**
    *
    * This class covers the helper methods of the Store Locator page of Bardot. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class StoreLocatorPageTests
    {
        public string I_GetMaximumDistance(string distance)
        {
            switch (distance)
            {
                case "15 KM": return "15";
                case "30 KM": return "30";
                case "100 KM": return "100";
                case "300 KM": return "300";
                case "500 KM": return "500";
                case "Any": return "999999";
            }
            return "0";
        }

        public void I_HandlePopUp()
        {
            if (I.SeeExist(Pages.LayoutPage.PopUpLabel) == true)
            {
                I.Click(Pages.LayoutPage.IAgreeButton);
            }
        }
    }
}
