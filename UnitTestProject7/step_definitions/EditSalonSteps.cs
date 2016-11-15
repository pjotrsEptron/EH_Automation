using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Timers;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]
    public class EditSalonSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        [Given(@"list of salon")]
        public void GivenListOfSalon()
        {

            // session is continued after last step in add salon

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[7]/div/button[1]")).Click(); // Click VIew button

        }

        [When(@"i update existing salon")]
        public void WhenIUpdateExistingSalon()
        {

            editSalon editDetails = new editSalon();
            editDetails.editSalonDetails();
                
                }

        [Then(@"i can save it")]
        public void ThenICanSaveIt()
        {

            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[1]")).Click();

        }

        [Then(@"see result")]
        public void ThenSeeResult()
        {

            editSalon checkDetailAfterEdit = new editSalon();
            checkDetailAfterEdit.CheckSalonDetails();

        }
    }
}
