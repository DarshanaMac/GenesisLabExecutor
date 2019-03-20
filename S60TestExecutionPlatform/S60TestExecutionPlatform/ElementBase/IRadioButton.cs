using System;

namespace S60TestExecutionPlatform.ElementBase
{
    /**
    *
   * This Interface contains all the possible methods of radio button HTML element<br/>
   * input type="button"
   * input type="reset"
   * input type="submit
   * 
   * @author darshana
   * 
   */
    interface IRadioButton : IElement
    {
        void ClickButton();

        Boolean IsDisabled();
    }
}
