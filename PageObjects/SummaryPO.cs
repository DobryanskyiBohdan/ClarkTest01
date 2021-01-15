using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class SummaryPO
    {
        public static IWebElement TelefonField=> Hooks.driver.FindElement(By.CssSelector("._summary_tz4ou4 > section:nth-child(3) > dl:nth-child(2) > dd:nth-child(14)"));
        public static IWebElement ZumAbschlussButton => Hooks.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/main/div[2]/div/div/div[4]/div[2]/button/span[2]"));
        
    }
}
