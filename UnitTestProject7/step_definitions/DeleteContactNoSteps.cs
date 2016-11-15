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
    public class DeleteNoContactsSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        deleteContact delCon = new deleteContact();

        [Given(@"i have contact list opened")]
        public void GivenIHaveContactListOpened()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[1]/h5/span")); 
    }

        [Then(@"i click details and contact window is opened")]
        public void ThenIClickDetailsAndContactWindowIsOpened()
        {
            delCon.openContactWindow();
        }
        
        [Then(@"i can press delete button in contact")]
        public void ThenICanPressDeleteButtonInContact()
        {
            delCon.pressDeletButtonInContact();
        }
        
        [Then(@"i press NO button in Contact")]
        public void ThenIPressNOButtonInContact()
        {
            delCon.pressDeleteContactNO();
        }
        
        [Then(@"check that contact is NOT deleted")]
        public void ThenCheckThatContactIsNOTDeleted()
        {
            delCon.contactNOTdeleted();
        }
    }
}
