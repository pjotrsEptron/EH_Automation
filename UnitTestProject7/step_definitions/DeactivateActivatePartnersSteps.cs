using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]
    public class DeactivateActivatePartnersSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        deactivateActivatePartners onOffPartners = new deactivateActivatePartners();

        [Given(@"open Partners Details")]
        public void GivenOpenPartnersDetails()
        {
            onOffPartners.openCreatedPartner();

        }
        
        [Then(@"i press activate button in partners")]
        public void ThenIPressActivateButtonInPartners()
        {

            onOffPartners.pressActivateButton();

        }
        
        [Then(@"i press deactivate button in partners")]
        public void ThenIPressDeactivateButtonInPartners()
        {

            onOffPartners.pressDeactivateButtonForPartners();

        }
    }
}
