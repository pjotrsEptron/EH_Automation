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
    public class addFeatures : SetupSteps

    {

        public IWebDriver driver;

       public void openFeaturePage()
        {
            // click products
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[7]/a/span[1]/span")).Click();

            // click prod. features
            find(By.Id("featuresList")).Click();

        }

        public void addNewFeature() // create a new featre
        {
            checkTitle = Generate.RandomString(4);

            // click add new feature
            find(By.Id("addFeatureBtn")).Click();

            // make checker, that page is opened
            find(By.Name("feature.Name")).SendKeys(checkTitle);
            find(By.Name("feature.Description")).SendKeys("automated");
            find(By.Id("SaveChanges]")).Click(); // click save button

            // make checker

            Thread.Sleep(3000);
            find(By.Id("cancelBtn")).Click(); // cancel button
     }
        public void checkCreatedFeature() // check it
        {

            // use search tofind a new feture

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle);
            // if exists, then open it as View

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[4]/div/button")).Click();
        }
    }
}







