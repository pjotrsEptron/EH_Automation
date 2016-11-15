using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts.pages
{
    public class checkSwitcher : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        By settingsLink = By.LinkText("Settings");
        By companiesLInk = By.LinkText("Companies");
        By sixthpage = By.LinkText("6");
        By switcherButton = By.XPath("//tr[10]/td[7]/div/button");


   
        [Given(@"im logged in cms")]
        public void GivenImLoggedInCms()
        {

          find(settingsLink);
            

        }
        [Given(@"menu is visible on the left")]
        public void GivenMenuIsVisibleOnTheLeft()
        {
          find(settingsLink);

        }
        [When(@"switch to compay")]
        public void WhenSwitchToCompay()
        {

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
          find(settingsLink).Click();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
          find(companiesLInk).Click();


            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
          find(sixthpage).Click();


            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
          find(switcherButton).Click();

        }
       [Then(@"the company info is visible")]
        public void ThenTheCompanyInfoIsVisible()
        {
          find(By.LinkText("Company"));
        }
    }
}
