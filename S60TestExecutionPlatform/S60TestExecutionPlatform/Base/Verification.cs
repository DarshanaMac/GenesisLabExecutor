using NUnit.Framework;
using S60TestExecutionPlatform.Core;
namespace S60TestExecutionPlatform.Base
{
    /**
    *
    * This class contains the assertion results method STEP Framework. 
    * 
    * @author darshana
    * 
    */
    public static class Verification
    {
        public static void Pass(string messagePass)
        {
            Assert.True(true);
          
        }

        public static void Fail(string messageFail)
        {
            string testcasename = TestContext.CurrentContext.Test.Name;
            I.Screenshot(testcasename);
            Assert.Fail(messageFail);            
        }
    }
}
