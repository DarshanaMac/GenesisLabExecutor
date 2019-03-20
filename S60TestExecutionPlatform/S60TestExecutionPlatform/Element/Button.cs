using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using S60TestExecutionPlatform.ElementBase;

namespace S60TestExecutionPlatform.Element
{
    /**
    *
    * This class contains all the possible methods of Button HTML element
    * 
    * Actions can be performed : click the button , check whether the
    * button is disable , perform the mouse hover
    * 
    * @author darshana
    */
    public class Button : BaseElement, IButton
    {
        public Button(IWebDriver driver, By identifier) : base(driver, identifier)
        {

        }

        public void ClickButton()
        {
            element.Click();
        }

        public bool IsDisabled()
        {
            return !element.Enabled;
        }

        public void MouserHover()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

        }
    }
}
