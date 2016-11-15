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
    public class DeleteQuestionYesSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        deleteQuestionYes delQuestYes = new deleteQuestionYes();
        [Given(@"question list is opened")]
        public void GivenQuestionListIsOpened()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/ul/li/a/tab-heading/span"));
        }

        [Then(@"i press delete question button")]
        public void ThenIPressDeleteQuestionButton()
        {
            delQuestYes.pressDeleteButton();
        }
        
        [Then(@"i confirm delete question")]
        public void ThenIConfirmDeleteQuestion()
        {
            delQuestYes.pressYesButtonToDelete();
        }
        
        [Then(@"i can check that question is deleted")]
        public void ThenICanCheckThatQuestionIsDeleted()
        {
            delQuestYes.passQuestionTitle();
        }
    }
}
