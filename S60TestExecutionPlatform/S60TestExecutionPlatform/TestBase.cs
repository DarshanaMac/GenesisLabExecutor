using OpenQA.Selenium;
using NUnit.Framework;
using System;
using Newtonsoft.Json;
using System.IO;
using RelevantCodes.ExtentReports;
using System.Reflection;
using System.Threading;
using System.Text.RegularExpressions;

namespace S60TestExecutionPlatform
{
    /**
    *
    * This is the base class for the every test case script. Every test script class must be inherited from this class.
    * 
    * 
    * @author Kanchana Liyanagamage
    */
    [SetUpFixture]
    public class TestBase
    {

        public IWebDriver driver;
        public dynamic Pages;
        public dynamic TestData;
        static string startupPath = System.IO.Directory.GetCurrentDirectory();
        static string[] lines = Regex.Split(startupPath, "S60TestExecutionPlatform");
        static string testproject = lines[1].Replace("\\bin\\Debug", "");
        static string testprojectname = testproject.Replace("\\", "");
        static ExtentReports extent = new RelevantCodes.ExtentReports.ExtentReports("C:\\TestSuite\\Report\\" + testprojectname + ".html", false);


        [SetUp]
        public void Intialize()
        {
            Console.WriteLine("Driver initializing");
            Driver.Initialize();
            Driver.Instance.Manage().Cookies.DeleteAllCookies();
            Pages = JsonConvert.DeserializeObject(File.ReadAllText("PageObjects\\Pages.json"));
            TestData = JsonConvert.DeserializeObject(File.ReadAllText("TestData\\TestData.json"));
            ExtentTest test = extent.StartTest(TestContext.CurrentContext.Test.Name);
            TestCase.testCaseName = test;
        }

        [TearDown]
        public void CleanUp()
        {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "");
            string xmlpath = startupPath + "\\S60TestExecutionPlatform\\S60TestExecutionPlatform\\Extent.xml";
            extent.LoadConfig(xmlpath);
            extent.Flush();
            Console.WriteLine("Driver closing");
            Driver.Close();
        }

    }
}
