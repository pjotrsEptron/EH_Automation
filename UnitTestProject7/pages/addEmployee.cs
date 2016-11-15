using OpenQA.Selenium;
using System.Threading;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    public class addEmployee : SetupSteps

    {
        IWebDriver driver = Driver.getDriver();
        // define all steps
        By firstName = By.Name("employee.FirstName");
        By middleName = By.Name("employee.MiddleName");
        By lastName = By.Name("employee.LastName");
        By DOB = By.Name("employee.dob");
        By Date = By.XPath("//tr[2]/td[5]/button");
        By positionCLick = By.CssSelector("i.caret.pull-right");
        By positionClickAgain = By.CssSelector("a.ui-select-choices-row-inner > div.ng-binding.ng-scope");
        By description = By.Name("Description0");
        // image uploader definition
        By uploadBtn = By.Id("pictureUploadBtn");
        By browse = By.XPath("html/body/div[1]/div/div/div/div[2]/div/div[1]/div[3]/div[1]/input");
        By crop = By.Id("cropBtn");
        By iosTab = By.Id("iosBtn");
        By saveImage = By.Id("saveBtn");

        public void fillAndSubmitForm()

        {
           checkTitle = Generate.RandomString(4);
           find(firstName).SendKeys(checkTitle);
           find(middleName).SendKeys("abcd");
           find(lastName).SendKeys("abcd");
            find(DOB).Click();
            find(Date).Click();

            find(positionCLick).Click();
            find(positionClickAgain).Click();
            
            find(description).SendKeys("description");

            find(uploadBtn).Click();
           find(browse).Clear();
           find(By.CssSelector("input.fileSelectButton")).SendKeys("C:\\Users\\Pjotrs\\Downloads\\download.jpg");
           find(crop).Click();
           find(iosTab).Click();
           find(crop).Click();
           find(saveImage).Click();
            Thread.Sleep(2000);

        }

        public void clickSaveButton(IWebDriver driver)
        {
            // save
            find(By.Id("saveBtn")).Click();
            Thread.Sleep(1000); //to be removed/changed to implicity
        }

        public void clickActivateButton(IWebDriver driver)
        {
            // press activate
            find(By.Id("activateBtn")).Click();

           
        }

    }
}
