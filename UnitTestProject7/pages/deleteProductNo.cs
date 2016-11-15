using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using OpenQA.Selenium;
using EveryHairTestScripts.config;

namespace EveryHairTestScripts
{
    public class deleteProductNo : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        public void pageProductOpened()
        {

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/ul/li[1]/a/tab-heading/span"));

        }

        public void clickDeleteButtonProd()
        {

            // click delete button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[16]/div/button[4]"))
                .Click();

            // check that pop-up is opened
            Check.presence(By.XPath("/html/body/div[3]/div/div/div/div[1]/div/span"));

        }

        public void clickNoButtonProd()
        {
            Thread.Sleep(1500);
            // clcik NO button
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[2]"))
                .Click();
        }
    }
}