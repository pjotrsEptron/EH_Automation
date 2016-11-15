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
    public class OpenBrandSteps : SetupSteps
    {

        openBrandPage openBrpage = new openBrandPage();

        [Given(@"I click Brands link on the left menu")]
        public void GivenIClickBrandsLinkOnTheLeftMenu()
        {
            openBrpage.openBrands();

                }
        
        [Given(@"then brands page is opened")]
        public void GivenThenBrandsPageIsOpened()
        {

            openBrpage.checkBrandsPage();

        }
    }
}
