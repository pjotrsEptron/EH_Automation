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
    public class deleteSurveyNo : SetupSteps

    {

        public IWebDriver driver;
        private string checkSurveyDeleted;
                     
        public void clickDeleteSurvey()
        {
            checkSurveyDeleted = find(By.Name("survey.Name")).Text;

            // click delete button
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[8]/div/button[4]"))
                .Click();
        }

        public void pressNoDeleteSurvey()
        {
            // click No button
            find(By.XPath("html/body/div[3]/div/div/div/div[2]/button[2]"))
                .Click();
            Thread.Sleep(3500);
        }

        public void checkSurveyNotDeleted()
        {
            // click cancel to open view
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[8]/div/button[2]"))
                 .Click();
            Thread.Sleep(10000);

            // pass value from name to search
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(checkSurveyDeleted);

            Assert.AreEqual(checkSurveyDeleted, driver.FindElement(By.XPath("//div[@id='page-wrapper']/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[2]/div/p/span/span")).Text);
        }
    }
}
