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
    public class DeletePartnersYesSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        deleteNewPartnerYES deletePartnersYes = new deleteNewPartnerYES();
        [Given(@"i see previous partner")]
        public void GivenISeePreviousPartner()
        {

            //Check.presence(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[3]/div[2]/div/button[4]"));
        }
        
        [Then(@"i press delete button again")]
        public void ThenIPressDeleteButtonAgain()
        {

            deletePartnersYes.pressDeleteButtonINPartners();

        }

        [Then(@"i press YES to delete partner")]
        public void ThenIPressYESToDeletePartner()
        {

            deletePartnersYes.pressYESinDelete();
        }
        
        [Then(@"i can check if deleted")]
        public void ThenICanCheckIfDeleted()
        {

            deletePartnersYes.checkThatPartnerIsDeleted();

        }
    }
}
