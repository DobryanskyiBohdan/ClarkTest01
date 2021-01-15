using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class AwesomePO
    {
        public static IWebElement ZurVertagsubersichtButton => Hooks.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/main/div[2]/div/div[1]/a/span"));
    }
}
