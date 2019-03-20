using OpenQA.Selenium;
using System;
using System.Drawing;
using OpenQA.Selenium.Interactions.Internal;
using System.Collections.ObjectModel;
using S60TestExecutionPlatform.Base;
using System.Configuration;
using OpenQA.Selenium.Support.UI;

namespace S60TestExecutionPlatform.ElementBase
{
    /**
    *
    * This class contains all the possible methods of web driver and HTML elements
    * 
    * Clear()
    * Click()
    * FindElement(By elementLocation)FindElements(By elementList)
    * GetAttribute(String arg)
    * GetProperty(String arg)
    * GetCssValue(String arg)
    * Location
    * Size
    * TagName
    * Text
    * Displayed
    * Enabled
    * Selected
    * SendKeys(String text)
    * Submit()
    * 
    * @author darshana
    */
    public class BaseElement : IElement
    {
        protected readonly IWebElement element;
        protected IWebDriver driver;

        public BaseElement(IWebDriver driver, By identifier)
        {
            try
            {
                this.driver = driver;
               // element = driver.FindElement(identifier);
               element = WaitUntilElementExists(identifier, driver);
            }
            catch (Exception ee)
            {
                String count =ConfigurationManager.AppSettings.Get("Retry");
                int retryCount = int.Parse(count);
                for (int i=1;i<=retryCount; i++) {
                    try
                    {
                        element = driver.FindElement(identifier);
                        if (element.Displayed)
                        break;
                    }
                    catch (Exception e){
                        Console.WriteLine(e);
                    } 
                }
                Verification.Fail(ee.ToString());
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

        public void Clear()
        {
            element.Clear();
        }

        public void SendKeys(string text)
        {
            element.SendKeys(text);
        }
        public void Submit()
        {
            element.Submit();
        }

        public void Click()
        {
            element.Click();
        }

        public string GetAttribute(string arg)
        {
            return element.GetAttribute(arg);
        }

        public string GetCssValue(string arg)
        {
            return element.GetCssValue(arg);
        }

        public string GetProperty(string arg)
        {
            return element.GetProperty(arg);
        }

        public IWebElement FindElement(By elementLocation)
        {
            return driver.FindElement(elementLocation);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By elementList)
        {
            return driver.FindElements(elementList);
        }

        public string TagName
        {
            get
            {
                return element.TagName;
            }
        }

        public string Text
        {
            get
            {
                return element.Text;
            }
        }

        public Boolean Enabled
        {
            get
            {
                return element.Enabled;
            }
        }

        public Boolean Selected
        {
            get
            {
                return element.Selected;
            }
        }

        public Point Location => element.Location;

        public Size Size
        {
            get
            {
                return element.Size;
            }
        }

        public bool Displayed {
            get {
                return element.Displayed;
            }
        }

        public IWebElement GetWrappedElement()
        {
            return element;
        }

        public void ClickTab() {
            element.SendKeys(Keys.Tab);
        }

        public Point LocationOnScreenOnceScrolledIntoView => throw new NotImplementedException();

        public ICoordinates Coordinates { get => throw new NotImplementedException(); }
    }
}
