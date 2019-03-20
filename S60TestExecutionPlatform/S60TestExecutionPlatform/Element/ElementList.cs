using S60TestExecutionPlatform.ElementBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace S60TestExecutionPlatform.Element
{
    public class ElementList : BaseElementList, IElementList
    {
        public ElementList(IWebDriver driver, By identifier) : base(driver, identifier)
        {

        }
        void IElementList.ClickElementListIndex(int index)
        {
            elements[index].Click();
        }

        public string GetElementText(int index)
        {
            return elements[index].Text;
        }

        IList<IWebElement> IElementList.GetElementList()
        {
            return elements;
        }

        public int GetElementListItemsCount()
        {
            return elements.Count;
        }
    }
}
