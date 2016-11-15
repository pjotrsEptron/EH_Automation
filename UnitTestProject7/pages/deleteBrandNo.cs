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
    public class deleteBrandNo : SetupSteps

    {

        public IWebDriver driver;
        private string brandForDeleteValue;
        public static string Question = "Question";

        public void openBrandForDelete()
        {
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[4]/div/button[1]"))
                .Click();
        }

        public void pressDelBrand()
        {

            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div/div[6]/div/button[4]"))
                .Click();
        }

        public void pressDelBrandNo()
        {


            find(By.XPath("html/body/div[3]/div/div/div/div[2]/button[2]"))
                .Click();

        }

        public void pressDelbrandYes()
        {
            brandForDeleteValue = find(By.Name("brand.Name")).Text;

            find(By.XPath("html/body/div[3]/div/div/div/div[2]/button[1]"))
            .Click();
        }


        public void checkBrandDeleted()
        {

            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(brandForDeleteValue);

        }
    }
}