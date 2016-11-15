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
    public class DeleteNewUserSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        deleteNewUserYES deleteUserConfirm = new deleteNewUserYES();
        [Given(@"i can press delete buton")]
        public void ThenICanPressDeleteButon()
        {

            deleteUserConfirm.clickDeleteButton();

        }

        [Given(@"click YES button to delete user")]
        public void ThenClickYESButtonToDeleteUser()
        {

            deleteUserConfirm.clicDeleteButtonYES();

        }
        
        [Then(@"i can check that user is deleted")]
        public void ThenICanCheckThatUserIsDeleted()
        {

            deleteUserConfirm.checkThatUserDeleted();


        }
    }
}
