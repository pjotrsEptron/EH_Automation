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
    public class PromotionalSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        [Given(@"Promotional page is opened")]
        public void GivenPromotionalPageIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"page with promotional is opened")]
        public void GivenPageWithPromotionalIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"page with details is opened")]
        public void GivenPageWithDetailsIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"im on promotional page")]
        public void GivenImOnPromotionalPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"im no promotional page")]
        public void GivenImNoPromotionalPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add new promotional")]
        public void WhenIPressAddNewPromotional()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i click cancel button , page is closed")]
        public void WhenIClickCancelButtonPageIsClosed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i redirected to promotional page")]
        public void WhenIRedirectedToPromotionalPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i fill all details")]
        public void WhenIFillAllDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i click activate button")]
        public void WhenIClickActivateButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i click deactivate button")]
        public void WhenIClickDeactivateButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"page with promotional is opene")]
        public void WhenPageWithPromotionalIsOpene()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i can click delete button")]
        public void WhenICanClickDeleteButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"new window is opened")]
        public void ThenNewWindowIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"i can press save promotional")]
        public void ThenICanPressSavePromotional()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"promotional i activated")]
        public void ThenPromotionalIActivated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"promotional i deacactivated, go back")]
        public void ThenPromotionalIDeacactivatedGoBack()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"i click view promotional button")]
        public void ThenIClickViewPromotionalButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"i cancel deletepromotional")]
        public void ThenICancelDeletepromotional()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"i click any promotional")]
        public void ThenIClickAnyPromotional()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"i can click Deletepromotional button")]
        public void ThenICanClickDeletepromotionalButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"i can confirm with YES and check on promotional page")]
        public void ThenICanConfirmWithYESAndCheckOnPromotionalPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
