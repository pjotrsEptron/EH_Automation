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
    public class ResellerSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        addReseller resellerPage = new addReseller();

        [Given(@"i have resellers page opened")]
        public void GivenIHaveResellersPageOpened()
        {

            resellerPage.openResellerPage();

        }
        
        [Given(@"i can add new reseller")]
        public void GivenICanAddNewReseller()
        {
            resellerPage.addNewReseller();
            resellerPage.pressSaveButtonReseller();
        }
        
        [Then(@"i can check resseler in search")]
        public void ThenICanCheckResselerInSearch()
        {

            resellerPage.checkResellerCreated();

        }
    }
}
