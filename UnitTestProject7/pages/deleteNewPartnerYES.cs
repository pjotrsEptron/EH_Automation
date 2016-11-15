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
    public class deleteNewPartnerYES : SetupSteps

    {

        public IWebDriver driver;

        private string checkDeletedPartner;

        public void pressDeleteButtonINPartners()
        {
            checkDeletedPartner = find(By.Name("partner.Name")).Text;

            // press delete button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[3]/div[2]/div/button[4]")).Click();

            // check popup
            //Check.presence(By.XPath("/html/body/div[3]/div/div/div/div[1]/div/span"));
        }

        public void pressYESinDelete()
        {
            // press YES bytton
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[1]")).Click();

        }

        public void checkThatPartnerIsDeleted()
        {

            // check that correct page is opened
            //Check.presence(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[1]/h5/span"));

            // type deleted name in search
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkDeletedPartner);
        }
    }
}