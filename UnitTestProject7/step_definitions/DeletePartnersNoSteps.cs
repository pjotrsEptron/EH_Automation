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
    public class DeletePartnersNoSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        deleteNewPartnerNO deletePartnersNo = new deleteNewPartnerNO();
        [Given(@"partner has been found by search")]
        public void GivenPartnerHasBeenFoundBySearch()
        {

            deletePartnersNo.openFoundPartner();

        }
        
        [Then(@"i click delette button to delete Partner")]
        public void ThenIClickDeletteButtonToDeletePartner()
        {

            deletePartnersNo.pressDeleteButtonInPartners();

        }
        
        [Then(@"i press NO to cancel delete partner")]
        public void ThenIPressNOToCancelDeletePartner()
        {

            deletePartnersNo.pressNOinDelete();

        }
    }
}
