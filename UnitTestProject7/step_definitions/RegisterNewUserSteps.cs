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
    public class RegisterNewUserSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        registerNewUser regUsers = new registerNewUser();

        [Given(@"register user page")]
        public void GivenRegisterUserPage()
        {

            regUsers.openNewUserPage();

        }

        [Given(@"i can register users")]
        public void GivenICanRegisterUsers()
        {

            regUsers.registerNewUserButton();
            regUsers.registerUserManager();


            Thread.Sleep(5000);

            regUsers.registerNewUserButton();
            regUsers.registerAccountant();

            Thread.Sleep(5000);

            regUsers.registerNewUserButton();
            regUsers.registerAccountManager();


            Thread.Sleep(5000);

            regUsers.registerNewUserButton();
            regUsers.registerClientAdmin();


            Thread.Sleep(5000);

            regUsers.registerNewUserButton();
            regUsers.registerClientRepsentative();


            Thread.Sleep(3000);

            regUsers.registerNewUserButton();
            Thread.Sleep(3000);
            regUsers.registerReseller();


            Thread.Sleep(3000);

            regUsers.registerNewUserButton();
            Thread.Sleep(3000);
            regUsers.registerSuperAdmin();
            

        }


        [When(@"users are registered i can found then")]
        public void WhenUsersAreRegisteredICanFoundThen()

        {

            regUsers.checkUserIsRegistered(registerNewUser.emailUserManager);
            regUsers.checkUserIsRegistered(registerNewUser.emailAccountant);

            regUsers.checkUserIsRegistered(registerNewUser.emailAccountManager);

            regUsers.checkUserIsRegistered(registerNewUser.emailClientRepresentataive);

            regUsers.checkUserIsRegistered(registerNewUser.emailReseller);
            regUsers.checkUserIsRegistered(registerNewUser.emailSuperAdmin);
            regUsers.checkUserIsRegistered(registerNewUser.emailAccountManager);




        }
    }
}