using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S60TestExecutionPlatform.Utility
{
    public static class Helper
    {
        public static string GetUniqueRandomString()
        {
            Guid g = Guid.NewGuid();
            string GuidString = Convert.ToBase64String(g.ToByteArray());
            GuidString = GuidString.Replace("=", "");
            GuidString = GuidString.Replace("+", "");
            return GuidString;
        }

        public static long GetUniqueNumericValue() {
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            return milliseconds;
        }

        public static long GetUniqueNumericValueTest()
        {
            long milliseconds = DateTimeOffset.Now.ToUnixTimeSeconds();
            return milliseconds;
        }

        public static bool CaseContains(string baseString, string textToSearch, StringComparison comparisonMode)
        {
            return (baseString.IndexOf(textToSearch, comparisonMode) != -1);
        }
    }
}


