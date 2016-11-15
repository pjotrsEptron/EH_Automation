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
    public class NotificationSteps
    {
        notifications Notifications = new notifications();


        [Given(@"i open notification message")]
        public void GivenIOpenNotificationMessage()
        {

            Notifications.openNotification();

        }
        
        [Given(@"I can compose message")]
        public void GivenICanComposeMessage()
        {

            Notifications.composeNewMessage();

        }

        [Given(@"i will check that message is sent")]
        public void GivenIWillCheckThatMessageIsSent()
        {
            Notifications.checkMessageSent();
        }

        [Given(@"i create a new message again")]
        public void GivenICreateANewMessageAgain()
        {

            Notifications.composeNewMessage();
        }

        [Then(@"i click cancel button")]
        public void ThenIClickCancelButton()
        {


            Notifications.cancelMessage();


        }

        [Given(@"create a new message")]
        public void GivenCreateANewMessage()
        {


            Notifications.composeNewMessage();

        }
        
      
        
        [Then(@"i click draft button")]
        public void ThenIClickDraftButton()
        {

            Notifications.draftMessage();

        }
        
        [Then(@"message moved to draft")]
        public void ThenMessageMovedToDraft()
        {


            Notifications.checkDraftMessage();
        }
        
        [Then(@"i can check it")]
        public void ThenICanCheckIt()
        {

            Notifications.checkDraftMessageInFolder();
        }
    }
}
