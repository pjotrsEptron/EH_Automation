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
    class deleteSalon
    {

        IWebDriver driver = Driver.getDriver();

      

        public void openSalon()
        {

            Thread.Sleep(1000);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[7]/div/button[1]")).Click();
    }

        public void pressDeletebutton()
        {

            Thread.Sleep(1000);

            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[4]")).Click();
            Thread.Sleep(1000);

        }

        public void pressNobutton()
        {

            Thread.Sleep(3000);
            find(By.XPath("/html/body/div[5]/div/div/div/div[2]/button[2]")).Click(); // press NO


        }

        public void pressYesbutton()
        {
         
            find(By.XPath("/html/body/div[5]/div/div/div/div[2]/button[1]")).Click(); // press YES
            Thread.Sleep(1000);


        }

        public void checkSalonDeleted()
        {

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"));

        }
    }
}

       
