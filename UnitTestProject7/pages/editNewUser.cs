using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using System.Windows.Forms;

namespace EveryHairTestScripts
{
    public class editNewUser : SetupSteps

    {

        public IWebDriver driver;

        public void openNewUser()
        {


            // settings
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[12]/a")).Click();
            // users
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[12]/ul/li[5]/a/span/span")).Click();

            // search for x user
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys("piparkuka");
            Thread.Sleep(300);

            // open any user
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/table/tbody/tr/td[6]/div/button")).Click();

            
        }

        public void editNewUserPage()
        {
            checkTitle = Generate.RandomString(4);

            // clear firstname
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[1]/div/input")).Clear();

            // type new edited firstname
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[1]/div/input")).SendKeys(checkTitle);

            // clear surname
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[2]/div/input")).Clear();

            // type new edited surname
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[2]/div/input")).SendKeys("new Alona");

            // delete language
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[4]/div/div/div/span/a/i")).Click();

            // click on def.langauge
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[4]/div/div/div/span")).Click();

            // select def.langauge
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[4]/div/div/ul/li/div[3]/a/small")).Click();

        }

        public void editNewUserPicture()
        {
            // click upload image
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[12]/div/button")).Click();

            // click upload image again
            find(By.XPath("/html/body/div[3]/div/div/form/div[1]/div/i")).Click();

            // path to image
            SendKeys.SendWait(@"C:\Users\Pjotrs\Downloads\download.jpg");
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(1000);

            //find(By.XPath("html/body/div[2]")).SendKeys("C:\\Users\\Pjotrs\\Downloads\\download.jpg");
            //Thread.Sleep(1000);
            // press save
            find(By.XPath("/html/body/div[3]/div/div/form/div[3]/button[1]")).Click();
            Thread.Sleep(1000);

        }

        public void clickSaveChanges()
        {

            // click save changes
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[15]/div/button[1]")).Click();
            Thread.Sleep(1000);

        }

        public void checkEditedUser()
        {
            // click settings
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[12]/a/span[1]/span")).Click();
            Thread.Sleep(1000);

            // click Users
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[12]/ul/li[5]/a")).Click();
            Thread.Sleep(1000);

            // click search
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle);
            Thread.Sleep(1000);

            // validation
            string test = find(By.XPath(".//*[@id='DataTables_Table_0']/tbody/tr/td[2]")).Text;
             Assert.IsTrue(test.Equals(checkTitle));
            

        }


       
    }
}

          


