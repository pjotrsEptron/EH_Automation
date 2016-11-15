using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using NUnit.Framework;
using EveryHairTestScripts.config;

namespace EveryHairTestScripts
{
    public class filteringContacts : SetupSteps

    {

        public IWebDriver driver;
        // define type of contacts
        public static string Complaint = "Complaint";
        public static string Question = "Question";
        public static string Feedback = "Feedback";


public void chooseTypeAll()
{

    // choose filter ALL
    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[1]/select[1]"))
        .Click();


            // choose ALL from a list
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[1]/select[1]/option[2]"))
 .Click();


            // validation
            string test = find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[2]/table/tbody/tr[1]/td[1]")).Text;
            Assert.IsTrue(test.Equals(Complaint));
        }

        public void chooseTypeComplaint()
{
    // choose filter ALL
    find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[1]/select[1]"))
        .Click();


            // choose Complaint from a list
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[1]/select[1]/option[3]"))
        .Click();

            // validation
            string test = find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[2]/table/tbody/tr[1]/td[1]")).Text;
            Assert.IsTrue(test.Equals(Complaint));

        }

        public void chooseTypeFeedBack()
{
            // choose filter ALL
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[1]/select[1]"))
                .Click();

            // click feedback 
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[1]/select[1]/option[4]"))
                .Click();

            // validation
            string test = find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[2]/table/tbody/tr[1]/td[1]")).Text;
            Assert.IsTrue(test.Equals(Feedback));

        }

        public void chooseTypeQuestion()
{
            // choose filter ALL
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[1]/select[1]"))
                .Click();

            // click question
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[1]/select[1]/option[5]"))
                .Click();

            // validation
            string test = find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div[2]/table/tbody/tr[1]/td[1]")).Text;
            Assert.IsTrue(test.Equals(Question));




        }
    }
}
