using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]
    public class AddNewSurveySteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();
        addSurvey addSurv = new addSurvey();
        [Given(@"i open survey page")]
        public void GivenIOpenSurveyPage()
        {
            addSurv.openSurveyPage();
        }

        [Then(@"i click add new survey and fill all details")]
        public void ThenIClickAddNewSurveyAndFillAllDetails()
        {
            addSurv.clickAddNew();
            addSurv.fillSurveyDetails();
        }

        [Then(@"i add questions to survey")]
        public void ThenIAddQuestionsToSurvey()
        {
            addSurv.addQuestionToSurvey();
            
        }

        [When(@"question is added i can remove it and add it again")]
        public void WhenQuestionIsAddedICanRemoveItAndAddItAgain()
        {
            addSurv.removeQuestion();
            addSurv.addQuestionToSurvey();

        }
        
                           
        [Then(@"i can save survey")]
        public void ThenICanSaveSurvey()
        {
            addSurv.pressSaveQuestion();
                }
        
        [Then(@"check that survey is saved")]
        public void ThenCheckThatSurveyIsSaved()
        {
            addSurv.checkSurveyAdded();
        }
    }
}
