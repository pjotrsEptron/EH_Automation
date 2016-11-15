using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]

    public class AddFeatureSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();
        addFeatures addNewFeatures = new addFeatures();

        [When(@"i open product features link")]
        public void WhenIOpenProductFeaturesLink()
        {
            addNewFeatures.openFeaturePage();


        }



        [Then(@"i create new feature")]
        public void ThenICreateNewFeature()
        {


            addNewFeatures.addNewFeature();


        }
    

        [Then(@"go back to check this feature in list")]
        public void ThenGoBackToCheckThisFeatureInList()
        {

            addNewFeatures.checkCreatedFeature();

            Assert.AreEqual(checkTitle, find(By.XPath("//td[2]")).Text);


        }
    }
}
