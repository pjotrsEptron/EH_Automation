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
    public class AddPartners : SetupSteps

    {

        public IWebDriver driver;

        // strings
        public static string partnerPhone = "+123456789";
        public static string partnerFax = "+123456789";
        public static string partnerEmail = "automated@eptron.eu";
        public static string partnerWeb = "http://www.eptron.eu";
        public static string partnerDescription = "hello, my name is Boris.";
        public static string checkName = Generate.RandomString(4);

        public void openPartnersPage()

        {
            // click Partners
            find(By.Id("partnersList"))
                .Click();

        }

        public void addNewParter()
        {


            // click button add new partner
            find(By.Id("addPartnerBtn"))
                .Click();

            // name
            find(By.Name("partner.Name"))
                .SendKeys(checkName);

            // email
            find(By.Name("partner.Email"))
                .SendKeys(partnerEmail);

            // website
            find(By.Name("partner.CompanyWebsite"))
                .SendKeys(partnerWeb);

            // phone and fax
            find(By.Name("partner.Phone"))
                .SendKeys(partnerPhone);

            find(By.Name("partner.Fax"))
                .SendKeys(partnerFax);

            // adress 1st click
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[1]/div[8]/div/div/div/span/span[1]"))
                .Click();

            // choose adress
            find(By.Name("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[1]/div[8]/div/div/input[1]"))
                .SendKeys("riga");

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[1]/div[8]/div/div/ul/li/div[3]/a/div"))
                .Click();


            // category 1st click
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[1]/div[10]/div/div/div/span"))
                .Click();

            // category 2nd click (restaurant)
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[1]/div[10]/div/div/ul/li/div[3]/a/div"))
                .Click();

            // add description
            find(By.Name("partner.Description"))
                .SendKeys(partnerDescription);

            //// set picture URL
            //find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[2]/div[1]/div/button")).Click();
            //Thread.Sleep(5000);
            //// cancel 
            //find(By.XPath("/html/body/div[3]/div/div/form/div[3]/button[2]")).Click();
            //Thread.Sleep(5000);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[3]/div[2]/div/button[1]"))
                .Click();
            Thread.Sleep(5000);

        }

        public void checkNewPartnerCreated()
        {
            Thread.Sleep(5000);

            // press cancel
            find(By.Id("cancelBtn"))
                .Click();
            Thread.Sleep(5000);

            //Check.presence(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[1]/h5/span"));
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(checkName);
        }
    }
}

