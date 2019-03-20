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
    public class DropDownListCustomRR : IDropDownList
    {
        protected readonly IWebElement element;
        protected IWebDriver driver;
        protected string identifier;
        protected string cssSelector;
        public DropDownListCustomRR(IWebDriver driver, string identifier)
        {
            this.driver = driver;
            this.identifier = identifier;
            cssSelector = "select[id='" + identifier + "'] + div";
            try
            {
                element = driver.FindElement(By.CssSelector(cssSelector));
             //   WaitUntilElementExists(By.CssSelector(cssSelector), driver);
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

        public bool IsExist() {
            return element.Enabled;
        }

        public bool IsDisable()
        {
            return !element.Enabled;
        }

        public void SelectValue(string visibleText)
        {
            string identifier = ".//*[@id='" + this.identifier + "']/../div/div[2]/div/div[@data-value='" + visibleText + "']";
            try
            {
                IWebElement titleDropDownOptions = driver.FindElement(By.XPath(identifier));
                titleDropDownOptions.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to select the option :" + e);
            }
        }

        public void SelectValue(int index)
        {
            string identifier = ".//*[@id='" + this.identifier + "']/../div/div[2]/div/div[" + index + "]";
            try
            {
                IWebElement titleDropDownOptions = driver.FindElement(By.XPath(identifier));
                titleDropDownOptions.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to select the option :" + e);
            }
        }

        public bool VerifySelectedValueText(string expectedDefaultValue)
        {
            return GetSelectedValue().Equals(expectedDefaultValue, StringComparison.InvariantCultureIgnoreCase);
        }

        public int GetSizeOfDropDownList()
        {
            throw new NotImplementedException();
        }

        public List<String> GetDropDownOptionList()
        {
            List<String> dropDownOptionList = new List<string>();
            string identifier = ".//*[@id='" + this.identifier + "']/../div/div[2]/div/div";
            IList<IWebElement> dropDownList = new List<IWebElement>();
            try
            {
                dropDownList = driver.FindElements(By.XPath(identifier));
                foreach (IWebElement webElement in dropDownList)
                {
                    dropDownOptionList.Add(webElement.GetAttribute("data-value"));
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            return dropDownOptionList;
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

    }
}
