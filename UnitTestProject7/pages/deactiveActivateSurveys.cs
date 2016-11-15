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
using static System.Net.Mime.MediaTypeNames;

namespace EveryHairTestScripts
{
    public class deactiveActivateSurveys : SetupSteps

    {

        public IWebDriver driver;
       public static string surveyName = Generate.RandomString(4);
      //  private static string Active = find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[2]/div/p/span/span")).ToString();
        //private static string Inactive = find(By.XPath("html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[2]/div/p/span/span")).ToString();

        public void openSurveyAny()
        {


            // go question then back
            find(By.XPath("html/body/div/div/div[1]/nav/div/ul/li[8]/ul/li[1]/a"))
                .Click();
            Thread.Sleep(5000);

            find(By.XPath("html/body/div/div/div[1]/nav/div/ul/li[8]/ul/li[2]/a/span/span"))
                .Click();
            Thread.Sleep(5000);


            // clear name
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .Clear();
            Thread.Sleep(1500);

            // pass value from name to search
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(editSurvey.editedSurveyName);

            //click view survey
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[4]/div/button"))
                .Click();
        }

        public void activateSurvey()
        {
            // press activate button
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[8]/div/button[3]"))
                .Click();
        }
               public void checkActiavteSurvey()
        {
            Assert.AreEqual("Active", "Active");
        }

        public void deactivateSurvey()
        {
            // press activate button
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[8]/div/button[3]"))
                .Click();
        }
            public void checkDeactiveSurvey()
        { 
            Assert.AreEqual("Inactive", "Inactive");
            Thread.Sleep(3000);
        }
    }
}