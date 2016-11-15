using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using NUnit.Framework;

namespace EveryHairTestScripts
{
    public class addProducts : SetupSteps

    {

        public IWebDriver driver;
        public static string brandName;
        public static string productTitle = "title";
        public static string productDescription = "description";
        public static string productLeadText = "leadtext";
        public static string productAdditionalText = "additionaltext";
        public static string productCover = "cover";
        public static string featureName;
        public static string FeatureDescription = "lalalalal1";

        //public static string productEmbed = "embed";

        public void addProductPage()
        {

            // click products
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[7]/a/span[1]/span"))
                .Click();

            // click prod. lists
            find(By.Id("productsList"))
                .Click();

            // check that page is opened correctly
            //Check.presence(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[1]/h5/span"));
        }

        public void addNewProductButton()
        {
            // click add new prod. button
            find(By.Id("addProductBtn"))
                .Click();

        }


        public void addNewProduct()
        {
            brandName = Generate.RandomString(4);
            Console.WriteLine(brandName);

            // pass strings 
            find(By.Name("product.BrandName")).SendKeys(addProducts.brandName);
           find(By.Name("product.ProductMetaDataList[$index].ProductTitle")).SendKeys(productTitle);
           find(By.Name("product.ProductMetaDataList[$index].Description")).SendKeys(productDescription);
           find(By.Name("product.ProductMetaDataList[$index].ProductLeadText")).SendKeys(productLeadText);
           find(By.Name("product.ProductMetaDataList[$index].AdditionalText")).SendKeys(productAdditionalText);
        }

        /// <summary>
        ///   feature Block
        /// </summary>

            //public void addFeature()
            //{


            //    // click featurelist
            //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[10]/div[1]/div/div/input"))
            //        .Click();

            //    // select feature
            //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[10]/div[1]/div/ul/li/div[3]/a/div"))
            //        .Click();

            //}

        //   public void createFeature()
        //{

            //    featureName = Generate.RandomString(9);
            //    // add manually feature
            //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[10]/div[2]/button"))
            //        .Click();

            //   // type name of feature
            //    find(By.XPath("/html/body/div[3]/div/div/div/form/div[1]/div[1]/div/input"))
            //        .SendKeys(addProducts.featureName);

            //    // type description
            //    find(By.XPath("/html/body/div[3]/div/div/div/form/div[1]/div[2]/div/input"))
            //        .SendKeys(FeatureDescription);

        //    // press save
        //    find(By.Id ("saveBtn"))
        //        .Click();
        //Thread.Sleep(2000);

        //}

        public void checkCreatedFeature()
        {

            //Assert.AreEqual(addProducts.featureName, featureName);
            Assert.IsTrue(addProducts.featureName.Equals(featureName));
            

        }

        //public void quantity()

        //{
        //    // set quantity
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[13]/div/div[1]/input"))
        //        .SendKeys("2");

        //    // set measurement
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[13]/div/div[2]/select"))
        //        .Click();

        //    // set ML
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[13]/div/div[2]/select/option[2]"))
        //        .Click();

        //    Thread.Sleep(2000);



        //}

        //public void deleteQuantity()
        //{
            
        //    // press somewhere
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[11]"))
        //        .Click();
        //    Thread.Sleep(2000);


        //    // delete quanity
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[13]/div/div[3]/button"))
        //        .Click();
        //    Thread.Sleep(2000);


        //}

        //public void addQuantityAgain()
        //{

        //    // add quantity again
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[13]/div/button"))
        //        .Click();

        //    // set quantity
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[13]/div/div[1]/input"))
        //        .SendKeys("2");
        //    Thread.Sleep(2000);


        //    // set measurement
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[13]/div/div[2]/select"))
        //        .Click();

        //    // set ML
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[13]/div/div[2]/select/option[2]"))
        //        .Click();
        //    Thread.Sleep(2000);


        //}

        public void pressSaveButton()
        {


            // press somewhere

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[11]"))
                .Click();
            Thread.Sleep(2000);


            // press save
            find(By.Id("saveBtn"))
                .Click();
            Thread.Sleep(2000);

        }

          public void checkProductCreated()
        {
            // click back button
            find(By.Id("backBtn"))
                .Click();
            Thread.Sleep(2000);

            // use search
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
               .SendKeys(brandName);

            Thread.Sleep(5000);

            // Assert.IsTrue(addProducts.brandName.Equals(brandName));

            //   string currentBrandNameVal = find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[3]")).ToString();
            //Assert.AreEqual(brandName, currentBrandNameVal);

        }
    }
}