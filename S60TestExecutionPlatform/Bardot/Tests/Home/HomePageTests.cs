using NUnit.Framework;
using S60TestExecutionPlatform;
using S60TestExecutionPlatform.Core;

namespace Bardot.Tests
{
    /**
    *
    * This class covers the user actions of the Home page of Bardot. 
    * 
    * @author Kanchana Liyanagamage
    * 
    */
    partial class HomePageTests : TestBase
    {
        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Priority1)]
        public void HomePage_NavigateToHomePage()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.AmOn(Pages.HomePage.Url);
        }

        [Test]
        [Category(Categories.BRD_SmokeTest)]
        [Category(Categories.BRD_Confident)]
        public void HomePage_PresenceOfElements()
        {
            I.Open(Pages.HomePage.Url);
            I_HandlePopUp();
            I.WaitUntilReady();
            I.See(Pages.HomePage.BardotLogo);
            I.See(Pages.HomePage.SearchIcon);
            I.See(Pages.HomePage.Slider);
        }
    }
}
