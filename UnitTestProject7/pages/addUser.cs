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
    public class registerNewUser : SetupSteps

    {

        public IWebDriver driver;
        public static string emailSuperAdmin = "superadminqwert@email12.com";
        public static string emailClientRepresentataive = "clientRPqwe@email12.com";
        public static string emailUserManager = "usermanager12121qwe@email12.com";
        public static string emailAccountManager = "accountmanagerqe@email12.com";
        public static string emailAccountant = "accountantqe@emai1l2.com";
        public static string emailClientAdmin = "clientadminqe@emai2l1.com";
        public static string emailReseller = "reselleqer@email12.com";




        public void openNewUserPage()
        {
            // click settings
            find(By.XPath("/html/body/div/div/div[1]/nav/div/ul/li[12]/a/span[1]/span")).Click();

            // click Users
            find(By.Id("settingsUsers")).Click();

        }

        public void registerNewUserButton()
        {
            Thread.Sleep(3000);

            // click Register new user
            find(By.Id("regUserBtn")).Click();
        }

        public void registerUserManager()
        {
            Thread.Sleep(3000);

      

            // fill email data
            find(By.Name("Email")).Clear();

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[1]/input")).SendKeys(emailUserManager);

            // select role UserManager
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/div/span/span[1]")).Click(); // open drop down

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/ul/li/div[3]/a/div")).Click(); // select UserManager

            // click Register
            find(By.Id("registerBtn")).Click();


        }

        public void registerAccountManager()
        {

            Thread.Sleep(3000);
            find(By.Name("Email")).Clear();

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[1]/input")).SendKeys(emailAccountManager);

            // select role UserManager
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/div/span/span[1]")).Click(); // open drop down

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/ul/li/div[4]/a/div")).Click(); // select UserManager

            // legal entity
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[3]/div/div/span/span[1]")).Click(); // open drop-down

            // select legal entity
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[3]/div/ul/li/div[3]/a/div")).Click(); // legal entity set as BVBA

            // click Register
            find(By.Id("registerBtn")).Click();

            Thread.Sleep(3000);

        }

        public void registerAccountant()
        {

            Thread.Sleep(3000);

            // fill email data
            find(By.Name("Email")).Clear();

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[1]/input")).SendKeys(emailAccountant);

            // select role Accountant
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/div/span/span[1]")).Click(); // open drop down

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/ul/li/div[5]/a/div")).Click(); // select Accountatn

            // click Register
            find(By.Id("registerBtn")).Click();

            Thread.Sleep(3000);

        }

        public void registerSuperAdmin()
        {

            Thread.Sleep(3000);
            // fill email data
            find(By.Name("Email")).Clear();

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[1]/input")).SendKeys(emailSuperAdmin);

            // select role SuperAdmin
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/div/span/span[1]")).Click(); // open drop down

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/ul/li/div[6]/a/div")).Click(); // select SuperAdmin

            // click Register
            find(By.Id("registerBtn")).Click();

            Thread.Sleep(3000);

        }

        public void registerClientRepsentative()
        {

            Thread.Sleep(3000);

            // fill email data
            find(By.Name("Email")).Clear();

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[1]/input")).SendKeys(emailClientRepresentataive);

            // select role CR
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/div/span/span[1]")).Click(); // open drop down
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/ul/li/div[7]/a/div")).Click(); // select CR

            // legal entity
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[4]/div/div/span/span[1]")).Click(); // open drop-down

            // select legal entity
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[4]/div/ul/li/div[3]/a/div")).Click(); // legal entity set as EPTRON

            // click Register
            find(By.Id("registerBtn")).Click();

            Thread.Sleep(3000);

        }

        public void registerClientAdmin()
        {

            Thread.Sleep(3000);

            // fill email data
            find(By.Name("Email")).Clear();

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[1]/input")).SendKeys(emailClientAdmin);

            // select role ClientAdmin
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/div/span/span[1]")).Click(); // open drop down
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/ul/li/div[8]/a/div")).Click(); // select ClientAdmin

            // legal entity
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[4]/div/div/span/span[1]")).Click(); // open drop-down

            // select legal entity
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[4]/div/ul/li/div[3]/a/div")).Click(); // legal entity set as EPTRON

            // click Register
            find(By.Id("registerBtn")).Click();

            Thread.Sleep(3000);

        }

        public void registerReseller()
        {

            Thread.Sleep(3000);

            // fill email data
            find(By.Name("Email")).Clear();

            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[1]/input")).SendKeys(emailReseller);

            // select role Reseller
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/div/span/span[1]")).Click(); // open drop down
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[2]/div/ul/li/div[9]/a/div")).Click(); // select Reseller

            // legal entity
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[3]/div/div/span/span[1]")).Click(); // open drop-down

            // select legal entity
            find(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/form/div[3]/div/ul/li/div[4]/a/div")).Click(); // legal entity set as BVBA

            // click Register
            find(By.Id("registerBtn")).Click();

            Thread.Sleep(3000);

        }

        public void checkUserIsRegistered(string email)
        {

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(emailUserManager);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).Clear(); ;
            Thread.Sleep(100);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(emailAccountant);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).Clear(); ;
            Thread.Sleep(100);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(emailClientAdmin);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).Clear(); ;
            Thread.Sleep(100);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(emailClientRepresentataive);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).Clear(); ;
            Thread.Sleep(100);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(emailReseller);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).Clear(); ;
            Thread.Sleep(100);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(emailSuperAdmin);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).Clear(); ;
            Thread.Sleep(100);

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(emailAccountManager);

            


        }
    }
}
