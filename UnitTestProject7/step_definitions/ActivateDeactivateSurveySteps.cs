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
    public class ActivateDeactivateSurveySteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();
        deactiveActivateSurveys onOffSurv = new deactiveActivateSurveys();

        [Given(@"i open any survye from a list")]
        public void GivenIOpenAnySurvyeFromAList()
        {
            onOffSurv.openSurveyAny();
        }
        
        [Then(@"i press activate button")]
        public void ThenIPressActivateButton()
        {
            onOffSurv.activateSurvey();
        }
        
        [Then(@"check that surcvey is activated")]
        public void ThenCheckThatSurcveyIsActivated()
        {
            onOffSurv.checkActiavteSurvey();
        }

        [Given(@"survey is activated")]
        public void GivenSurveyIsActivated()
        {
            onOffSurv.checkActiavteSurvey();
        }

        [Then(@"i click deactivate survey")]
        public void ThenIClickDeactivateSurvey()
        {
            onOffSurv.deactivateSurvey();
        }

        [Then(@"check thet survey is deactivated")]
        public void ThenCheckThetSurveyIsDeactivated()
        {
            onOffSurv.checkDeactiveSurvey();
        }
    }
}
