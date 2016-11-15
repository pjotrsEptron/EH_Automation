using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Timers;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]
    public class DeactivateSalonSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();
        [Given(@"lists of salons")]
        public void GivenListsOfSalons()
        {

            deactivateSalon openSalonFromlist = new deactivateSalon();
            openSalonFromlist.openSalon();

        }
        
        [When(@"i open salon detaiils")]
        public void WhenIOpenSalonDetaiils()
        {

            // validation that salon deatils is visible
            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/ul/li/a/tab-heading/span"));
        }

        [Then(@"i can deactivate it")]
        public void ThenICanDeactivateIt()
        {

            deactivateSalon clickDeactivateButton = new deactivateSalon();
            clickDeactivateButton.clickDeactivate();

        }

        [Then(@"activate it")]
        public void ThenActivateIt()
        {
            deactivateSalon clickActivateButton = new deactivateSalon();
            clickActivateButton.clickActivate();
            Thread.Sleep(3000);
        

        }
    }
}
