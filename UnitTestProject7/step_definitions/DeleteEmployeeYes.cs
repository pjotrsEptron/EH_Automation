using OpenQA.Selenium;
using System.Threading;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using TechTalk.SpecFlow;


namespace UnitTestProject7
{
    [Binding]
    public class AddNewEmployee_OpenList_Delete_Cancel_Delete_EditSteps
    {
        IWebDriver driver = Driver.getDriver();

        [When(@"i go to EmployeeList again")]
        public void WhenIGoToEmployeeListAgain()
        {
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[5]/a/span/span")).Click(); // click on Employee menu
            
        }

        [When(@"Open previous Employee")]
        public void WhenOpenPreviousEmployee()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[7]/div/button")).Click(); // open employee      
        }


        [Then(@"i can delete user from a list")]
        public void ThenICanDeleteUserFromAList()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[3]/div[2]/div/button[4]")).Click(); //click delete action
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[1]")).Click(); // click YES        }
        }
    }
}


