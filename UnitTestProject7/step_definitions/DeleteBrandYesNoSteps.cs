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
    public class DeleteBrandsYesNoSteps : SetupSteps
    {

        IWebDriver driver = Driver.getDriver();
        deleteBrandNo delBrand = new deleteBrandNo();



        [Given(@"i open this brand")]
        public void GivenIOpenThisBrand()
        {
            delBrand.openBrandForDelete();

        }
        
        [Given(@"then i click Delete button")]
        public void GivenThenIClickDeleteButton()
        {
            delBrand.pressDelBrand();
        }

        [Then(@"i click No")]
        public void ThenIClickNo()
        {
            delBrand.pressDelBrandNo();

        }


        [Given(@"i can click delete brand")]
        public void GivenICanClickDeleteBrand()
        {
            delBrand.pressDelBrand();
        }
        
       
        
        [Then(@"i click Yes and check brand in search")]
        public void ThenIClickYesAndCheckBrandInSearch()
        {
            delBrand.pressDelbrandYes();
            delBrand.checkBrandDeleted();
        }
    }
}
