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

namespace EveryHairTestScripts
{
    [Binding]
    public class EditBrandSteps : SetupSteps
        
    {

        editBrand edBrand = new editBrand();

       
        
        [Given(@"i click open button to open brand")]
        public void GivenIClickOpenButtonToOpenBrand()
        {

            edBrand.openBrandForEdit();
        }
        
        [Then(@"i update name")]
        public void ThenIUpdateName()
        {
            edBrand.editBrandName();
        }
        
        [Then(@"go back to check name is edited")]
        public void ThenGoBackToCheckNameIsEdited()
        {
            edBrand.checkEditedBrandName();
        }
    }
}
