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
    public class ProductsOnOffSteps
    {
        deactivateActivateProducts deactProducts = new deactivateActivateProducts();


        [Given(@"open created product page")]
        public void GivenOpenCreatedProductPage()
        {

            deactProducts.openProduct();

        }

        [Then(@"i press deactivate button in Products")]
        public void ThenIPressDeactivateButtonInProducts()
        {

            
            deactProducts.clickDeactivateProduct();
            deactProducts.checkProductIsDeactivated();
        }


        [When(@"product is deactivated i press activate button")]
        public void WhenProductIsDeactivatedIPressActivateButton()
        {

            deactProducts.clickActivateProduct();
            deactProducts.checkProductIsActiaved();
        }
    }
}