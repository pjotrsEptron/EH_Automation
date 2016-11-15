using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]
    public class employeeList : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();


        [When(@"i click employee menu")]
        public void WhenIClickEmployeeMenu()
        {


           find(By.XPath("//ul[@id='side-menu']/li[5]/a/span")).Click();
        }

        [Then(@"i see all employee list")]
        public void ThenISeeAllEmployeeList()
        {
            Assert.IsTrue(IsElementPresent(By.CssSelector("h5.ng-binding")));
            Thread.Sleep(5000);
        }

        private bool IsElementPresent(By by)
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

        private bool IsAlertPresent()
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
