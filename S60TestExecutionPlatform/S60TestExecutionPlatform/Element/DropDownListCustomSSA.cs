using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using S60TestExecutionPlatform.ElementBase;
using System;
using System.Collections.Generic;
using System.Configuration;

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
    public class DropDownListCustomSSA : IDropDownList
    {
        protected readonly IWebElement element;
        protected IWebDriver driver;
        protected string identifier;
        protected string cssSelector;
        public DropDownListCustomSSA(IWebDriver driver, string identifier)
        {
            this.driver = driver;
            this.identifier = identifier;
            cssSelector = "span[id='" + identifier + "']";
            try
            {
                element = driver.FindElement(By.CssSelector(cssSelector));
               // WaitUntilElementExists(By.CssSelector(cssSelector), driver);
            }
            catch(Exception ee){
                String count = ConfigurationManager.AppSettings.Get("Retry");
                int retryCount = int.Parse(count);
                for (int i=1;i<= retryCount; i++) {
                    try {
                        element = driver.FindElement(By.CssSelector(cssSelector));
                        if (element.Displayed)
                        break;
                    } catch {
                        Console.WriteLine(ee);
                    }
                }
            }   
        }

        public static IWebElement WaitUntilElementExists(By elementLocator, IWebDriver driver, int timeout = 60)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementExists(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }

        public bool IsDisable()
        {
            return !element.Enabled;
        }

        public bool IsExist()
        {
            return element.Enabled;
        }

        public void SelectValue(string visibleText)
        {
            //string identifier = ".//*[@id='" + this.identifier + "']/../div/div[2]/div/div[@data-value='" + visibleText + "']";
            //string identifier = "select[id='"+ this.identifier + "'] option[value='"+visibleText+"']";
            string identifier = "span[id='"+this.identifier+"']+ul li[data-val='"+visibleText+"']";
            try
            {
                IWebElement dropDownOptions = driver.FindElement(By.CssSelector(identifier));
                dropDownOptions.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to select the option :" + e);
            }
        }  

        public bool VerifyElement(string element)
        {
            throw new NotImplementedException();
        }

        public bool VerifyElements(string[] elements)
        {
            throw new NotImplementedException();
        }

        public string GetSelectedValue()
        {
            throw new NotImplementedException();
        }
        public void Click()
        {
            element.Click();
        }

        void IDropDownList.SelectValue(string visibleText)
        {
            throw new NotImplementedException();
        }

        void IDropDownList.SelectValue(int index)
        {
            throw new NotImplementedException();
        }

        bool IDropDownList.IsDisable()
        {
            throw new NotImplementedException();
        }

        bool IDropDownList.VerifyElement(string element)
        {
            throw new NotImplementedException();
        }

        bool IDropDownList.VerifyElements(string[] elements)
        {
            throw new NotImplementedException();
        }

        string IDropDownList.GetSelectedValue()
        {
            throw new NotImplementedException();
        }

        bool IDropDownList.VerifySelectedValueText(string excpectedDefultValue)
        {
            throw new NotImplementedException();
        }

        int IDropDownList.GetSizeOfDropDownList()
        {
            throw new NotImplementedException();
        }
    }
}
