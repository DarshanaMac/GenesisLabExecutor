using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using S60TestExecutionPlatform.ElementBase;
using System;

namespace S60TestExecutionPlatform.Element
{
   /**
   *
   * This class contains all the possible methods of Link HTML element
   * 
   * @author darshana
   * 
   */
    public class Link : BaseElement, ILink
    {
        public Link(IWebDriver driver, By identifier) : base(driver, identifier)
        {

        }

        public void ClickLink()
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

        public string GetTextValue()
        {
            string actualText = null;
            try
            {
                actualText = element.Text;
            }
            catch (Exception e)
            {
                Console.WriteLine(" Unable to read the value from the element : " + e.Message);
            }
            return actualText;
        }

        public bool VerifyText(string text)
        {
            return GetTextValue().Equals(text, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
