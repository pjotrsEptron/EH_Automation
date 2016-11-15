using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
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
    public class EditNewUsersSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        editNewUser editNewUserSteps = new editNewUser();

        [Given(@"new user profile")]
        public void GivenNewUserProfile()
        {

            editNewUserSteps.openNewUser();

        }
        
        [When(@"i update new user profile fields")]
        public void WhenIUpdateNewUserProfileFields()
        {

            editNewUserSteps.editNewUserPage();

        }
        
        [When(@"upload new image")]
        public void WhenUploadNewImage()
        {

            editNewUserSteps.editNewUserPicture();

        }
        
        [Then(@"i can press save button")]
        public void ThenICanPressSaveButton()
        {

            editNewUserSteps.clickSaveChanges();

        }
        
        [Then(@"check that user info is updated")]
        public void ThenCheckThatUserInfoIsUpdated()
        {

            editNewUserSteps.checkEditedUser();

        }
    }
}
