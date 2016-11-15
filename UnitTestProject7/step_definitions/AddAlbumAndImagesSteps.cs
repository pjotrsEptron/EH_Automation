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
    public class AddAlbumAndImages : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();

        [Given(@"New Employee")]
        public void GivenNewEmployee()
        {
            find(By.XPath("//ul[@id='side-menu']/li[5]/a/span")).Click();
            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div[1]/div/a")).Click();
            //Check.presence(By.CssSelector("tab-heading.ng-scope"));

            // add details
            addEmployee addFieldsForEmploye = new addEmployee();
            addFieldsForEmploye.fillAndSubmitForm();
            Thread.Sleep(1000); // to be removed/changed to implicity

            // press save
            addEmployee saveButton = new addEmployee();
            saveButton.clickSaveButton(driver);
            Thread.Sleep(1000); // to be removed/changed to implicity

            // press activate
            addEmployee activateButton = new addEmployee();
            activateButton.clickActivateButton(driver);
            Thread.Sleep(5000);

        }

        [Then(@"i click album tab i can create album")]
        public void ThenIClickAlbumTabICanCreateAlbum()
        {
            albumsAdding createAlbumFillDetails = new albumsAdding();
            createAlbumFillDetails.createAlbum();


        }

        [When(@"album is created i can upload images and update")]
        public void WhenAlbumIsCreatedICanUploadImagesAndUpdate()
        {

            albumsAdding addImagesToAlbum = new albumsAdding();
            addImagesToAlbum.addImagesToAlbum();


        }



        [Then(@"i can save")]
        public void ThenICanSave()
        {


            albumsAdding saveChanges = new albumsAdding();
            saveChanges.clickSaveChangesButton();

        }

        [Given(@"previous album")]
        public void GivenPreviousAlbum()
        {
            WebDriverWait wait6 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait6.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/ul/li/a/tab-heading/span")));

        }

        [When(@"i click Add content to Album i can upload (.*) photo insdie")]
        public void WhenIClickAddContentToAlbumICanUploadPhotoInsdie(int p0)
        {


            albumsAdding addingOneImage = new albumsAdding();
            addingOneImage.addOneImage();

        }

        [Then(@"i can preview image")]
        public void ThenICanPreviewImage()
        {

            WebDriverWait wait7 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/ul/li/a/tab-heading/span")));


        }

        [Then(@"click save changes")]
        public void ThenClickSaveChanges()
        {
            // wait untill save become active
            WebDriverWait wait5 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait5.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[3]/div/div/form/div[3]/button[1]")));
            find(By.XPath("/html/body/div[3]/div/div/form/div[3]/button[1]")).Click();
        }

        [Given(@"previous page")]
        public void GivenPreviousPage()
        {
            WebDriverWait wait7 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/ul/li/a/tab-heading/span")));
        }

        [Then(@"i add images to album")]
        public void ThenIAddImagesToAlbum()
        {

            albumsAdding addTwoImagesInAlbum = new albumsAdding();
            addTwoImagesInAlbum.addTwoImage();

        }

        [Then(@"click save")]
        public void ThenClickSave()
        {

            WebDriverWait wait9 = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait9.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[1]")));

            find(By.XPath("/html/body/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/div/div/div/fieldset/form/div[3]/div[2]/div/button[1]")).Click();
        }
    }
}