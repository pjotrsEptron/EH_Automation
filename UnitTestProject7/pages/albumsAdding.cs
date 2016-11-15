using OpenQA.Selenium;
using System.Threading;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using OpenQA.Selenium.Support.UI;
using System;
using System.Windows.Forms;

namespace EveryHairTestScripts
{
    public class albumsAdding : SetupSteps

    {
        IWebDriver driver = Driver.getDriver();

        public void createAlbum()

        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/ul/li[3]/a/tab-heading/span")).Click(); //click Albums tab
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[1]/div/a/span/span")).Click();
            checkTitle = Generate.RandomString(4);
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div/input")).SendKeys(checkTitle);  // enter album title

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[3]/div/div/div/div[3]/button[1]")));

            find(By.XPath("/html/body/div[3]/div/div/div/div[3]/button[1]")).Click(); // save album

        }



        public void addImagesToAlbum()
        {

            Thread.Sleep(3000);
            // check that albums is created
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle);


            // click on selected album  
            WebDriverWait wait2 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait2.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/table/tbody/tr/td[6]/div/button[1]")));
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/table/tbody/tr/td[6]/div/button[1]"))
.Click();


            // add description   
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/div/div/div/fieldset/form/div[1]/div[2]/div/textarea")).Click();
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/div/div/div/fieldset/form/div[1]/div[2]/div/textarea")).SendKeys("automated");





            // image uploading part
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/div/div/div/fieldset/form/div[2]/div[1]/div/button")).Click();
            find(By.XPath("/html/body/div[3]/div/div/form/div[1]/div/i")).Click();


            SendKeys.SendWait(@"C:\Users\Pjotrs\Downloads\download.jpg");
            Thread.Sleep(50); // to be removed
            SendKeys.SendWait(@"{Enter}");





            Thread.Sleep(3000);
            // wait untill upload button is visible
            WebDriverWait wait3 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait3.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[3]/div/div/form/div[3]/button[1]")));
            find(By.XPath("/html/body/div[3]/div/div/form/div[3]/button[1]")).Click();
        }


        public void clickSaveChangesButton()
        {

            Thread.Sleep(3000);

            // wait untill save become active
            WebDriverWait wait4 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait4.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[1]")));
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[1]")).Click(); // save album
            Thread.Sleep(3000);
        }

        public void addOneImage()
        {

            // add content to album
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/div/button")).Click();
            find(By.XPath("/html/body/div[3]/div/div/form/div[1]/div/i")).Click();
            SendKeys.SendWait(@"C:\Users\Pjotrs\Downloads\download1.jpg");
            Thread.Sleep(50); // to be removed
            SendKeys.SendWait(@"{Enter}");

            
        }

        //public void deleteOneImage()
        //{

        //    // delete one iamge
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div[2]/div/div/div/div/a/span")).Click();
        //}

        //public void addOneImageAgain()
        //{

        //    // add content to album
        //    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/div/button")).Click();
        //    find(By.XPath("/html/body/div[3]/div/div/form/div[1]/div/i")).Click();
        //    SendKeys.SendWait(@"C:\Users\Pjotrs\Downloads\download1.jpg");
        //    Thread.Sleep(50); // to be removed
        //    SendKeys.SendWait(@"{Enter}");
        //    find(By.XPath("/html/body/div[3]/div/div/form/div[3]/button[1]")).Click(); // upload 

        //}

        public void addTwoImage()

        {

            // add content to album
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/div/button")).Click();
            find(By.XPath("/html/body/div[3]/div/div/form/div[1]/div/i")).Click();
            SendKeys.SendWait(@"C:\Users\Pjotrs\Downloads\download1.jpg");
            Thread.Sleep(50); // to be removed
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(3000);

            find(By.XPath("/html/body/div[3]/div/div/form/div[1]/div/i")).Click();
            Thread.Sleep(3000);
            SendKeys.SendWait(@"C:\Users\Pjotrs\Downloads\download.jpg");
            Thread.Sleep(50); // to be removed
            SendKeys.SendWait(@"{Enter}");

            find(By.XPath("/html/body/div[3]/div/div/form/div[3]/button[1]")).Click(); // upload 
            Thread.Sleep(3000);

        }


    }
}