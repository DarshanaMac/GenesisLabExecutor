using S60TestExecutionPlatform.ElementBase;
using OpenQA.Selenium;

namespace S60TestExecutionPlatform.Element
{
    /**
    *
    * This class contains all the possible methods of Check Box HTML element
    * 
    * Actions can be performed : toggle the check box , Select (check) the
    * check box , Un-check the check box , check whether the check box is
    * selected(checked) , check whether the check box is disabled
    *
    * @author darshana 
    * */
    public class Checkbox : BaseElement, ICheckBox
    {
        public Checkbox(IWebDriver driver, By identifier) : base(driver, identifier){

        }
        public void Check()
        {
            if (!IsChecked())
            {
                Toggle();
            }
        }

        public bool IsChecked()
        {
            return element.Selected;
        }

        public bool IsDisabled()
        {
            return !element.Enabled;
        }

        public void Toggle()
        {
            element.Click();
        }

        public void Uncheck()
        {
            if (IsChecked()){
                Toggle();
            }
        }
    }
}
