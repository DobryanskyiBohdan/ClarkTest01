using OpenQA.Selenium;

namespace CLarkTest.PageObjects
{
    public class ProfilePO
    {
        public static IWebElement HerrRadiobutton => Hooks.driver.FindElement(By.XPath("//input[@value='male']"));

        public static IWebElement VornameField => Hooks.driver.FindElement(
            By.XPath("//input[@name ='firstName']"));

        public static IWebElement NachNameField => Hooks.driver.FindElement(
            By.XPath("//input[@name ='lastName']"));

        public static IWebElement StraseField => Hooks.driver.FindElement(By.XPath(
            "//input[@name ='street']"));

        public static IWebElement HausnrField => Hooks.driver.FindElement(By.XPath(
            "//input[@name ='houseNumber']"));

        public static IWebElement PlzField => Hooks.driver.FindElement(By.XPath(
            "//input[@name ='zipcode']"));

        public static IWebElement OrtField => Hooks.driver.FindElement(By.XPath(
            "//input[@name ='city']"));

        public static IWebElement TelefonnummerField => Hooks.driver.FindElement(
            By.XPath("//input[@name ='phoneNumber']"));

        public static IWebElement GeburtsDatumField => Hooks.driver.FindElement(
            By.XPath("//input[@name ='birthdate']"));

        public static IWebElement WeiterButton =>
            Hooks.driver.FindElement(
                By.XPath("//span[text()='Weiter']"));

        
    }
}
