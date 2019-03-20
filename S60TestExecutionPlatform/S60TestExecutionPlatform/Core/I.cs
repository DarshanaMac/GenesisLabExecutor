using OpenQA.Selenium;
using S60TestExecutionPlatform.Element;
using OpenQA.Selenium.Interactions;
using S60TestExecutionPlatform.Base;
using System;
using System.Collections.Generic;
using S60TestExecutionPlatform.Utility;
using OpenQA.Selenium.Support.Extensions;
using System.IO;
using NUnit.Framework;
using S60TestExecutionPlatform;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.Support.UI;

namespace S60TestExecutionPlatform.Core
{
    /**
    *
    * This class contians the method which be used to write tests scripts. 
    * 
    * @author darshana
    * 
    */

    public static class I
    {
        public static void Open(object pageUrl)
        {
            try
            {
                string PageUrl = pageUrl.ToString();
                Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + PageUrl);
                Driver.Instance.Manage().Window.Maximize();
                Driver.Wait(2);
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Open", pageUrl.ToString());
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Fail, "Unable navigate relevant URL", ee);
                // report with snapshot
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(RelevantCodes.ExtentReports.LogStatus.Info, img);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static List<string> GetDropDownListOptionList(object element)
        {
            try
            {
                string Element = element.ToString();
                DropDownListCustomRR dropDownListCustomRR = new DropDownListCustomRR(Driver.Instance, Element);
                List<String> list = dropDownListCustomRR.GetDropDownOptionList();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "GetDropDownListOptionList", "");
                return list;
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "GetDropDownListOptionList" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
                return null;
            }
        }

        public static void Fill(object element, object value)
        {
            try
            {
                string Element = element.ToString();
                string Value = value.ToString();
                if (Element.Contains("//")) {
                    TextField textField = new TextField(Driver.Instance, By.XPath(Element));
                    textField.ClearText();
                    textField.EnterText(Value);
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "Fill", "");
                }
                else {
                    TextField textField = new TextField(Driver.Instance, By.CssSelector(Element));
                    textField.ClearText();
                    textField.EnterText(Value);
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "Fill", "");
                }
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "Fill" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void Click(object element)
        {
            try
            {
                string Element = element.ToString();
                if (Element.Contains("//")) {
                    Button button = new Button(Driver.Instance, By.XPath(Element));
                    button.Click();
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "Click", "");
                }  
                else {
                    Button button = new Button(Driver.Instance, By.CssSelector(Element));
                    button.Click();
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "Click", "");
                }
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "Click" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void ClickDropDownList(object element)
        {
            try
            {
                string Element = element.ToString();
                DropDownListCustomRR dropDownListCustomRR = new DropDownListCustomRR(Driver.Instance, Element);
                dropDownListCustomRR.Click();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "ClickDropDownList", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ClickDropDownList" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void ClickDropDownListSSA(object element)
        {
            try
            {
                string Element = element.ToString();
                DropDownListCustomSSA dropDownListCustomSSA = new DropDownListCustomSSA(Driver.Instance, Element);
                dropDownListCustomSSA.Click();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "ClickDropDownList", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ClickDropDownList" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }
        
        public static void MouseOver(object identifier)
        {
            try
            {
                string Identifier = identifier.ToString();
                IWebElement element = Driver.Instance.FindElement(By.XPath(Identifier));
                Actions action = new Actions(Driver.Instance);
                action.MoveToElement(element).Perform();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "MouseOver", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "MouseOver" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void See(object element)
        {
            try
            {
                string Element = element.ToString();
                IWebElement webElement = Driver.Instance.FindElement(By.CssSelector(Element));
                Boolean verify = webElement.Displayed;
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "See", "");
                    Verification.Pass("TEST PASSED: Element does exist in the page.");
                }

                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "See" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Element does not exist in the page.");
                }

            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "See" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }

        }

        public static void SeeEnabled(object element)
        {
            try
            {
                string Element = element.ToString();
                IWebElement webElement = Driver.Instance.FindElement(By.CssSelector(Element));
                Boolean verify = webElement.Enabled;
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "See", "");
                    Verification.Pass("TEST PASSED: Element does exist in the page.");
                }

                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "See" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Element does not exist in the page.");
                }

            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "See" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }

        }

        public static void SeeInTitle(object title)
        {
            try
            {
                string expectedTitle = title.ToString();
                string actualTitle = Driver.Instance.Title;
                Boolean verify = expectedTitle.Equals(actualTitle);
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SeeInTitle", "");
                    Verification.Pass("TEST PASSED: Browser title is displayed correctly.");
                }

                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "SeeInTitle" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Browser title does not match correctly expected title");
                }

            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeInTitle" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void SeeLinkText(object linkElement, object linkText)
        {
            try
            {
                string LinkElement = linkElement.ToString();
                string LinkText = linkText.ToString();
                Link link = new Link(Driver.Instance, By.CssSelector(LinkElement));
                Boolean verify = link.VerifyText(LinkText);
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SeeLinkText", "");
                    Verification.Pass("TEST PASSED: Link text is displayed correctly.");
                }
                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "SeeLinkText" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Link text does not match correctly expected text");
                }
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeLinkText" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void DontSeeLinkText(object linkElement, object linkText)
        {
            try
            {
                string LinkElement = linkElement.ToString();
                string LinkText = linkText.ToString();
                Link link = new Link(Driver.Instance, By.CssSelector(LinkElement));
                Boolean verify = !link.VerifyText(LinkText);
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "DontSeeLinkText", "");
                    Verification.Pass("TEST PASSED: Link text is displayed correctly.");
                }
                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "DontSeeLinkText" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Link text does not match correctly expected text");
                }

            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "DontSeeLinkText" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void WaitUntilReady()
        {
            Driver.WaitUnitReady();
            ExtentTest test = TestCase.GetTestCaseName();
            test.Log(LogStatus.Pass, "WaitUntilReady", "");
        }

        public static void Wait(int seconds)
        {
            Driver.Wait(seconds);
            ExtentTest test = TestCase.GetTestCaseName();
            test.Log(LogStatus.Pass, "Wait", "");
        }

        public static void SeeText(object labelElement, object labelText)
        {
            try
            {
                string LabelElement = labelElement.ToString();
                string LabelText = labelText.ToString();
                Label label = new Label(Driver.Instance, By.CssSelector(LabelElement));
                Boolean verify = label.VerifyText(LabelText);
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SeeText", "");
                    Verification.Pass("TEST PASSED: Text is displayed correctly.");
                }
                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "SeeText" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Text does not match correctly expected text");
                }

            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeText" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }
        public static string GetAttibuteValue(object element, string attribute)
        {
            try
            {
                string Element = element.ToString();
                TextField textField = new TextField(Driver.Instance, By.CssSelector(Element));
                string valuetext = textField.GetAttribute(attribute);
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "GetAttibuteValue", "");
                return valuetext;
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "GetAttibuteValue" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
                return null;
            }
        }

        public static void SeeTextValue(object element, object text)
        {
            try
            {
                string Element = element.ToString();
                string Text = text.ToString();
                TextField textField = new TextField(Driver.Instance, By.CssSelector(Element));
                Boolean verify = textField.VerifyText(Text);
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SeeTextValue", "");
                    Verification.Pass("TEST PASSED: Value of the input field is displayed correctly.");
                }
                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "SeeTextValue" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Value of the input field does not match correctly expected text");
                }
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeTextValue" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void SeePartialText(object labelElement, object labelText)
        {
            try
            {
                string LabelElement = labelElement.ToString();
                string LabelText = labelText.ToString();
                Label label = new Label(Driver.Instance, By.CssSelector(LabelElement));
                Boolean verify = label.VerifyPartialText(LabelText);
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SeePartialText", "");
                    Verification.Pass("TEST PASSED: Text is displayed correctly.");
                }
                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "SeePartialText" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Text does not match correctly expected text");
                }

            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeePartialText" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void ClearText(object element)
        {
            try
            {
                string Element = element.ToString();
                TextField textField = new TextField(Driver.Instance, By.CssSelector(Element));
                textField.ClearText();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "ClearText", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeInTitle" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void SeeAttributeValue(object element, object attributeName, object expectedValue)
        {
            try
            {
                string Element = element.ToString();
                string AttributeName = attributeName.ToString();
                string ExpectedValue = expectedValue.ToString();
                IWebElement webElement = Driver.Instance.FindElement(By.CssSelector(Element));
                Boolean verify = webElement.GetAttribute(AttributeName).Equals(expectedValue);
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SeeAttributeValue", "");
                    Verification.Pass("TEST PASSED: Attribute value is displayed correctly.");
                }
                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "SeeAttributeValue" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Attribute value does not match correctly expected text");
                }

            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeAttributeValue" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void Check(object element)
        {
            try
            {
                string Element = element.ToString();
                Checkbox checkbox = new Checkbox(Driver.Instance, By.CssSelector(Element));
                checkbox.Toggle();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "Check", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "Check" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void SelectValueFromDropDownListRR(object element, object visibleText)
        {
            try
            {
                string Element = element.ToString();
                string VisibleText = visibleText.ToString();        
                    DropDownListCustomRR dropDownListCustomRR = new DropDownListCustomRR(Driver.Instance, Element);
                    dropDownListCustomRR.SelectValue(VisibleText);
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SelectValue", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SelectValue" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void SelectValue(object element, object visibleText) {
            try
            {
                string Element = element.ToString();
                string VisibleText = visibleText.ToString();
                if (Element.Contains("//"))
                {
                    SelectElement selectobj = new SelectElement(Driver.Instance.FindElement(By.XPath(Element)));
                    selectobj.SelectByValue(VisibleText);
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SelectValue", "");
                }
                else {
                    SelectElement selectobj = new SelectElement(Driver.Instance.FindElement(By.CssSelector(Element)));
                    selectobj.SelectByValue(VisibleText);
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SelectValue", "");
                }
                
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SelectValue" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }

        }

        public static void StandardSelect(object element, object visibleText)
        {
            try
            {
                string Element = element.ToString();
                string VisibleText = visibleText.ToString();
                if (Element.Contains("//"))
                {
                    SelectElement selectobj = new SelectElement(Driver.Instance.FindElement(By.XPath(Element)));
                    selectobj.SelectByText(VisibleText);
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SelectValue", "");
                }
                else
                {
                    SelectElement selectobj = new SelectElement(Driver.Instance.FindElement(By.CssSelector(Element)));
                    selectobj.SelectByValue(VisibleText);
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "SelectValue", "");
                }

            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SelectValue" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }

        }


        public static void SeeDropDownListForSFCC(object element) {
            try {
                string Element = element.ToString();
                DropDownListCustomSSA dropDownListCustomSSA = new DropDownListCustomSSA(Driver.Instance, Element);
               
                Boolean verify = dropDownListCustomSSA.IsExist();
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "See", "");
                    Verification.Pass("TEST PASSED: Element does exist in the page.");
                }

                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "See" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Element does not exist in the page.");
                }
            } catch (Exception ee) {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "See" + test.AddScreenCapture(ReturnScreenShotName()));
                Verification.Fail("TEST FAILED: Element does not exist in the page."+ ee.ToString());
            }
        }

        public static void SelectValueFromDropDownListSSA(object element, object visibleText)
        {
            try
            {
                string Element = element.ToString();
                string VisibleText = visibleText.ToString();
                DropDownListCustomSSA dropDownListCustomSSA = new DropDownListCustomSSA(Driver.Instance, Element);
                dropDownListCustomSSA.SelectValue(VisibleText);
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "SelectValue", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SelectValue" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void VerifyURLs()
        {
            try
            {
                int invalidLinksCount = 0;
                IList<IWebElement> anchorTagList = Driver.Instance.FindElements(By.TagName("a"));
                foreach (IWebElement anchorTagElement in anchorTagList)
                {
                    if (anchorTagElement != null)
                    {
                        String url = anchorTagElement.GetAttribute("href");
                        if (url != null && !url.Contains("javascript"))
                        {
                        }
                    }
                }
                if (anchorTagList.Count == 0)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "VerifyURLs", "");
                    Verification.Pass("TEST PASSED: The page does not contains any links");
                }
                else if (invalidLinksCount > 0)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "VerifyURLs", "");
                    Verification.Fail("TEST PASSED: Total number of links are " + anchorTagList.Count + ".Number of broken links are " + invalidLinksCount + ".");
                }
                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "VerifyURLs", "");
                    Verification.Pass("TEST PASSED: All links are correctly written.");
                }
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "VerifyURLs" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void AmOn(object pageUrl)
        {
            try
            {
                string PageUrl = pageUrl.ToString();
                string actualUrl = Driver.Instance.Url;
                Boolean verify = actualUrl.Contains(PageUrl);
                if (verify)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    test.Log(LogStatus.Pass, "AmOn", "");
                    Verification.Pass("TEST PASSED: Page is displayed correctly.");
                }
                else
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "AmOn" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("TEST FAILED: Page does not match correctly expected title");
                }

            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "AmOn" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void ClickRadioButton(object element)
        {
            try
            {
                string Element = element.ToString();
                RadioButton button = new RadioButton(Driver.Instance, By.CssSelector(Element));
                button.Click();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "ClickRadioButton", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ClickRadioButton" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static Boolean SeeExist(object element)
        {
            Boolean verify = false;
            try
            {
                string Element = element.ToString();
                IWebElement webElement = Driver.Instance.FindElement(By.CssSelector(Element));
                verify = webElement.Displayed;
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "SeeExist", "");
                return verify;
            }
            catch (NoSuchElementException ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeExist" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                ee.ToString();
                Verification.Fail("TEST FAILED: " + ee.ToString());
                return verify;
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeExist" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
                return false;
            }
        }

        public static Boolean SeeTextExist(object labelElement, object labelText)
        {
            try
            {
                string LabelElement = labelElement.ToString();
                string LabelText = labelText.ToString();
                Label label = new Label(Driver.Instance, By.CssSelector(LabelElement));
                Boolean verify = label.VerifyText(LabelText);
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "SeeTextExist", "");
                return verify;
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeTextExist" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
                return false;
            }
        }

        public static void ClickOnElementList(object element, int index)
        {
            try
            {
                string Element = element.ToString();
                ElementList elementList = new ElementList(Driver.Instance, By.CssSelector(Element));
                I.WaitUntilReady();
                elementList.Click(index);
                I.WaitUntilReady();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "ClickOnElementList", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ClickOnElementList" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void SeeItemExistOnElementList(object element, string text, int index)
        {
            try
            {
                string Element = element.ToString();
                Boolean verify = false;
                ElementList elementList = new ElementList(Driver.Instance, By.CssSelector(Element));
                for (int i = 0; i < elementList.GetElementListItemsCount(); i++)
                {
                    if (elementList.GetElementText(index).Contains(text))
                    {
                        verify = true;
                        ExtentTest test = TestCase.GetTestCaseName();
                        test.Log(LogStatus.Pass, "SeeItemExistOnElementList", "");
                        Verification.Pass("Element does exist in the list");
                        break;
                    }
                }
                if (verify == false)
                {
                    ExtentTest test = TestCase.GetTestCaseName();
                    String img = test.AddScreenCapture(ReturnScreenShotName());
                    test.Log(LogStatus.Fail, "SeeItemExistOnElementList" + test.AddScreenCapture(ReturnScreenShotName()));
                    Verification.Fail("Element does not exist in the list");
                }
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SeeItemExistOnElementList" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void ClickTab(object element)
        {
            try
            {
                string Element = element.ToString();
                IWebElement webElement = Driver.Instance.FindElement(By.CssSelector(Element));
                webElement.SendKeys(Keys.Tab);
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "ClickTab", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ClickTab" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static int GetElementCount(object element)
        {
            try
            {
                string Element = element.ToString();
                ElementList elementList = new ElementList(Driver.Instance, By.CssSelector(Element));
                int count = elementList.GetElementListItemsCount();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "GetElementCount", "");
                return count;
            }
            catch (NoSuchElementException ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "GetElementCount" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
                return 0;
            }
        }

        public static string RememberText(object element)
        {
            try
            {
                string Element = element.ToString();
                IWebElement webElement = Driver.Instance.FindElement(By.CssSelector(Element));
                String actualText = webElement.Text;
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "RememberText", "");
                return actualText;
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "RememberText" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
                return null;
            }
        }

        public static string GetTextByIndex(object element, int index)
        {
            try
            {
                string Element = element.ToString();
                ElementList elementList = new ElementList(Driver.Instance, By.CssSelector(Element));
                string value = elementList.GetElementText(index);
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "GetTextByIndex", "");
                return value;
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "GetTextByIndex" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
                return null;
            }
        }

        public static void ClickKeyBoardEvent(object element, String KeyType)
        {
            ExtentTest test = TestCase.GetTestCaseName();
            try
            {
                string Element = element.ToString();
                IWebElement webElement = Driver.Instance.FindElement(By.CssSelector(Element));

                switch (KeyType)
                {
                    case "UP":
                        webElement.SendKeys(Keys.Up);

                        test.Log(LogStatus.Pass, "UP", "");
                        break;
                    case "ENTER":
                        webElement.SendKeys(Keys.Enter);
                        test.Log(LogStatus.Pass, "Enter", "");
                        break;
                    case "DOWN":
                        webElement.SendKeys(Keys.Down);
                        test.Log(LogStatus.Pass, "Down", "");
                        break;
                    case "TAB":
                        webElement.SendKeys(Keys.Tab);
                        test.Log(LogStatus.Pass, "Tab", "");
                        break;
                    case "LEFTARROW":
                        webElement.SendKeys(Keys.ArrowLeft);
                        test.Log(LogStatus.Pass, "Left", "");
                        break;
                    case "RIGHTARROW":
                        webElement.SendKeys(Keys.ArrowRight);
                        test.Log(LogStatus.Pass, "Right", "");
                        break;
                    default:
                        test.Log(LogStatus.Warning, "Unable to Execute KeyBoard Event !", "");
                        Console.WriteLine("Unable to Execute KeyBoard Event !");
                        break;
                }
            }
            catch (Exception ee)
            {
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ClickKeyBoardEvent" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void ClickMenuItemByIndex(object mainMenuItemIndexList, int index)
        {
            try
            {
                string MainMenuItemIndexList = mainMenuItemIndexList.ToString();
                IList<IWebElement> webElements = Driver.Instance.FindElements(By.CssSelector(MainMenuItemIndexList));
                webElements[index].Click();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "ClickMenuItemByIndex", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ClickMenuItemByIndex" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void MouseHoverToMenuItemByIndex(object mainMenuItemList, int index)
        {
            try
            {
                string MainMenuItemList = mainMenuItemList.ToString();
                IList<IWebElement> webElements = Driver.Instance.FindElements(By.CssSelector(MainMenuItemList));
                IWebElement webElement = webElements[index];
                Actions action = new Actions(Driver.Instance);
                action.MoveToElement(webElement).Perform();
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "MouseHoverToMenuItemByIndex", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "MouseHoverToMenuItemByIndex" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void ClickMenuItemByDisplayText(object mainMenuItemList, object menuItemText)
        {
            try
            {
                string MainMenuItemList = mainMenuItemList.ToString();
                string DisplayText = menuItemText.ToString();
                IList<IWebElement> webElements = Driver.Instance.FindElements(By.CssSelector(MainMenuItemList));
                foreach (IWebElement element in webElements)
                {
                    if (Helper.CaseContains(element.Text, DisplayText, StringComparison.CurrentCultureIgnoreCase))
                    {
                        element.Click();
                        ExtentTest test = TestCase.GetTestCaseName();
                        test.Log(LogStatus.Pass, "ClickMenuItemByDisplayText", "");
                        break;
                    }
                }
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ClickMenuItemByDisplayText" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void MouseHoverMenuItemByDisplayText(object mainMenuItemList, object menuItemText)
        {
            try
            {
                string MainMenuItemList = mainMenuItemList.ToString();
                string DisplayText = menuItemText.ToString();
                IList<IWebElement> webElements = Driver.Instance.FindElements(By.CssSelector(MainMenuItemList));
                foreach (IWebElement element in webElements)
                {
                    if (Helper.CaseContains(element.Text, DisplayText, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Actions action = new Actions(Driver.Instance);
                        action.MoveToElement(element).Perform();
                        ExtentTest test = TestCase.GetTestCaseName();
                        test.Log(LogStatus.Pass, "MouseHoverMenuItemByDisplayText", "");
                        break;
                    }
                }
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "MouseHoverMenuItemByDisplayText" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void SwitchToFrame(object frameName, string idenfierType)
        {
            try
            {
                string FrameName = frameName.ToString();
                if (idenfierType.Contains("name"))
                {
                    Driver.Instance.SwitchTo().Frame(FrameName);
                }
                else if (idenfierType.Contains("id"))
                {
                    IWebElement iframe = Driver.Instance.FindElement(By.CssSelector(FrameName));
                    Driver.Instance.SwitchTo().Frame(iframe);
                }
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "SwitchToFrame", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "SwitchToFrame" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void ExecuteJavaScriptOnBrowser(String javascriptline)
        {
            try
            {
                IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.Instance;
                jse.ExecuteScript(javascriptline, "");
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "ExecuteJavaScriptOnBrowser", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ExecuteJavaScriptOnBrowser" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void RefreshPage()
        {
            Driver.Instance.Navigate().Refresh();
            ExtentTest test = TestCase.GetTestCaseName();
            test.Log(LogStatus.Pass, "RefreshPage", "");
        }

        public static void Screenshot(string testcasename)
        {
            const string BaseDirectory = @"C:\TestSuite\Report\";
            if (System.IO.Directory.Exists(BaseDirectory))
            {
                System.IO.Directory.CreateDirectory(BaseDirectory + "Screenshot");
                string DirectoryName = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                const string SecondaryPath = @"C:\TestSuite\Report\Screenshot\";
                System.IO.Directory.CreateDirectory(SecondaryPath + DirectoryName);
                string path = SecondaryPath + DirectoryName + "\\";
                Driver.Instance.TakeScreenshot().SaveAsFile(path + testcasename + ".png", ScreenshotImageFormat.Png);
            }
        }

        public static string ReturnScreenShotName()
        {
            const string BaseDirectory = @"C:\TestSuite\Report\";
            string sceenshotname = "Null";
            string testcasename = TestContext.CurrentContext.Test.Name;
            if (System.IO.Directory.Exists(BaseDirectory))
            {
                System.IO.Directory.CreateDirectory(BaseDirectory + "Screenshot");
                string DirectoryName = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                const string SecondaryPath = @"C:\TestSuite\Report\Screenshot\";
                System.IO.Directory.CreateDirectory(SecondaryPath + DirectoryName);
                string path = SecondaryPath + DirectoryName + "\\";
                sceenshotname = path + testcasename + ".png";
            }
            return sceenshotname;
        }

        public static void PrintSuccessMessage(string message)
        {
            ExtentTest test = TestCase.GetTestCaseName();
            test.Log(LogStatus.Pass, "PrintSuccessMessage", "");
            Verification.Pass(message);
        }

        public static void PrintFailureMessage(string message)
        {
            ExtentTest test = TestCase.GetTestCaseName();
            test.Log(LogStatus.Fail, "PrintFailureMessage", "");
            Verification.Fail(message);
        }

        public static void ScrollBrowser(string startPoint, string endPoint)
        {
            try
            {
                IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.Instance;
                jse.ExecuteScript("window.scrollBy(" + startPoint + "," + endPoint + ")", "");
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Pass, "ScrollBrowser", "");
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(LogStatus.Fail, "ScrollBrowser" + test.AddScreenCapture(ReturnScreenShotName()), ee);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static void SwitchToMainWindow()
        {
            Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles[0]);
        }

        public static void NavigateToPage(object pageurl,string baseurl) {
            try
            {
                string PageUrl = pageurl.ToString();
                if (baseurl.Contains("Yes"))
                {
                    Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + PageUrl);
                }
                else {
                    Driver.Instance.Navigate().GoToUrl(PageUrl);
                }
                    
                Driver.Wait(2);
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Open", pageurl.ToString());
            }
            catch (Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Fail, "Unable navigate relevant URL", ee);
                // report with snapshot
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(RelevantCodes.ExtentReports.LogStatus.Info, img);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }
        }

        public static string GetAttributeText(object element) {

            string Element = element.ToString();
            string elementtext =null;
            if (Element.Contains("//"))
            {
                 elementtext = Driver.Instance.FindElement(By.XPath(Element)).Text;
            }
            else {
                elementtext = Driver.Instance.FindElement(By.CssSelector(Element)).Text;
            }
           
            return elementtext;
        }

        public static Boolean PrecenceOfElement(object element) {
            Boolean verify = false;
            try
            {
                string Element = element.ToString();
                IWebElement webElement = Driver.Instance.FindElement(By.CssSelector(Element));
                verify = webElement.Displayed;
                return verify;
            }
            catch (NoSuchElementException ee)
            {
                return verify;
            }
            catch (Exception ee)
            {
                return false;
            }
        }

        public static void AcceptJavascriptPopup() {
            try
            {
                Driver.Instance.SwitchTo().Alert().Accept();
            }
            catch(Exception ee)
            {
                ExtentTest test = TestCase.GetTestCaseName();
                test.Log(LogStatus.Fail, "Unable to execute javascript accept command", ee);
                // report with snapshot
                String img = test.AddScreenCapture(ReturnScreenShotName());
                test.Log(RelevantCodes.ExtentReports.LogStatus.Info, img);
                Verification.Fail("TEST FAILED: " + ee.ToString());
            }      
        }
    }
}
