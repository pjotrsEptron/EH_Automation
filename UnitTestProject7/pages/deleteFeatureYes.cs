using EveryHairTestScripts.config;
using OpenQA.Selenium;
using System.Threading;
using System;
using TechTalk.SpecFlow;
using static EveryHairTestScripts.utils.Find;
//using static EveryHairTestScripts.utils.Check;
using NUnit.Framework;
using EveryHairTestScripts.utils;
using EveryHairTestScripts;


namespace EveryHairTestsScripts
{
    [Binding]
    public class deleteFeaturesYes : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        private string checkDeletedFeature;


        public void pressDeleteFeatureAgain()
        {


            checkDeletedFeature = find(By.Name("feature.Name")).Text;

            // press delete featgure button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[4]/div/button[3]")).Click();

        }

        public void pressYesButtonInFeatures()
        {

            // press NO buttoin
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[1]")).Click();


        }

        public void checkFeatureIsDeleted()
        {

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkDeletedFeature); // click in search


        }
    }
}