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
    public class BrandCompanyuSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        openBrandCompanies openBrandComoanies = new openBrandCompanies();
        [Given(@"i open brand info")]
        public void GivenIOpenBrandInfo()
        {
            openBrandComoanies.openBrand1();
        }
        
        [Then(@"i click brand companies tab")]
        public void ThenIClickBrandCompaniesTab()
        {
            openBrandComoanies.brandCompaniesTab();
        }
        
        [Then(@"i check that brand companies list is visible")]
        public void ThenICheckThatBrandCompaniesListIsVisible()
        {
            openBrandComoanies.checkList();
        }
    }
}
