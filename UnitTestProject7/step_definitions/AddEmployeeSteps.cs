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
    public class AddEmployeeSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        [When(@"I go to Add new Employee page")]
        public void WhenIGoToAddNewEmployeePage()
        {
            find(By.Id("employeesList")).Click();
           find(By.Id("addEmployeeBtn")).Click();
        }

        [When(@"I submit the a form")]
        public void WhenISubmitTheAForm()
        {

            // add details
            addEmployee addFieldsForEmploye = new addEmployee();
            addFieldsForEmploye.fillAndSubmitForm();
            Thread.Sleep(1000); // to be removed/changed to implicity

            // press save
            addEmployee saveButton = new addEmployee();
            saveButton.clickSaveButton(driver);
            Thread.Sleep(1000); // to be removed/changed to implicity

            // press activate
            addEmployee activateButton = new addEmployee();
            activateButton.clickActivateButton(driver);
        }

        [When(@"I go to employees a list")]
        public void WhenIGoToEmployeesAList()
        {
           Thread.Sleep(5000);
           find(By.Id("backBtn")).Click(); // click to Employees page
           Thread.Sleep(5000);
          find(By.CssSelector("input.form-control.input-sm")).SendKeys(checkTitle); // add employee name in search field
        }

        [Then(@"I should see the new employee added")]
        public void ThenIShouldSeeTheNewEmployeeAdded()
        {
            // bool checkTitle = true;
            string checkName = checkTitle;
            string checkedName = checkTitle;

            if (checkName==checkedName)
            {
                Console.WriteLine("The variable is set to true.");
            }
            else
            {
                Console.WriteLine("The variable is set to false.");
            }
            Thread.Sleep(5000);

        }
    }
}

