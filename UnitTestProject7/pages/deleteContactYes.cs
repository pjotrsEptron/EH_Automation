using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using System.Windows.Forms;

namespace EveryHairTestScripts
{
    public class deleteContactYes : SetupSteps

    {

        public IWebDriver driver;
        private string checkContactNotDeletedd;
        public static string Question = "Question";
      

        public void openContactWindow()
        {
                   
            Thread.Sleep(5000);
            // open windows by pressing details (question)
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[2]/table/tbody/tr/td[7]/div/button"))
                .Click();

        }

        public void pressDeletButtonInContact()
        {

            Thread.Sleep(3000);

            checkContactNotDeletedd = find(By.XPath("/html/body/div[3]/div/div/div[1]/div/span")).Text;

            // click delete button
            find(By.XPath("/html/body/div[3]/div/div/div[2]/div[2]/div/div[2]/button[1]"))
                .Click();
            Thread.Sleep(5000);

        }

        public void pressDeleteContactYES()
        {

            // press delete button YES
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[1]"))
                .Click();
            Thread.Sleep(5000);
        }

        public void contactDeleted()
        {
            // click to search
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[2]/div[1]/div[2]/div/label/input"))
                .Click();

            // clear field if need
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[2]/div[1]/div[2]/div/label/input"))
                .Clear();

            // enter deleted contact
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[2]/div[1]/div[2]/div/label/input"))
                .SendKeys(checkContactNotDeletedd);

         //   Assert.IsTrue(checkContactNotDeletedd.Equals(Question));

        }
    }
}
