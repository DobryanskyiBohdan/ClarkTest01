using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class CategoriesPO
    {
        public static IWebElement Privathaftpflicht => Hooks.driver.FindElement(By.CssSelector("div._popular-card_a9hqa3:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1)"));

    }
}
