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
    public class ActivateDeactivateUser : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        deactivateNewUser deactActUser = new deactivateNewUser();

        [Given(@"new user profile is opened")]
        public void GivenNewUserProfileIsOpened()
        {

            deactActUser.openEditedUserProfile();

        }
        
        [Then(@"i can click deactivete user")]
        public void ThenICanClickDeactiveteUser()
        {

            deactActUser.clickDeactivateUser();


        }
        
        [Then(@"press activate button back")]
        public void ThenPressActivateButtonBack()
        {

            deactActUser.clickActivateUser();

        }
    }
}
