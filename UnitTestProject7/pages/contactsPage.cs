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

namespace EveryHairTestScripts
{
    public class contactPage : SetupSteps

    {

        public IWebDriver driver;
     

        public void openContactPage()
        {

            // open Contacts
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[10]/a/span[1]/span"))
                .Click();
        }
    }
}