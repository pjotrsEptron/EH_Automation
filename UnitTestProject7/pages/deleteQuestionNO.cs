using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;

namespace EveryHairTestScripts
{
    public class deleteQuestionNO : SetupSteps

    {

        public IWebDriver driver;

        private string checkQuestionDeleted;

        public void openQuestion()
        {


            // click view button after search
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[4]/div/button"))
                .Click();

        }

        public void pressDeleteQuestion()
        {
            Thread.Sleep(2500);

            checkQuestionDeleted = find(By.Name("question.Value")).Text;

            // click delete question
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[9]/div/button[4]"))
                .Click();
            Thread.Sleep(1500);

        }

        public void cancelQuestionDelete()
        {
            // click NO button
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[2]"))
                .Click();
            Thread.Sleep(1500);

        }

        public void checkQuestionNotDeleted()
        {

            //            Assert.(checkQuestionDeleted.Equals(addQuestion.checkTitle));
            //Check.presence(By.Name(checkQuestionDeleted));

            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Name("question.Value")));

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[9]/div/button[4]"));

        }
    }
}