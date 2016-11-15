using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
   public class editProfile : SetupSteps
    {
 

        By firstName = By.Name("employee.FirstName");
        By middleName = By.Name("employee.MiddleName");
        By lastName = By.Name("employee.LastName");
        By description = By.Name("employee.Description");
        By uploadBtn = By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[2]/div[1]/div/button");
        By browse = By.XPath("/html/body/div[3]/div/div/div/div[2]/div/div[1]/div[3]/div[1]/input");
        By crop = By.XPath("/html/body/div[3]/div/div/div/div[2]/div/div[1]/div[3]/div[2]/button");
        By iosTab = By.XPath("/html/body/div[3]/div/div/div/div[2]/div/div[1]/div[1]/button[2]");
        By saveImage = By.XPath("/html/body/div[3]/div/div/div/div[3]/button[1]");

        public void editFields(IWebDriver driver)
        {
    //        checkTitle = Generate.RandomString(4);
           find(firstName).SendKeys("abcd");
           find(middleName).SendKeys("abcd");
           find(lastName).SendKeys("abcd");

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[1]/div[7]/div/div[1]/div/span/i")).Click();

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[1]/div[7]/div/div[1]/ul/li/div[4]/a/div")).Click();
           find(description).SendKeys("description");
           find(uploadBtn).Click();
           find(browse).Clear();
           find(By.CssSelector("input.fileSelectButton")).SendKeys("C:\\Users\\Pjotrs\\Downloads\\download1.jpg");
           find(crop).Click();
           find(iosTab).Click();
           find(crop).Click();
           find(saveImage).Click();
            Thread.Sleep(2000);
        }

        public void saveButtonAfterEdit(IWebDriver driver)
        {
            // press save
            find(By.XPath("//div[2]/div/button")).Click();
            Thread.Sleep(5000);
        }
    }
}



