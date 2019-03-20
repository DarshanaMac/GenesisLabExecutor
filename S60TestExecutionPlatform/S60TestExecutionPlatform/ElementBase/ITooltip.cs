using System;

namespace S60TestExecutionPlatform.ElementBase
{
    /**
    *
    * This Interface contains all the possible methods of tooltip HTML elements
    * 
    * @author darshana
    */
    public interface ITooltip : IElement
    {
        Boolean VerifyText(string text);
    }
}
