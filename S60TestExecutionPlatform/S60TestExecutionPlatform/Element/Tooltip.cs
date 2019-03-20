using OpenQA.Selenium;
using S60TestExecutionPlatform.ElementBase;
using System;
namespace S60TestExecutionPlatform.Element
{
    /**
    *
    * This class contains all the possible methods of Tooltip HTML element
    * 
    * @author darshana
    * 
    */
    public class Tooltip : BaseElement, ITooltip
    {
        public Tooltip(IWebDriver driver, By identifier) : base(driver, identifier)
        {

        }
        public bool VerifyText(string text)
        {
            return element.Text.Equals(text, StringComparison.InvariantCultureIgnoreCase);
        }

    }
}
