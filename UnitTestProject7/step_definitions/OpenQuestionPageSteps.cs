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
    public class OpenQuestionPage : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        openQuestionPage openQuestionPage = new openQuestionPage();
        [Given(@"open questions page")]
        public void GivenOpenQuestionsPage()
        {
            openQuestionPage.openPage();
        }
    }
}
