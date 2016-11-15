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
    public class deactivateActivatePartners : SetupSteps

    {

        public IWebDriver driver;



        public void openCreatedPartner()
        {
            // click view at found partner
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[6]/div/button")).Click();
        }

        public void pressActivateButton()
        {
            // press activate
            find(By.Id("activateBtn")).Click();
            Thread.Sleep(5000);
        }

        public void pressDeactivateButtonForPartners()
        {
            // press deactivate buttoin
            find(By.Id("deactivateBtn")).Click();
            Thread.Sleep(5000);

        }
    }


}
