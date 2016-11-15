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
    public class openBrandPage : SetupSteps

    {


        public void openBrands()
        {
            // click settings
            find(By.XPath("html/body/div[1]/div/div[1]/nav/div/ul/li[12]/a"))
                .Click();

            // click brands
            find(By.XPath("html/body/div[1]/div/div[1]/nav/div/ul/li[12]/ul/li[4]/a/span/span"))
                .Click();


        }

        public void checkBrandsPage()
        {
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[1]/div[1]/h2/span"));
            Check.presence(By.XPath("html/body/div/div/div[2]/div[2]/div[1]/div[1]/h2/span"));
        }

    }
}
