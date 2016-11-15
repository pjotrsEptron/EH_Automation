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
    public class OpenContactPageSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        contactPage conPage = new contactPage();
        filteringContacts filterCon = new filteringContacts();

        [Given(@"contact page is opened")]
        public void GivenContactPageIsOpened()
        {

            conPage.openContactPage();

        }

        [Then(@"i did filtering")]
        public void ThenIDidFiltering()
        {

            filterCon.chooseTypeAll();


            filterCon.chooseTypeComplaint();

            filterCon.chooseTypeFeedBack();

            filterCon.chooseTypeQuestion();
            Thread.Sleep(3000);


        }
    }
}
