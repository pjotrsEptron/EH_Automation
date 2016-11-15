using EveryHairTestScripts.config;
using OpenQA.Selenium;
using System.Threading;
using System;
using TechTalk.SpecFlow;
using static EveryHairTestScripts.utils.Find;
//using static EveryHairTestScripts.utils.Check;
using NUnit.Framework;
using EveryHairTestScripts.utils;
using OpenQA.Selenium.Support.UI;

namespace EveryHairTestScripts
{
    class deactivateSalon
    {

        IWebDriver driver = Driver.getDriver();

     

        public void openSalon()
        {

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[7]/div/button[1]")).Click();
        }

        public void clickDeactivate()
        {


            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[3]")).Click();
            Thread.Sleep(500);
            //WebDriverWait wait21321 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //wait21321.Until(ExpectedConditions.TextToBePresentInElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[3]"), "text to be found"));
        }

        public void clickActivate()
        {

            Thread.Sleep(5000);
            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[3]")).Click();
            Thread.Sleep(5000);

            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[2]")).Click(); // click cancel
            Thread.Sleep(5000);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys("rQzO");
        }
    }
}
