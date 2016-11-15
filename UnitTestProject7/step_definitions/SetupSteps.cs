using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]
    public class SetupSteps
    {
     public static string checkTitle;

        [BeforeFeature]
        private static void Setup()
        {

            IWebDriver driver = Driver.init("https://test-hairdressers-adminpanel.azurewebsites.net/#/login");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            // define elements
            By loginField = By.XPath("//input[@type='text']");
            By passwordField = By.XPath("//input[@type='password']");
            By submitButton = By.XPath("//button[@type='submit']");
            By settingsLink = By.LinkText("Settings");
            By companiesLInk = By.Id("settingsCompanies");
            By sixthpage = By.LinkText("5");
            By switcherButton = By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[8]/div/button[1]");

            // details
            string password = "M2q7zlFy";
            string login = "pjotrs@eptron.eu";
           // string wrongdetails = "asdasd2";

           //// submit credentials for failed case 
           //find(loginField).SendKeys(login);
           //find(passwordField).SendKeys(wrongdetails);
           //find(submitButton).Click();

           // submit credentials for success case 
           find(loginField).SendKeys(login);
           find(passwordField).SendKeys(password);
           find(submitButton).Click();

            // proceed to company
           find(settingsLink).Click();
          find(companiesLInk).Click();
          find(sixthpage).Click();

          find(switcherButton).Click();
          find(By.LinkText("Company")); // last step

            System.Threading.Thread.Sleep(5000); // to be removed
        }


        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.getDriver().Dispose();
        }
    }
}