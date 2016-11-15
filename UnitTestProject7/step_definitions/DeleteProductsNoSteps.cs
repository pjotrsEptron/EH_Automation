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
    public class DeleteProductsNoSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        deleteProductNo deleteProd = new deleteProductNo();

        [Given(@"product page is opened")]
        public void GivenProductPageIsOpened()
        {

            deleteProd.pageProductOpened();

        }
        
        [Then(@"i press delete button to delete")]
        public void ThenIPressDeleteButtonToDelete()
        {

            deleteProd.clickDeleteButtonProd();

        }
        
        [Then(@"press NO to cancel delete product")]
        public void ThenPressNOToCancelDeleteProduct()
        {
            deleteProd.clickNoButtonProd();

                }
    }
}
