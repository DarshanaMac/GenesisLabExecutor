using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S60TestExecutionPlatform.ElementBase
{
    public interface IElementList : IElement
    {
        IList<IWebElement> GetElementList();

        void ClickElementListIndex(int index);

        int GetElementListItemsCount();

    }
}
