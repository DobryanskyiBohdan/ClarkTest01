using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class ContractsPO
    {
        public static IWebElement AngeboteElement => Hooks.driver.FindElement(By.CssSelector(".page-navigation__link--offers"));

        public static IWebElement cookiesAcceptButton => Hooks.driver.FindElement(By.ClassName("btn-primary"));

        public static void GoToUrl(string url)
        {
            string protocol = "https://";
            string fullUrl = protocol + url;
            Hooks.driver.Navigate().GoToUrl(fullUrl);
        }
        
    }

}
