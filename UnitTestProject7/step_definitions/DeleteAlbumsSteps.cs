using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using TechTalk.SpecFlow;
using EveryHairTestScripts.config;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;

namespace EveryHairTestScripts
{
    [Binding]
    public class DeleteAlbumsSteps : SetupSteps
    {
        IWebDriver driver = Driver.getDriver();

        [Given(@"albums list")]
        public void GivenAlbumsList()
        {

            deleteAlbums checkAlbumList = new deleteAlbums();
            checkAlbumList.goBackToAlbumsList();

            //deleteAlbumsfindAlbum = new deleteAlbums();
            //driver.FindElementAlbum.driver.FindElementAlbums();
           
        }

        [When(@"i press delete button")]
        public void WhenIPressDeleteButton()
        {

            deleteAlbums pressDeleteButton = new deleteAlbums();
            pressDeleteButton.pressDeleteInAlbums();

        }



        [When(@"i click NO")]
        public void WhenIClickNO()
        {

            deleteAlbums pressNoButton = new deleteAlbums();
            pressNoButton.pressNo();


        }


        [Then(@"album not deleted")]
        public void ThenAlbumNotDeleted()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle); // add album name in search field
            

        }


        [Given(@"albums list of albums")]
        public void GivenAlbumsListOfAlbums()
        {


            Thread.Sleep(3000);
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).Clear(); ; // add album name in search field
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle); // add album name in search field


        }

        [When(@"i press delete button from list")]
        public void WhenIPressDeleteButtonFromList()
        {
            Thread.Sleep(3000);

            deleteAlbums pressDeleteButton = new deleteAlbums();
            pressDeleteButton.pressDeleteInAlbums();
        }

        
        [When(@"i click YES")]
        public void WhenIClickYES()
        {


            deleteAlbums pressdeletebuttonYes = new deleteAlbums();
            pressdeletebuttonYes.pressYes();
        }
        
       
        
        [Then(@"album is deleted")]
        public void ThenAlbumIsDeleted()
        {
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[3]/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkTitle); // add album name in search field


        }
        private bool IsElementPresent(By by)
        {
            try
            {
              find(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
    }
}
