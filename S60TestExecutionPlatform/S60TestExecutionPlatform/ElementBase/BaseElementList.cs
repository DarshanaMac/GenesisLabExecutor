using OpenQA.Selenium;
using System;
using System.Drawing;
using OpenQA.Selenium.Interactions.Internal;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Configuration;
using S60TestExecutionPlatform.Base;
using OpenQA.Selenium.Support.UI;

namespace S60TestExecutionPlatform.ElementBase
{
    /**
    *
    * This class contains all the possible methods of web driver and HTML list elements
    * 
    * 
    * @author darshana
    */
    public class BaseElementList : IElement
    {
        protected readonly IList<IWebElement> elements;
        protected readonly IWebElement element;
        protected IWebDriver driver;

        public BaseElementList(IWebDriver driver, By identifier)
        {
            try
            {
                this.driver = driver;                
                element = WaitUntilElementExists(identifier, driver);
                elements = driver.FindElements(identifier);
            }
            catch (Exception ee)
            {
                String count = ConfigurationManager.AppSettings.Get("Retry");
                int retryCount = int.Parse(count);
                int statusCount = 0;
                int elementCount = 0;
                for (int i = 1; i <= retryCount; i++)
                {
                    try
                    {
                        try
                        {
                            elementCount = driver.FindElements(identifier).Count;
                            for (int z = 0; z <= elementCount; z++)
                            {
                                if (driver.FindElement(identifier).Displayed)
                                    statusCount++;
                                else
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        if (statusCount == elementCount)
                        {
                            try
                            {
                                elements = driver.FindElements(identifier);
                            }
                            catch(Exception exe) {
                                Verification.Fail(exe.ToString());
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Write(e);
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
            throw new NotImplementedException();
        }

        public void SendKeys(string text)
        {
            throw new NotImplementedException();
        }
        public void Submit()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            throw new NotImplementedException();
        }


        public void Click(int index)
        {
            elements[index].Click();
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public string TagName => throw new NotImplementedException();

        public string Text => throw new NotImplementedException();

        public bool Enabled => throw new NotImplementedException();

        public bool Selected => throw new NotImplementedException();

        public Point Location => throw new NotImplementedException();

        public Size Size => throw new NotImplementedException();

        public bool Displayed => throw new NotImplementedException();

        public Point LocationOnScreenOnceScrolledIntoView => throw new NotImplementedException();

        public ICoordinates Coordinates => throw new NotImplementedException();
    }

}
