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
    public class addSurvey : SetupSteps

    {

        public IWebDriver driver;
        public static string surveyName = Generate.RandomString(4);
      //  public static string checkName = find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[2]")).ToString();

        public void openSurveyPage()
        {


            // click advice tool
            find(By.XPath("html/body/div[1]/div/div[1]/nav/div/ul/li[8]/a/span[1]/span"))
                .Click();

            // click Survey
            find(By.Id("advisesSurveys"))
                .Click();
        }

        public void clickAddNew()
        {
            //click add new survey
            find(By.Id("addSurveyBtn"))
                .Click();
        }

        public void fillSurveyDetails()
        {
            // add name field
            find(By.Name("survey.Name"))
                .SendKeys(surveyName);


        }

        public void addQuestionToSurvey()
        {
            // click add question
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[5]/div/div/div/span/span[1]"))
                .Click();

            // click random question
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[5]/div/div/ul/li/div[15]/a/div"))
                .Click();
        }

            public void removeQuestion()
        {   // remove question
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div/div/div[2]/button"))
                .Click();

            // click add question
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[5]/div/div/div/span/span[1]"))
                .Click();

            // click random question
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[5]/div/div/ul/li/div[15]/a/div"))
                .Click();

        }
        public void pressSaveQuestion()
        {
            // click save
            find(By.Id("saveBtn"))
                .Click();

        }

        public void checkSurveyAdded()
        {

            // press cancel, to go to view list
            find(By.Id("cancelBtn"))
                .Click();

            // go question then back
            find(By.XPath("html/body/div/div/div[1]/nav/div/ul/li[8]/ul/li[1]/a"))
                .Click();

            find(By.XPath("html/body/div/div/div[1]/nav/div/ul/li[8]/ul/li[2]/a/span/span"))
                .Click();

            // pass value from name to search
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(surveyName);

            Assert.IsTrue(surveyName.Equals(surveyName));

            // clear
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .Clear();


        }
    }
}
