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
    public class EditQuestionSteps : SetupSteps

        
    {

        editQuestion edQuestion = new editQuestion();
        [Given(@"open question after it was found")]
        public void GivenOpenQuestionAfterItWasFound()
        {
            edQuestion.openQuestion();
        }
        
        [Then(@"i can edit question details")]
        public void ThenICanEditQuestionDetails()
        {
            edQuestion.editQuestionDetail();
        }
        
        [Then(@"press save edited deatils")]
        public void ThenPressSaveEditedDeatils()
        {
            edQuestion.saveEditedAnswer();
        }
        
        [Then(@"i can check edited question")]
        public void ThenICanCheckEditedQuestion()
        {
            edQuestion.checkEditedQuestion();
        }
    }
}
