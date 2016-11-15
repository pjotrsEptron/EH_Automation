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
    public class DeleteNewUserNoSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        deleteNewUserNO deleteUserCancel = new deleteNewUserNO();
       
        
        [Given(@"i can click Delete button to delete this user")]
        public void ThenICanClickDeleteButtonToDeleteThisUser()
        {

            deleteUserCancel.clickDeleteButton();

        }
        
        [Given(@"i can cancel delete action by pressing NO")]
        public void ThenICanCancelDeleteActionByPressingNO()
        {

            deleteUserCancel.clicDeleteButtonNO();

        }
    }
}
