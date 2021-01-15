using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class ManagerPO
    {
        public static string managerUrl = @"https://staging.clark.de/de/app/manager";

        public static IWebElement JaButton => Hooks.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/div/button[1]/span"));
    }
}
