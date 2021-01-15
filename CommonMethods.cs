using System;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace CLarkTest
{
    public class CommonMethods
    {
        public static bool WaitForCondition(Func<bool> condition, TimeSpan? timeout = null)
        {
            var wait = new WebDriverWait(Hooks.driver, timeout ?? TimeSpan.FromMinutes(1));
            return wait.Until(d =>
            {
                try
                {
                    Thread.Sleep(750);
                    //Thread.Sleep(200);
                    return condition();
                }
                catch (TimeoutException e)
                {
                    Trace.WriteLine("Condition was not met in a given timeframe. Exceptiom message: " + e.Message);
                    return false;
                }
            });
            
        }

        public static bool ElementPresent(IWebElement el)
        {
            try
            {
                Assert.IsTrue(el.Enabled & el.Displayed);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void MouseClick(IWebElement elementForClick)
        {
            var build = new Actions(Hooks.driver);
            var elForClick = build.MoveToElement(elementForClick);
            elForClick.Click().Build().Perform();

        }

    }
}
