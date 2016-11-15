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
using System.Windows.Forms;

namespace EveryHairTestScripts
{
    [Binding]
    public class DeleteSurveyNoSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();
        deleteSurveyNo delSurveyNo = new deleteSurveyNo();


     

        [Then(@"i press delete survey")]
        public void ThenIPressDeleteSurvey()
        {
            delSurveyNo.clickDeleteSurvey();
        }

        [Then(@"cancel delete survey")]
        public void ThenCancelDeleteSurvey()
        {
            delSurveyNo.pressNoDeleteSurvey();
        }
        
        [Then(@"i will check that survey is not deleted")]
        public void ThenIWillCheckThatSurveyIsNotDeleted()
        {
            delSurveyNo.checkSurveyNotDeleted();
        }
    }
}
