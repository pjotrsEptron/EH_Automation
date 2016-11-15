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
using NUnit.Framework;

namespace EveryHairTestScripts
{
    public class deactivateActivateProducts : SetupSteps

    {

        public IWebDriver driver;
        public static string inactiveStatus = "Inactive";
        public static string activeStatus = "Active";

        public void openProduct()
        {
            
            //find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
            //    .SendKeys(addProducts.brandName);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[5]/div/button"))
                .Click();

            Thread.Sleep(3000);


        }

        public void clickDeactivateProduct()
        {

            // click deactivate button
            find(By.XPath("//div/button[3]"))
                .Click();
             Thread.Sleep(3000);

        }
        
        public void checkProductIsDeactivated()
        { 
            // check that status is inactive
            Assert.AreEqual(inactiveStatus, 
                find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[3]/div/p/span/span"))
                .Text);

            Thread.Sleep(3000);

        }

        public void clickActivateProduct()

        {

            // click activate button
            find(By.XPath("//div/button[3]"))
                .Click();

            Thread.Sleep(3000);

        }

        public void checkProductIsActiaved()
        { 
            // check that status is active
            Assert.AreEqual(activeStatus, find(By.XPath("//div[@id='page-wrapper']/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[3]/div/p/span/span"))
                .Text);
            Thread.Sleep(3000);

        }
    }
}

      