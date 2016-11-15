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
    public class AddPartnersSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        AddPartners newPartner = new AddPartners();

        [Given(@"i have opened pArtners page")]
        public void GivenIHaveOpenedPArtnersPage()
        {

            newPartner.openPartnersPage();
            
        }
        
        [Given(@"i can add new partner")]
        public void GivenICanAddNewPartner()
        {

            newPartner.addNewParter();
            //newPartner.pressSaveBUtton();

        }
        
        [Then(@"i can check if partner is created")]
        public void ThenICanCheckIfPartnerIsCreated()
        {

            newPartner.checkNewPartnerCreated();

        }
    }
}
