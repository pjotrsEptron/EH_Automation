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

namespace EveryHairTestScripts
{
    public class openQuestionPage : SetupSteps

    {

        public IWebDriver driver;

        public void openPage()
        {
            // click advice tools
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[8]/a"))
                .Click();

            // click questions
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[8]/ul/li[1]/a/span/span"))
                .Click();


        }
    }
}

