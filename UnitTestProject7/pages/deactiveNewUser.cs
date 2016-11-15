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
    public class deactivateNewUser : SetupSteps

    {

        public IWebDriver driver;

        public void openEditedUserProfile()
        {

            // settings
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[12]/a")).Click();
            // users
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[12]/ul/li[5]/a/span/span")).Click();

            // open any user
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/table/tbody/tr[1]/td[6]/div/button")).Click();


        }

        public void clickDeactivateUser()
        {
            // click deactivate buttin
            find(By.XPath(".//*[@id='page-wrapper']/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[15]/div/button[3]")).Click();
            Thread.Sleep(3000);

        }

    
        public void clickActivateUser()
        {
            // click activate button
            find(By.XPath(".//*[@id='page-wrapper']/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[15]/div/button[3]")).Click();
            Thread.Sleep(5000);

        }

    }
}
