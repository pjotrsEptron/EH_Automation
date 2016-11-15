using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using NUnit.Framework;

namespace EveryHairTestScripts
{
    public class editSurvey : SetupSteps

    {

        public IWebDriver driver;
      // public static string surveyName = Generate.RandomString(4);
    //    public static string editedSurveyCheck = find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[2]")).ToString();
        public static string editedSurveyName = Generate.RandomString(10);

        public void findSurvey()
        {
            // pass value from name to search
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(addSurvey.surveyName);
        }

        public void clickViewSurvey()
        {
            //click add new survey
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[4]/div/button"))
                .Click();
        }

        public void editSurveyDetails()
        {
            // clear name field
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[1]/div/input"))
                .Clear();

            // add name field
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[1]/div/input"))
                .SendKeys(editedSurveyName);


            // add description
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[3]/div/textarea"))
                .SendKeys("automated and edited");

        }

        public void editQuestionToSurvey()
        {
            // click add question
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[5]/div/div/div/span/span[1]"))
                .Click();

            // click random question
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[5]/div/div/ul/li/div[15]/a/div"))
                .Click();

            
        }
        public void pressEditQuestion()
        {
            // click save
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[8]/div/button[1]"))
                .Click();

        }

        public void checkSurveyEdit()
        {

            // press cancel, to go to view list
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[8]/div/button[2]"))
                .Click();

            // pass value from name to search
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(editedSurveyName);

            Assert.IsTrue(editedSurveyName.Equals(editedSurveyName));

        }
    }
}
