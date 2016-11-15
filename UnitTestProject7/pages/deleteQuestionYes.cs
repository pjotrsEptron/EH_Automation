using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;

namespace EveryHairTestScripts
{
    public class deleteQuestionYes : SetupSteps

    {

        public IWebDriver driver;
        private string checkQuestionDeletedd;
        //private string checkQuestionDeleteddd;
     //   private static string empty = "No matching records found";



        public void pressDeleteButton()
        {
            checkQuestionDeletedd = find(By.Name("question.Value")).Text;

            // click delete question
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[9]/div/button[4]"))
                .Click();
            Thread.Sleep(1500);


        }

        public void pressYesButtonToDelete()
        {

            // click yes button
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[1]"))
                .Click();
            Thread.Sleep(1500);

        }

        public void passQuestionTitle()
        {

            // clear if need
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .Clear();
            Thread.Sleep(1500);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(addQuestion.checkTitle);

        }
        public void checkQuestionIsDeleted()

        {
            // clear if need
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .Clear();
            Thread.Sleep(1500);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(addQuestion.checkTitle);

            Assert.AreEqual("No matching records found", driver.FindElement(By.XPath("//table[@id='DataTables_Table_17']/tbody/tr/td")).Text);
            Thread.Sleep(3000);
        }
    }
}
