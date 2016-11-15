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
using System.Windows.Forms;

namespace EveryHairTestScripts
{
    [Binding]
    public class DeleteYesContactsSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        deleteContactYes delYesCon = new deleteContactYes();

        [Given(@"Open Contact by pressing deatils")]
        public void GivenOpenContactByPressingDeatils()
        {
            delYesCon.openContactWindow();

        }
        
        [Then(@"i press deletebutton in contact")]
        public void ThenIPressDeletebuttonInContact()
        {

            delYesCon.pressDeletButtonInContact();


        }

        [Then(@"i confirm delete action for contact")]
        public void ThenIConfirmDeleteActionForContact()
        {
            delYesCon.pressDeleteContactYES();

        }

        [Then(@"i check that contact is deleted")]
        public void ThenICheckThatContactIsDeleted()
        {
            delYesCon.contactDeleted();
        }
    }
}
