using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace S60TestExecutionPlatform
{
    /**
   * 
   *This class contains the Driver methods.
   *
   *Verify Page Title
   *Verify Element Value
   *Verify URLS
   *Verify Page
   *Verify Element Availability
   *
   *@author darshana
   *       
   */
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        string testcasename = TestContext.CurrentContext.Test.Name;

        public static string BaseAddress
        {
            get { return ConfigurationManager.AppSettings.Get("WebsiteUrl"); }
        }

        public static object TimeUnit { get; private set; }

        public static void Initialize()
        {
            InitializeBrowser();
            WaitForInitialLaunch();
        }

        public static void CleanUp()
        {
            Instance.Close();
        }
        public static void Close()
        {
            Instance.Quit();
        }

        public static void Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public static void WaitUnitReady()
        {
            Thread.Sleep(5000);
        }

        private static void InitializeBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get("Browser");
            string testcasename = TestContext.CurrentContext.Test.Name;
            if (browser.Equals("chrome"))
            {
                Instance = new ChromeDriver();
            }
            if (browser.Equals("firefox"))
            {
                Instance = new FirefoxDriver();
            }
            if (browser.Equals("cloud")) {
                /*  
                 N.B : We can not execute (AutoIT) scripts o browserstack
                 */
                DesiredCapabilities capability = new DesiredCapabilities();
                capability.SetCapability("os", "Windows");
                capability.SetCapability("os_version", "10");
                capability.SetCapability("browser", "Firefox");
                capability.SetCapability("browser_version", "58.0");
                capability.SetCapability("browserstack.local", "false");
                capability.SetCapability("browserstack.debug", "true");
                capability.SetCapability("project", "RR");
                capability.SetCapability("build", "RR_Smoke_3.0");
                capability.SetCapability("name", testcasename);
                capability.SetCapability("browserstack.user", "sot1");
                capability.SetCapability("browserstack.key", "qAk15AMswphzP9Q9UyJH");
                Instance = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability);


                //  DesiredCapabilities caps = new DesiredCapabilities();
                //  caps.SetCapability(CapabilityType.BrowserName, "Firefox");
                //  caps.SetCapability(CapabilityType.Version, "59.0");
                //  caps.SetCapability(CapabilityType.Platform, "Windows 7");
                //  //caps.SetCapability("deviceName", deviceName);
                ////  caps.SetCapability("deviceOrientation", deviceOrientation);
                //  caps.SetCapability("username", "Harsha1");
                //  caps.SetCapability("accessKey", "ae8c8624-36b9-4171-873d-c5cdb25a3a45");
                //  Instance = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com/wd/hub"), caps);
            }
        }

        private static void WaitForInitialLaunch()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}
