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
    public class ActivateBrandsStep : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        activateBrands actBrand = new activateBrands();
        activateBrands deactbrand = new activateBrands();

        [Given(@"brand is found in search")]
        public void GivenBrandIsFoundInSearch()
        {
            actBrand.brandFound();
        }
        
        [Then(@"i open it")]
        public void ThenIOpenIt()
        {
            actBrand.openBrand();
        }
        
        [Then(@"i click Activate button")]
        public void ThenIClickActivateButton()
        {
            actBrand.clickAtivateBrand();
        }
        
        [Then(@"i check that brand is activated in page")]
        public void ThenICheckThatBrandIsActivatedInPage()
        {
            actBrand.checkActivatedBrand();
        }
        
        [Then(@"i go back to check that brand is activated there")]
        public void ThenIGoBackToCheckThatBrandIsActivatedThere()
        {
            actBrand.goBackAndCheck();
        }
                                           

        [Given(@"i open brand page")]
        public void ThenIOpenBrandPage()
        {
            deactbrand.openFoundBrand();
        }

        [Given(@"i click deactivated button")]
        public void GivenIClickDeactivatedButton()
        {
            
            deactbrand.clickDeactivateButton();
        }

        [Then(@"i check that brad is deactivated in page")]
        public void ThenICheckThatBradIsDeactivatedInPage()
        {
            deactbrand.checkDeactivedBrandonPage();
        }

        [Then(@"i go back to check that brand is deactivated in list")]
        public void ThenIGoBackToCheckThatBrandIsDeactivatedInList()
        {
            deactbrand.goBackAndCheckAgain();
        }
    }
}
