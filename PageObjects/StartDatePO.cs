using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class StartDatePO
    {
        public static IWebElement WeiterButton => Hooks.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/main/div[2]/div/div/form/div[2]/div[2]/button/span[2]"));
        public static IWebElement NachsterWerktagRadiobutton => Hooks.driver.FindElement(By.XPath("//input[@name ='next-working-day']"));
        public static IWebElement NeinRadiobutton => Hooks.driver.FindElement(By.XPath("//input[@name ='false']"));

    }
}
