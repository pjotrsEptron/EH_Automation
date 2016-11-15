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
    public class AddNewBrandPage : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();
        addNewBrands addNewBrands = new addNewBrands();
        openBrandPage openBrpage = new openBrandPage();

        [Given(@"brands page is opened")]
        public void GivenBrandsPageIsOpened()
        {

            openBrpage.checkBrandsPage();
            
        }

        [Then(@"i click add new brand")]
        public void ThenIClickAddNewBrand()
        {

            addNewBrands.addNewBrandButton();

        }

        [Then(@"i fill all detaills")]
        public void ThenIFillAllDetaills()
        {
            addNewBrands.fillBrandsDetails();
        }

       
        [Then(@"i click Save Changes")]
        public void ThenIClickSaveChanges()
        {
            addNewBrands.clickSaveChanges();
        }

        [When(@"brands is created i go back to find this brand in search")]
        public void WhenBrandsIsCreatedIGoBackToFindThisBrandInSearch()
        {
            addNewBrands.goBackCheckSearch();
        }
        
     
        
       
        
      
    }
}
