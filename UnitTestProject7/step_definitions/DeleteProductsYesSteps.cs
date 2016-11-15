using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Timers;
using TechTalk.SpecFlow;
using EveryHairTestScripts;
using EveryHairTestScripts.config;
using static EveryHairTestScripts.utils.Check;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]
    public class DeleteProductsYesSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        deleteProductYes deleteProdyes = new deleteProductYes();

        [Given(@"product page still opened")]
        public void GivenProductPageStillOpened()
        {

            deleteProdyes.pageProductOpenedYes();

        }
        
        [Then(@"i press delete button agaon")]
        public void ThenIPressDeleteButtonAgaon()
        {
            deleteProdyes.clickDeleteButtonProd();

        }
        
        [Then(@"press YES to delete product")]
        public void ThenPressYESToDeleteProduct()

        {

            deleteProdyes.clickYesButtonProd();

        }
        
        [Then(@"i can check that product is deleted")]
        public void ThenICanCheckThatProductIsDeleted()
        {

            deleteProdyes.checkProductDeleted();

        }
    }
}
