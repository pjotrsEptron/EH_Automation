using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Timers;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using System.Windows.Forms;

namespace EveryHairTestScripts
{
    [Binding]
    public class notifications : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        public void openNotification()
        {
            // click Settings
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[12]/a/span[1]/span")).Click();

            // click notifications
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[12]/ul/li[6]/a/span/span")).Click();

            // check notifications page opened
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div/div[2]/div[2]/div[1]/div[1]/h2/span")));



        }

        public void composeNewMessage()
        {
            checkTitle = Generate.RandomString(4); // generator for random text

            // click compose message
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/a/span/span")).Click();

            // check that popupopened
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/div[1]/div/span/span")));

            // type Subject
            find(By.XPath("/html/body/div[3]/div/div/div[2]/div[1]/table/tbody/tr[2]/td[2]/input")).SendKeys(checkTitle);
            Thread.Sleep(1000);

            // type message
            find(By.XPath("/html/body/div[3]/div/div/div[2]/textarea")).SendKeys(checkTitle);
            Thread.Sleep(3000);

            // click Send button
            find(By.XPath("/html/body/div[3]/div/div/div[2]/div[2]/table/tbody/tr/td[1]/button[2]")).Click();
            Thread.Sleep(3000);


        }

     
        public void cancelMessage()
        {
            // click Cancel button
            find(By.XPath("/html/body/div[3]/div/div/div[2]/div[2]/table/tbody/tr/td[2]/button")).Click();
            Thread.Sleep(1000);

        }

        public void draftMessage()
        {
            // click Draft BUtton
            find(By.XPath("/html/body/div[3]/div/div/div[2]/div[2]/table/tbody/tr/td[1]/button[1]")).Click();
            Thread.Sleep(1000);

        }

        public void checkDraftMessage()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle);
            Thread.Sleep(1000);

        }

        public void checkMessageSent()
        {

            Thread.Sleep(3000);

            // click Sent button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/table/tbody/tr[2]/td[1]/span/span")).Click();
            Thread.Sleep(3000);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle);
            Thread.Sleep(3000);

        }

        public void checkDraftMessageInFolder()
        {

            // click Drafts button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/table/tbody/tr[3]/td[1]")).Click();

            // wait
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div[1]/div[2]/div/label/input"));

            // check that message has Draft Symbol
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div/table/tbody/tr[1]/td[2]/span")));

        }

        public void listing()
        {
            // click at Listing
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div[1]/div[1]/div/label/select")).Click();

            // click 100 at listing
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div[1]/div[1]/div/label/select/option[4]")).Click();
        }
    }
}
