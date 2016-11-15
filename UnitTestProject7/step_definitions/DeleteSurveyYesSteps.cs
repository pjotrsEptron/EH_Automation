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
    public class DeleteSurveyYesSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();
        deleteSurveyYes delSurvey = new deleteSurveyYes();

        //[Given(@"i see survey that is not deleted")]
        //public void GivenISeeSurveyThatIsNotDeleted()
        //{
        //    delSurvey.openSurveyToDelete();
        //}

        [Then(@"i press view survey again")]
        public void ThenIPressViewSurveyAgain()
        {
            delSurvey.openSurveyToDelete();
        }

        [Then(@"i can delete it by pressing yes")]
        public void ThenICanDeleteItByPressingYes()
        {
            
            delSurvey.pressDeleteAgainSurvey();
            delSurvey.pressYesDelete();
        }

        [Then(@"i check that survey is deleted from db")]
        public void ThenICheckThatSurveyIsDeletedFromDb()
        {
            delSurvey.checkSurveyIsDeletedDB();
        }
    }
}