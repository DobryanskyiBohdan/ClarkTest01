using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class PaymentDetailsPO
    {
        public static IWebElement ibanFields => Hooks.driver.FindElement(
            By.XPath("/html/body/div[3]/div/div/div/main/div[2]/div/div/form/div[1]/div/div/div[1]/input"));
        public static IWebElement checkbox => Hooks.driver.FindElement(
            By.XPath("/html/body/div[3]/div/div/div/main/div[2]/div/div/form/div[1]/div/label/span[1]/span/input"));
        public static IWebElement WeiterButton => Hooks.driver.FindElement(
            By.XPath("/html/body/div[3]/div/div/div/main/div[2]/div/div/form/div[2]/div[2]/button/span[2]"));
    }
}
