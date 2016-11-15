using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Timers;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using System.Windows.Forms;

namespace EveryHairTestScripts
{
    [Binding]
    public class editSalon : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();


        public void editSalonDetails()
        {

            By SalonName = By.Name("salon.Name");
            By salonEmail = By.Name("salon.Email");
            By salonPhone = By.Name("salon.Phone");
            By salonFax = By.Name("salon.Fax");
            By salonURl = By.Name("salon.WebsiteUrl");

            By wereactURL = By.Name("salon.WeReactUrl");

            // push details
            checkTitle = Generate.RandomString(4); // generate random text value
           find(SalonName).Clear();

           find(SalonName).SendKeys(checkTitle);
           find(salonURl).SendKeys("http://www.eptron.eu");

            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[1]/div[9]/div/input")).Click();
            find(By.XPath("/html/body/div[2]/div/colorpicker-saturation")).Click();
            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[1]/div[12]/div/div/div/span")).Click();
            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[1]/div[12]/div/div/input[1]")).SendKeys("riga, La");
            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[1]/div[12]/div/div/ul/li/div[3]/a/div[1]")).Click();
            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[1]/div[14]/div/div/div/input")).Click();
            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/fieldset/form/div[1]/div[14]/div/div/ul/li/div[3]/a")).Click();

           find(By.Name("salon.WeReactUrl")).Clear();
           find(By.Name("salon.WeReactUrl")).SendKeys("http://www.wereact.lv");
           find(By.CssSelector("div.col-sm-9 > button.btn.btn-primary")).Click();
           find(By.CssSelector("h4.modal-title")).Click();
            Thread.Sleep(5000); // to be removed
            SendKeys.SendWait(@"C:\Users\Pjotrs\Downloads\download1.jpg");
            Thread.Sleep(50); // to be removed
            SendKeys.SendWait(@"{Enter}");
            find(By.XPath("//div[3]/button")).Click(); // upload
            Thread.Sleep(2000); // to be removed

            //return new addSalonDetails();
        }

        public void CheckSalonDetails()

        {

            // press back button
            find(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[1]/div[1]/button")).Click();
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[5]/a")).Click();
            Thread.Sleep(1000);
            find(By.XPath("/html/body/div[1]/div/div[1]/nav/div/ul/li[4]/a")).Click();
            Thread.Sleep(1000);

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")));
            Thread.Sleep(1000);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle);


        }
    }
}

