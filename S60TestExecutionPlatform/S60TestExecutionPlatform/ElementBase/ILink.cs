using System;

namespace S60TestExecutionPlatform.ElementBase
{
    /**
    *
    * This Interface contains all the possible methods of Links HTML element<br/>
    * input type="button"
    * input type="submit
    * 
    * @author darshana
    * 
    */
    public interface ILink : IElement
    {       
            void ClickLink();

            Boolean IsDisabled();

           void MouserHover();
    }
}
