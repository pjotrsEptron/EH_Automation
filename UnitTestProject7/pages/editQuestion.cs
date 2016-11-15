using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using NUnit.Framework;

namespace EveryHairTestScripts
{
    public class editQuestion : SetupSteps

    {

        public IWebDriver driver;
       // private static string editedQuestionValue;


        public void openQuestion()
        {
            // click view button after question is found in previous step
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[4]/div/button"))
                .Click();
        }

        public void editQuestionDetail()
        {
            //  editedQuestionValue = find(By.Name("question.Value")).Text;
         //   editedQuestionValue = find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr/td[2]")).Text;

            checkTitle = Generate.RandomString(10); // generate random text value

            // remove value of name
            find(By.Name("question.Value"))
               .Clear();

            // add value name with 10 string
            find(By.Name("question.Value"))
                .SendKeys(checkTitle);

            // clear descr
                       find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[2]/div/textarea"))
.Clear();
            // description
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[2]/div/textarea"))
.SendKeys("automated and edited");


            // delete featire
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div[2]/div/div/div/span/span[1]/span/span[1]"))
                .Click();

            // click to select new
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div[2]/div/div/div/input"))
                .Click();


            // select any random
            //IList<IWebElement> options = driver.FindElements(By.CssSelector(".ui-select-choices-row-inner"));
            // foreach (IWebElement option in options)
            // {
            //     option.Click();
            // }

            // select first
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div[2]/div/div/ul/li/div[3]/a/div"))
                .Click();
        }

        public void saveEditedAnswer()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[9]/div/button[1]"))
                .Click();
        }

        public void checkEditedQuestion()
        {

            // click cancel to go to list view
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[9]/div/button[2]"))
                .Click();

            // click another link 
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[9]/a/span/span"))
                .Click();

            Thread.Sleep(1500);

            // click back to question
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[8]/a/span[1]/span"))
                .Click();

            // click question link
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[8]/ul/li[1]/a/span/span"))
                .Click();
            Thread.Sleep(1500);

            // click to search panel, to cheсk
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(checkTitle);

            Assert.IsTrue(checkTitle.Equals(checkTitle));
        }
    }
}