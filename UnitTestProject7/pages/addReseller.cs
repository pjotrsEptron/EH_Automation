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

namespace EveryHairTestScripts
{
    public class addReseller : SetupSteps

    {

        public IWebDriver driver;

  

        public void openResellerPage()
        {
            // click settings
            find(By.XPath("/html/body/div[1]/div/div[1]/nav/div/ul/li[12]/a")).Click();


            Thread.Sleep(3000);
            // click Resellers
            find(By.Id("settingsResellers")).Click();

            // check that resellers page is opened

        }
        public void addNewReseller()
        {

            // generator of random string
            checkTitle = Generate.RandomString(4);

            // click add new reseller button
            find(By.Id("addResellerBtn")).Click();

            // Clear Name if exists
            find(By.Name("reseller.Name")).Clear();

            // Type Name
            find(By.Name("reseller.Name")).SendKeys(checkTitle);

            // Clear Email if exists
            find(By.Name("reseller.Email")).Clear();

            // Type Email
            find(By.Name("reseller.Email")).SendKeys("email@email.lv");

            // Clear desrp
            find(By.Name("reseller.Description")).Clear();

            // Type desrp
            find(By.Name("reseller.Description")).SendKeys("description");


            // set countries (belgium)
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[5]/div/div/div/input")).Click();

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[5]/div/div/ul/li/div[3]/a/div")).Click();

            // set language
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[6]/div/div/div/input")).Click();
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[6]/div/div/ul/li/div[3]/a")).Click(); // set as EN


            // set def lang
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[7]/div/div/select")).Click();
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[7]/div/div/select/option[2]")).Click();

            // drop coursor

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[8]/div/p")).Click();


        

        }

        public void pressSaveButtonReseller()
        {

            // press save
            find(By.XPath("saveBtn")).Click();
            Thread.Sleep(3000);
        }

        public void checkResellerCreated()
        {

            find(By.Id("backBtn")).Click(); // click Back Button      
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle);

        

        }
    }
}


