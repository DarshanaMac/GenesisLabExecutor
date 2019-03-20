using System;

namespace S60TestExecutionPlatform.ElementBase
{
    /**
     *
    * This Interface contains all the possible methods of button HTML element<br/>
    * input type="button"
    * input type="reset"
    * input type="submit
    * 
    * @author darshana
    * 
    */
    public interface IButton : IElement
    {
        void ClickButton();

        Boolean IsDisabled();

        void MouserHover();

    }
}
