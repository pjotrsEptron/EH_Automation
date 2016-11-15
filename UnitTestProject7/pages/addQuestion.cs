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
    public class addQuestion : SetupSteps

    {

        public IWebDriver driver;
        public void AddNewQuestion()
        {

            // click button
            find(By.Id("addQuestionBtn"))
                .Click();
        }

        public void questionInfo()
        {

            checkTitle = Generate.RandomString(4); // generate random text value

            // add value name
            find(By.Name("question.Value"))
                .SendKeys(checkTitle);

//            // description
//            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[2]/div/textarea"))
//.SendKeys("automated");

        }

        public void addNewAnswer()
        {
            // add new answer
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div/button"))
                 .Click();

            // answer type single     
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[3]/div/label[1]/input"))
      .Click();


            // descr
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div[1]/div[1]/div/input"))
                .SendKeys("automated2");

            // get list of features
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div[2]/div/div/div/input"))
                            .Click();

            // set 1st
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div[2]/div/div/ul/li/div[3]/a/div"))
                .Click();

            // get list of features
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div[2]/div/div/div/input"))
                            .Click();

            // set 2nd
            find(By.XPath("//div[4]/a/small/span/span"))
                .Click();
        }

        public void removeAnswers()
        {

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[6]/div[1]/div[2]/button"))
                .Click();
        }

        public void saveAnswer()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[9]/div/button[1]"))
                .Click();
        }

        public void checkQuestionAdded()
        {
            // clickl back button
           find(By.XPath("/html/body/div/div/div[2]/div[2]/div[1]/div[1]/button"))
                .Click();

            // click to profiles to drop
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[9]/a/span/span"))
                .Click();

            // click tool
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[8]/a"))
                .Click();

            // click questions
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[8]/ul/li[1]/a"))
                .Click();

            // click search
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .Click();

            // type created question name
             find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(checkTitle);

            Assert.IsTrue(checkTitle.Equals(checkTitle));
        }
    }
}