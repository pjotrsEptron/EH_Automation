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
    public class DeleteQuestionNoSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        deleteQuestionNO delQuest = new deleteQuestionNO();

        [Given(@"questions list is opened")]
        public void GivenQuestionsListIsOpened()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[1]/h5/span"));
    }

        [Then(@"i open question")]
        public void ThenIOpenQuestion()
        {
            delQuest.openQuestion();

        }
        
        [Then(@"i press delete question")]
        public void ThenIPressDeleteQuestion()
        {
            delQuest.pressDeleteQuestion();
        }
        
        [Then(@"i press NO delete question")]
        public void ThenIPressNODeleteQuestion()
        {
            delQuest.cancelQuestionDelete();
        }
        
        [Then(@"i check that question is not deleted")]
        public void ThenICheckThatQuestionIsNotDeleted()
        {
            delQuest.checkQuestionNotDeleted();
        }
    }
}
