using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EveryHairTestScripts
{
    public class addNewBrands : SetupSteps

    {

        public IWebDriver driver;
        public static string brandNameValue;

        public static string brandDescription = "description";
        public static string emailBrand = "pjotrs@eptron.eu";

        public void addNewBrandButton()
        {
            // click addnew brand
            find(By.Id("addBrandBtn")).Click();

        }

        public void fillBrandsDetails()
        {
            brandNameValue = Generate.RandomString(4);

            // add name
            find(By.Name("brand.Name"))
                .SendKeys(brandNameValue);

            // add email
            find(By.Name("brand.Email"))
                .SendKeys(emailBrand);

            // add description
            find(By.Name("brand.Description"))
                .SendKeys(brandDescription);
        }

        public void clickSaveChanges()
        {

            // click save button
            find(By.Id("saveBtn"))
                .Click();
        }



        public void goBackCheckSearch()
        {

            // click go back button
            find(By.Id("backBtn"))
                .Click();

            // click search to find this brand
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(brandNameValue);
            
            // check that brand is savaed
             Assert.IsTrue(brandNameValue.Equals(brandNameValue));


        }

    }
}
