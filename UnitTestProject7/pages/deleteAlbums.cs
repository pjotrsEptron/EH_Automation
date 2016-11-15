using OpenQA.Selenium;
using System.Threading;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using OpenQA.Selenium.Support.UI;
using System;

namespace EveryHairTestScripts
{
    public class deleteAlbums : SetupSteps

    {
        IWebDriver driver = Driver.getDriver();

        public void clickDeleteImage()

        {
            // click red cross
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div[2]/div/div/div[1]/div/a/span/i")).Click();
        }

        public void goBackToAlbumsList()
        {

            // click back button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[1]/div[1]/button")).Click(); 
        }

        public void Albums()
        {


            // wait untill save become active
            WebDriverWait wait1321 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait1321.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")));
           find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle); // add album name in search field

        }

        public void pressDeleteInAlbums()
        {

            Thread.Sleep(3000);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/table/tbody/tr/td[6]/div/button[2]")).Click();
           
            //// wait untill save become active
            //WebDriverWait wait101 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //wait101.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/div/div[1]")));
        }

        public void pressNo()
        {
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[2]")).Click();
            
        }

        public void pressYes()
        {
            //find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/table/tbody/tr/td[6]/div/button[2]")).Click();
            //// wait untill save become active
            //WebDriverWait wait101 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //wait101.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/div/div[1]")));

            Thread.Sleep(3000);

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[1]")).Click();
        }

        public void checkDeletedAlbum()
        {
           find(By.CssSelector("input.form-control.input-sm")).SendKeys(checkTitle); // add album name in search field

        }

    }
}
