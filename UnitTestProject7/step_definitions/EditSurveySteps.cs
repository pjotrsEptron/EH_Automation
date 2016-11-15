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
    public class EditSurveySteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();
        editSurvey edSurv = new editSurvey();
        [Given(@"surveys list and i open survey")]
        public void GivenSurveysListAndIOpenSurvey()
        {
            edSurv.findSurvey();
            edSurv.clickViewSurvey();
        }
        
        [Then(@"i edit survey detail")]
        public void ThenIEditSurveyDetail()
        {
            edSurv.editSurveyDetails();
            edSurv.editQuestionToSurvey();
        }
        
        [Then(@"i can save edited survey")]
        public void ThenICanSaveEditedSurvey()
        {
            edSurv.pressEditQuestion();
        }
        
        [Then(@"i can check that survey is added")]
        public void ThenICanCheckThatSurveyIsAdded()
        {
            edSurv.checkSurveyEdit();
        }
    }
}
