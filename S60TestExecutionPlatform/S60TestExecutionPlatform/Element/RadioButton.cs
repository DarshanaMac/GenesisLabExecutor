using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using S60TestExecutionPlatform.ElementBase;

namespace S60TestExecutionPlatform.Element
{
    /**
  *
  * This class contains all the possible methods of Radio Button HTML element
  * 
  * Actions can be performed : click the radio button , check whether the
  * button is disable
  * 
  * @author darshana
  */
    public class RadioButton : BaseElement, IRadioButton
    {
        public RadioButton(IWebDriver driver, By identifier) : base(driver, identifier)
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
    }
}
