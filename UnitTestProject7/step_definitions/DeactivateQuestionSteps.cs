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
    public class DeactivateQuestionSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        public static string inactiveStatus = "Inactive";
        public static string activeStatus = "Active";

        deactivateActivateQuestion onOffQuestion = new deactivateActivateQuestion();
        addQuestion questionAdd = new addQuestion();
        openQuestionPage questionPage = new openQuestionPage();

        [Given(@"question is added")]
        public void GivenQuestionIsAdded()
        {
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[8]/ul/li[1]/a/span/span"))
                            .Click();
            questionAdd.AddNewQuestion();
            questionAdd.questionInfo();
            questionAdd.addNewAnswer();
            questionAdd.saveAnswer();
        }        
        [Then(@"i press deactivate question")]
        public void ThenIPressDeactivateQuestion()
        {

            onOffQuestion.deactivateQuestion();

        }
        
        [Then(@"check that question is deactivated")]
        public void ThenCheckThatQuestionIsDeactivated()

        {

            onOffQuestion.checkQuestionDeactivated();

        }

        [Given(@"question is deactivated")]
        public void GivenQuestionIsDeactivated()
        {

            Thread.Sleep(150);

        }

        [Then(@"i press activate question")]
        public void ThenIPressActivateQuestion()
        {
            onOffQuestion.activateQuestion();
        }

        [Then(@"check that question is activated")]
        public void ThenCheckThatQuestionIsActivated()
        {
            onOffQuestion.checkQuestionActivated();
        }
    }
}
