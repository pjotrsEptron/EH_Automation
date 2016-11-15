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
    public class openBrandCompanies : SetupSteps

    {

        public IWebDriver driver;

        public void openBrand1()
        {
            // pass value of a brand name
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .Clear();
            // pass value of a brand name
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys("DUREX");
            Thread.Sleep(2000);
            // open this brand name
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[4]/div/button[1]"))
                .Click();
        }

        public void brandCompaniesTab()
        {

            // open brand comp. tab
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/ul/li[2]/a/tab-heading/span"))
                .Click();
        }

        public void checkList()
        {
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div[1]/div[2]/div/label/input"))
                .SendKeys("Café de Beauté");

            Assert.AreEqual("Café de Beauté", driver.FindElement(By.XPath("//table[@id='DataTables_Table_18']/tbody/tr/td[2]")).Text);

        }
    }
}


