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
    public class AddQuestionPageSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        addQuestion addQuestion = new addQuestion();

        [Given(@"question page is opened")]
        public void GivenQuestionPageIsOpened()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[1]/h5/span"));
        }

        
        [Then(@"i click add button to add a question")]
        public void ThenIClickAddButtonToAddAQuestion()
        {
            addQuestion.AddNewQuestion();
        }
        
        [Then(@"i fill all question details")]
        public void ThenIFillAllQuestionDetails()
        {
            addQuestion.questionInfo();
            addQuestion.addNewAnswer();
            addQuestion.removeAnswers();
            addQuestion.addNewAnswer();
        }
        
        [Then(@"i press save button to save question")]
        public void ThenIPressSaveButtonToSaveQuestion()
        {
            addQuestion.saveAnswer();
            addQuestion.checkQuestionAdded(); // check 
        }
    }
}
