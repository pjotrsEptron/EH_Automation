using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using OpenQA.Selenium;
using EveryHairTestScripts.config;
using TechTalk.SpecFlow;

namespace EveryHairTestScripts
{
    [Binding]
    public class deleteProductYes : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();
        private string checkDeletedProduct;


        public void pageProductOpenedYes()
        {

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/ul/li[1]/a/tab-heading/span"));

        }

        public void clickDeleteButtonProd()
        {



            checkDeletedProduct = find(By.Name("product.BrandName")).Text;
            Thread.Sleep(3000);
            // click delete button
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div/fieldset/form/div[16]/div/button[4]"))
                .Click();

            Thread.Sleep(1500);            
            // check that pop-up is opened
            Check.presence(By.XPath("/html/body/div[3]/div/div/div/div[1]/div/span"));

        }

        public void clickYesButtonProd()
        {
            // clcik NO button
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[1]"))
                .Click();

        }

        public void checkProductDeleted()
        {

          
            
            Thread.Sleep(5000);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input"))
                .SendKeys(checkDeletedProduct);

        }
    }
}