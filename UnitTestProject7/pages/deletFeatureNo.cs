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
    public class deleteFeaturesNo : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();



        public void pressDeleteFeature()
        {

            // press delete featgure button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[4]/div/button[3]")).Click();

        }

        public void pressNoButtonInFeatures()
        {

            // press NO buttoin
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[2]")).Click();


        }
    }
}