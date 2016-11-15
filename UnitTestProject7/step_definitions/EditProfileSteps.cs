using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]
    public class EditProfileSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        [When(@"any user page is opened")]
        public void WhenAnyUserPageIsOpened()
        {
           // Assert.IsTrue(IsElementPresent(By.CssSelector("h2.ng-binding")));
           // IWebElement driver. = find(By.XPath("//*[@class='fa fa-pencil']"));
           //find(SwitchButtons).Click();
           // Thread.Sleep(5000);

        }

        [Then(@"i can update fields")]
        public void ThenICanUpdateFields()
        {


            editProfile editFields = new editProfile();
            editFields.editFields(driver);
        }

        [Then(@"press save button")]
        public void ThenPressSaveButton()
        {



            editProfile saveButtonAfterEdit = new editProfile();
            saveButtonAfterEdit.saveButtonAfterEdit(driver);



        }

        [Then(@"i will see an updated profile")]
        public void ThenIWillSeeAnUpdatedProfile()
        {


            // go back
            Thread.Sleep(1000); // // to be removed/changed to implicity
          find(By.CssSelector("button.btn.btn-white")).Click();
            Thread.Sleep(1000);
           find(By.XPath("//input[@type='search']")).SendKeys(checkTitle);
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
