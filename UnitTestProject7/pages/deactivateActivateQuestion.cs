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
    public class deactivateActivateQuestion : SetupSteps

    {

        public IWebDriver driver;
        public static string inactiveQuestionStatus = "Inactive";
        public static string activeQuestionStatus = "Active";

        public void deactivateQuestion()
        {
            Thread.Sleep(3000);

            // click deact
            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[9]/div/button[3]"))
                .Click();
            Thread.Sleep(3000);
           

        }

        public void checkQuestionDeactivated()
        {


            Thread.Sleep(3000);

            // check that status is inactive
            Assert.AreEqual(inactiveQuestionStatus,
                find(By.XPath("//div[@id='page-wrapper']/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[4]/div/p/span/span"))
                .Text);
            Thread.Sleep(3000);

        }

        public void activateQuestion()
        {

            Thread.Sleep(3000);

            // drop cursos
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[7]"))
                .Click();
            Thread.Sleep(3000);

            // click activate
            find(By.Id("activateBtn"))
                .Click();

        }

        public void checkQuestionActivated()
        {
            Thread.Sleep(3000);

            // check that status is active
            Assert.AreEqual(activeQuestionStatus, find(By.XPath("//div[@id='page-wrapper']/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[4]/div/p/span/span"))
                .Text);
            Thread.Sleep(3000);

        }
    }
}