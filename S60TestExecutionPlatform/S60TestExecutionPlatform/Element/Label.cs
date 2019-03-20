using OpenQA.Selenium;
using S60TestExecutionPlatform.ElementBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S60TestExecutionPlatform.Element
{
    /**
    *
    * This class contains all the possible methods of Label HTML element
    * 
    * Actions can be performed : click the button , check whether the
    * button is disable , perform the mouse hover
    * 
    * @author darshana
    */
    public class Label : BaseElement, ILabel
    {
        public Label(IWebDriver driver, By identifier) : base(driver, identifier)
        {

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

        public bool VerifyPartialText(string text)
        {
            return GetTextValue().Contains(text);
        }
    }
}
