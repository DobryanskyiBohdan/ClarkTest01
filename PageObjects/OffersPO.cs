using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class OffersPO
    {
        public static IWebElement First => Hooks.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/main/section[1]/div/div/div[2]/div[1]/button/span"));
        public static IWebElement Second => Hooks.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/main/section[1]/div/div/div[2]/div[2]/button/span"));
        public static IWebElement Third => Hooks.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/main/section[1]/div/div/div[2]/div[3]/button/span"));
    }
}
