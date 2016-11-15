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
    public class DeleteSalonSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();
     
        [When(@"i open any salon from a list")]
        public void WhenIOpenAnySalonFromAList()
        {
            deleteSalon openAnySalon = new deleteSalon();
            openAnySalon.openSalon();
        }
        
        [Then(@"i can press delete button in salon")]
        public void ThenICanPressDeleteButtonInSalon()
        {


            deleteSalon pressDeleteButtonInSalon = new deleteSalon();
            pressDeleteButtonInSalon.pressDeletebutton();

        }
        
        [Then(@"i  cancel delete action")]
        public void ThenICancelDeleteAction()
        {

            deleteSalon pressCancelButtonInSalonn = new deleteSalon();
            pressCancelButtonInSalonn.pressNobutton();

        }
        
        [Then(@"i can delete salon from db")]
        public void ThenICanDeleteSalonFromDb()
        {

            deleteSalon pressDeleteButtonInSalon = new deleteSalon();
            pressDeleteButtonInSalon.pressDeletebutton();

            deleteSalon confirmDelete = new deleteSalon();
            confirmDelete.pressYesbutton();
        }
        
        [Then(@"check if its deleted")]
        public void ThenCheckIfItsDeleted()
        {

            deleteSalon checkIfDeleted = new deleteSalon();
            checkIfDeleted.checkSalonDeleted();

        }
    }
}
