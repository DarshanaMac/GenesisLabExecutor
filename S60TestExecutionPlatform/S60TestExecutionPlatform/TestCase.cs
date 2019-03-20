using RelevantCodes.ExtentReports;

namespace S60TestExecutionPlatform
{
    public static class TestCase
    {
        public static ExtentTest testCaseName;

        public static ExtentTest GetTestCaseName() {
            return testCaseName;
        }
    }
}
