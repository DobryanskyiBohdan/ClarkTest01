using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class QuestionnairePO
    {
        public static IWebElement WeiterButton => Hooks.driver.FindElement(By.CssSelector("span._content_dsfphm:nth-child(2)"));
        public static IWebElement CategoryName=> Hooks.driver.FindElement(By.CssSelector("._category_n83it3"));
        public static IWebElement MichAlleineAnswer => Hooks.driver.FindElement(By.CssSelector("li.questionnaire__answers__answer:nth-child(1) > h2:nth-child(2)"));
        public static IWebElement KeinerDerFalleTrifftAuchMichZuAnswer => Hooks.driver.FindElement(By.CssSelector("li.questionnaire__answers__answer:nth-child(3) > h2:nth-child(2)"));
        public static IWebElement ImFalleEinesSchadensSollMeineAnswer => Hooks.driver.FindElement(By.CssSelector("li.questionnaire__answers__answer:nth-child(2) > h2:nth-child(2)"));
        public static IWebElement CommentsInputField => Hooks.driver.FindElement(By.CssSelector(".form-list__item__input"));
        public static IWebElement AngebotAnfordenButton => Hooks.driver.FindElement(By.CssSelector("button.btn:nth-child(2)"));
        public static IWebElement ZumAngebotButton => Hooks.driver.FindElement(By.CssSelector("div._action_yje2cq:nth-child(1)"));

    }
}
