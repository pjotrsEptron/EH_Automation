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

namespace EveryHairTestScripts
{
    [Binding]
    public class AddSalonSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();



        [Given(@"Salon list")]
        public void GivenSalonList()
        {
            find(By.XPath("//ul[@id='side-menu']/li[4]/a/span")).Click();
            Assert.IsTrue(IsElementPresent(By.CssSelector("h5.ng-binding")));

        }

       
        [Given(@"i click add new saloon bytton")]
        public void GivenIClickAddNewSaloonBytton()
        {
           find(By.LinkText("Add new salon")).Click();



        }


        [When(@"new page of saloon is opened")]
        public void WhenNewPageOfSaloonIsOpened()
        {
            Assert.IsTrue(IsElementPresent(By.CssSelector("tab-heading.ng-scope")));



        }
        [Then(@"i fill all details")]
        public void ThenIFillAllDetails()

        {

          
            addSalonDetails addSalon = new addSalonDetails();
            addSalon.addSalon();

        }

        [Then(@"press save button to save")]
        public void ThenPressSaveButtonToSave()
        {
            Thread.Sleep(2000);

            find(By.XPath("//div[3]/div[2]/div/button")).Click(); // save
            Thread.Sleep(2000);

        }
        [When(@"saloon is saved i go back to list and check it")]
        public void WhenSaloonIsSavedIGoBackToListAndCheckIt()
        {

            Thread.Sleep(5000);
            addSalonDetails CheckSalonDetails = new addSalonDetails();
            CheckSalonDetails.CheckSalonDetails(driver);
            Assert.AreEqual(checkTitle, find(By.XPath("//td[2]")).Text);

        }





        private bool IsElementPresent(By by)
        {
            try
            {
               find(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }



    }
}

