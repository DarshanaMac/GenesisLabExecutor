using OpenQA.Selenium;
using S60TestExecutionPlatform.ElementBase;
using System;

namespace S60TestExecutionPlatform.Element
{
    /**
    *
    * This class contains all the possible methods of
    * 
    * Text field
    * Number field
    * Password filed
    * Search field
    * HTML elements.
    * 
    * Actions can be performed :  Enter text , Clear text , get the text of
    * the text field , verify the text fields value with expected text.
    *  
    */
    public class TextField : BaseElement, ITextField
    {
        public TextField(IWebDriver driver, By identifier) : base(driver, identifier)
        {

        }

        public void ClearText()
        {
            element.Clear();
        }

        public void EnterText(string text)
        {
            element.SendKeys(text);
        }

        public string GetTextValue()
        {
            string actualText = null;
            try
            {
                actualText = element.GetAttribute("value");
            }
            catch (Exception e)
            {
                Console.WriteLine("Get Text value error in text field : " + e.Message);
            }
            return actualText;
        }

        public bool VerifyText(string text)
        {
            return GetTextValue().Equals(text, StringComparison.InvariantCultureIgnoreCase);
        }

    }
}
