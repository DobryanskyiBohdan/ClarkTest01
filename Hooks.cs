using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace CLarkTest
{
    [Binding]
    public static class Hooks
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void TestSetup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito --start-maximized ");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario(Order = 1)]
        public static void TestCleanUp()
        {
            driver.Quit();
            driver.Dispose();
            driver = null;
        }
    }
}
