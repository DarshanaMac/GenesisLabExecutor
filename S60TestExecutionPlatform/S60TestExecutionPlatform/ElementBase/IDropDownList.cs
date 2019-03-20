
using System;

namespace S60TestExecutionPlatform.ElementBase
{
    /**
 *
 * This Interface contains all the possible methods of Dropdown list HTML element
 * 
 * @author darshana
 */
    public interface IDropDownList
    {
        void SelectValue(string visibleText);

        void SelectValue(int index);

        Boolean IsDisable();

        Boolean VerifyElement(string element);

        Boolean VerifyElements(string[] elements);

        string GetSelectedValue();

        Boolean VerifySelectedValueText(string excpectedDefultValue);

        int GetSizeOfDropDownList();
    }
}
