using OpenQA.Selenium;
using System.Threading;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using TechTalk.SpecFlow;

namespace EveryHairTestScripts
{
    [Binding]
    public class DeleteConfirmCancelEmployee : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        [When(@"Open Any Employee from a List")]
        public void WhenOpenAnyEmployeeFromAList()
        {
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[5]/a/span/span")).Click(); // click on Employee menu
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[7]/div/button")).Click(); // open employee
        }

        [Then(@"i can click Delete button")]
        public void ThenICanClickDeleteButton()
        {

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[3]/div[2]/div/button[4]")).Click(); //click delete action

        }

        [Then(@"i can cancel delete Action of Empoloyee")]
        public void ThenICanCancelDeleteActionOfEmpoloyee()
        {
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[2]")).Click(); // cancel delete
        }
    }
}
        

