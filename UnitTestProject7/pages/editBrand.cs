using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using System.Windows.Forms;

namespace EveryHairTestScripts
{
    public class editBrand : SetupSteps

    {

        public IWebDriver driver;
        public static string editedBrandName;


    
        public void openBrandForEdit()
        {
            // click open detail
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[4]/div/button[1]"))
                .Click();

        }

        public void editBrandName()
        {
            editedBrandName = Generate.RandomString(4);

            // updated values block
            find(By.Name("brand.Name")).Clear();
            find(By.Name("brand.Name")).SendKeys(editedBrandName);
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[3]/div/input"))
                .Clear();
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[3]/div/input"))
                .SendKeys("edited");
            Thread.Sleep(2000);
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[2]/div/input"))
                .Clear();
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[2]/div/input"))
               .SendKeys("edited@eptron.eu");
            Thread.Sleep(2000);
            ///////

            // click save
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[6]/div/button[1]"))
                .Click();
        }

        public void checkEditedBrandName()
        {

            find(By.XPath("html/body/div/div/div[2]/div[2]/div[1]/div[1]/button"))
                .Click();
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                 .SendKeys(editedBrandName);
     

        }
    }
}


