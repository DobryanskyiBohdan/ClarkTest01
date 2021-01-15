using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class LoginPO
    {
        public static IWebElement EmailField => Hooks.driver.FindElement(By.Id("ember149"));
        public static IWebElement PasswordField => Hooks.driver.FindElement(By.Id("ember150"));
        public static IWebElement RegisterButton => Hooks.driver.FindElement(By.Id("ember151"));

    }
}
