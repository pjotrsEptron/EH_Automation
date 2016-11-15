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
    public class activateBrands : SetupSteps

    {

        public IWebDriver driver;
        public static string brandNameValue;
        public static string brandStatus = "Active";
        public static string brandStatusInactive = "Inactive";
        //public static string brandNameActivated;
        //public static string brandNameDeactivated;



        public void brandFound()
        {

            Assert.IsTrue(addNewBrands.brandNameValue.Equals(addNewBrands.brandNameValue));


        }

        public void openBrand()
        {


            // open brand
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[4]/div/button[1]"))
                .Click();
        }

        public void clickAtivateBrand()
        {
            //brandNameActivated = find(By.Name("brand.Name")).Text;

            // click activate button
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[6]/div/button[3]"))
                .Click();

        }

        public void checkActivatedBrand()
        {

            // check that active
            Thread.Sleep(2000);
            Assert.AreEqual("Active", find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[4]/div/p/span")).Text);


        }

        public void goBackAndCheck()
        {

            // go back
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[1]/div[1]/button"))
                .Click();
            Thread.Sleep(2000);


            //// click search field
            //find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).Click();
            //Thread.Sleep(3000);

            // find this brand
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(addNewBrands.brandNameValue);
            Thread.Sleep(2000);

            // check active status
            Assert.AreEqual(brandStatus, find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[3]/span/span"))
                .Text);



        }

        public void openFoundBrand()
        {

            // open brand
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[4]/div/button[1]"))
                .Click();

        }

        public void clickDeactivateButton()
        {

            //brandNameDeactivated = find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[1]/div/input")).Text;

            // click deact button
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[6]/div/button[3]"))
                .Click();

        }

        public void checkDeactivedBrandonPage()
        {

            // check that active
            Thread.Sleep(2000);
            Assert.AreEqual("Inactive", find(By.XPath("html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[4]/div/p/span")).Text);




        }

        public void goBackAndCheckAgain()
        {



            // go back
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[1]/div[1]/button"))
                .Click();

            // find this brand
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(addNewBrands.brandNameValue);
            Thread.Sleep(2000);


            // check active status
            Assert.AreEqual(brandStatusInactive, find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[3]/span/span"))
                .Text);




        }
    }
}