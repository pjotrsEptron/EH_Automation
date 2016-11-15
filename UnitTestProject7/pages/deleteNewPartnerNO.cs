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
    public class deleteNewPartnerNO : SetupSteps

    {

        public IWebDriver driver;

        public void openFoundPartner()
        {



            // click back button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[1]/div[1]/button")).Click();

            

            //find partner
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(AddPartners.checkName);

            // open found partner
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[6]/div/button")).Click();
        
        }

        public void pressDeleteButtonInPartners()
        {

            // press delete button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[3]/div[2]/div/button[4]")).Click();

            // check popup
            //Check.presence(By.XPath("/html/body/div[3]/div/div/div/div[1]/div/span"));
                                }

        public void pressNOinDelete()
        {
            // press NO bytton
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[2]")).Click();

        }
    }
}