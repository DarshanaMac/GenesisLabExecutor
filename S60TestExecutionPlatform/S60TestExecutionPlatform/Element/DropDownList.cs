using OpenQA.Selenium;
using S60TestExecutionPlatform.ElementBase;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace S60TestExecutionPlatform.Element
{
    /**
    *
    * This class contains all the possible methods of Drop Down List element
    * Actions can be performed : select a value from the list , check
    * whether the drop down list is disabled , verify the element or elements , get
    * the drop down lists size , get the value of selected value , verify the
    * selected value with the expected text
    */
    public class DropDownList : BaseElement, IDropDownList
    {
        public DropDownList(IWebDriver driver, By identifier) : base(driver, identifier){

        }
        public string GetSelectedValue()
        {
            string defaultValue = null;
            try {
                SelectElement select = new SelectElement(GetWrappedElement());
                IWebElement option = select.SelectedOption;
                defaultValue = option.Text;
            } catch (Exception e) {
                Console.WriteLine("Get default value error : "+e);
            }
            return defaultValue;
        }

        public int GetSizeOfDropDownList()
        {
            SelectElement select = new SelectElement(GetWrappedElement());
            int size = 0;
            try {
                IList<IWebElement> elementCount = select.Options;
                size = elementCount.Count;
            } catch (Exception e) {               
                Console.WriteLine("Error in Get size : "+e);
            }
            return size;
        }

        public bool IsDisable()
        {
            return !element.Enabled;
        }

        public void SelectValue(string visibleText)
        {
            SelectElement select = new SelectElement(GetWrappedElement());
            try {
                select.SelectByText(visibleText);
            } catch (Exception e) {
                Console.WriteLine("Unable to select the option : "+e);
            }
        }

        public void SelectValue(int index)
        {
            SelectElement select = new SelectElement(GetWrappedElement());
            try {
                select.SelectByIndex(index);
            } catch(Exception e) {
                Console.WriteLine("Unable to select the option :"+ e);
            }
        }

        public bool VerifyElement(string elementText)
        {
            SelectElement select = new SelectElement(GetWrappedElement());
            Boolean verifyDropdownStatus = false;
            IList<IWebElement> options = select.Options;
            foreach (IWebElement element in options) {
                if (element.Text.Equals(elementText)) {
                    verifyDropdownStatus = true;
                }
            }
            return verifyDropdownStatus;
        }

        public bool VerifyElements(string[] elements)
        {
            SelectElement select = new SelectElement(GetWrappedElement());
            Boolean verifyDropdownStatus = false;
            IList<IWebElement> options = select.Options;
            for (int i=0;i<elements.Length;i++)
            {
                if (element.Text.Equals(elements[i]))
                {
                    verifyDropdownStatus = true;
                }
            }
            return verifyDropdownStatus;
        }

        public bool VerifySelectedValueText(string expectedDefaultValue)
        {
            return GetSelectedValue().Equals(expectedDefaultValue, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
