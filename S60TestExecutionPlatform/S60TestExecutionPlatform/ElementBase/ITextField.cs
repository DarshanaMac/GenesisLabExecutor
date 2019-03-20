using System;

namespace S60TestExecutionPlatform.ElementBase
{
    /**
     *
     * This Interface contains all the possible methods of text feilds
     * 
     * Text field
     * Number field
     * Password field
     * Search field
     * HTML elements
     * 
     * @author darshana
     */
    public interface ITextField: IElement
    {
        void EnterText(string text);

        void ClearText();

        String GetTextValue();

        Boolean VerifyText(string text);

    }
}
