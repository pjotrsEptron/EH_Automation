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
    public class addPromotional : SetupSteps

    {

        public IWebDriver driver;

        public void addNewPromotional()
        {
            // open promotional page
            find(By.Id("promotionsList")).Click();

            // press add new promotional button
            find(By.Id("addPromotionBtn")).Click();

            // check new window
            Check.presence(By.CssSelector("css=h2.ng-binding"));
        }
        
        public void promotionalCancel()
        {
            // check again window
            // click cancel button
            // redirected to promotional page

        }

        public void savePromotionalDetails()
        {
            // press add new promotional button
            // fill all details
            // press save button

        }

        public void activatePromotional()
        {
            // check that im in promotional page
            // click activate button
            // promotional activated
            // go back

        }
    }
}
