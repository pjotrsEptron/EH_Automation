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
    public class addSalonDetails : SetupSteps
    {
        public static string phoneSalon = "37122311837";
        public static string emailBrand = "pjotrs@eptron.eu";
        public static string faxBrand = "09090909";
        public static string wwwSalon = "http://wwww.eptron.eu";


        public void addSalon()
        {
            IWebDriver driver = Driver.getDriver();
      
        // push details
        checkTitle = Generate.RandomString(4); // generate random text value

       

            find(By.Name("salon.Name")).SendKeys(checkTitle);
            find(By.Name("salon.Email")).SendKeys(emailBrand);
                find(By.Name("salon.Phone")).SendKeys(phoneSalon);
            find(By.Name("salon.Fax")).SendKeys(faxBrand);
            find(By.Name("salon.WebsiteUrl")).SendKeys(wwwSalon);
  
            // font selector
            new SelectElement(driver.FindElement(By.Name("salon.ThemeColor.Theme"))).SelectByText("PT Sans Caption");
            driver.FindElement(By.CssSelector("option[value=\"string:3\"]")).Click();

            // assigned langauge
            find(By.XPath("//div[16]/div/div/div/input")).Click();
            find(By.XPath("//a/div")).Click();

            // default language
            find(By.Name("LanguageId")).Click();

            // default langauge
            new SelectElement(driver.FindElement(By.Name("LanguageId"))).SelectByText("EN");
            driver.FindElement(By.CssSelector("option[value=\"number:1\"]")).Click();

            find(By.Id("logoUploadBtn")).Click();
           find(By.CssSelector("h4.modal-title")).Click();
            Thread.Sleep(5000); // to be removed
            SendKeys.SendWait(@"C:\Users\Pjotrs\Downloads\download.jpg");
            Thread.Sleep(50); // to be removed
            SendKeys.SendWait(@"{Enter}");
            find(By.Id("uploadBtn")).Click(); // upload
            Thread.Sleep(2000); // to be removed
            find(By.Id("saveBtn")).Click();

            //return new addSalonDetails();
        }   

        public void CheckSalonDetails(IWebDriver driver)

        {

            // press back button
            find(By.Id("backBtn")).Click();

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")));

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle);


        }
    }
}

