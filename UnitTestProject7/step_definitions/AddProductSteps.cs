using NUnit.Framework;
using OpenQA.Selenium;
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

    public class AddProductSteps : SetupSteps
    {

        addProducts addNewProduct = new addProducts();

        [Given(@"openProduct Page")]
        public void GivenOpenProductPage()
        {

            addNewProduct.addProductPage();

        }
        
        [Then(@"i can press Add New product")]
        public void ThenICanPressAddNewProduct()
        {

            addNewProduct.addNewProductButton();

        }
        
        [Then(@"fill all details to product")]
        public void ThenFillAllDetailsToProduct()
        {

            addNewProduct.addNewProduct();
            //addNewProduct.addFeature();
            //addNewProduct.createFeature();
            addNewProduct.checkCreatedFeature();
            //addNewProduct.quantity();
            //addNewProduct.deleteQuantity();
            Thread.Sleep(5000);
            //addNewProduct.addQuantityAgain();
            Thread.Sleep(5000);
            addNewProduct.pressSaveButton();
            

        }

        [Then(@"i can check product is created")]
        public void ThenICanCheckProductIsCreated()
        {

            addNewProduct.checkProductCreated();

        }
    }
}
