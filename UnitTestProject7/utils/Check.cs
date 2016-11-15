using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts.utils
{
    class Check
    {
        private static IWebDriver driver = Driver.getDriver();

        public static void presence(By by)
        {
            Assert.IsTrue(IsElementPresent(by));
        }

        private static bool IsElementPresent(By by)
        {
            try
            {
                find(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private static bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
    }
}
