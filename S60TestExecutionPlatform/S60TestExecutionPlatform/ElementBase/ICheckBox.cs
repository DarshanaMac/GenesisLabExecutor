using System;

namespace S60TestExecutionPlatform.ElementBase
{
    /**
    *
    * This Interface contains all the possible methods of check box HTML element
    * 
    * input type = "checkbox"
    * 
    * @author darshana
    */
    public interface ICheckBox : IElement
    {
        void Toggle();

        void Check();

        void Uncheck();

        Boolean IsChecked();

        Boolean IsDisabled();
    }
}
