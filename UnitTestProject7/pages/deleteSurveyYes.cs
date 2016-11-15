using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
    public class deleteSurveyYes : SetupSteps

    {

        public IWebDriver driver;
        private string checkIfSurveyDeleted;

        public void openSurveyToDelete()
        {
            // click view button
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[4]/div/button"))
                 .Click();
        }

        public void pressDeleteAgainSurvey()
        {

            checkIfSurveyDeleted = find(By.Name("survey.Name")).Text;
            // click Delete button
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[8]/div/button[4]"))
                .Click();
            Thread.Sleep(3500);
        }

        public void pressYesDelete()
        {
            // /press yes buggon
            find(By.XPath("html/body/div[3]/div/div/div/div[2]/button[1]"))
                 .Click();
            Thread.Sleep(10000);
        }

        public void checkSurveyIsDeletedDB()
        {
            // pass value from name to search
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(checkIfSurveyDeleted);

            Assert.AreEqual(checkIfSurveyDeleted, "No matching records found");
        }
    }
}