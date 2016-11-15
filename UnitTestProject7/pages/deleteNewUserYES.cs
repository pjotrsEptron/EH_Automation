using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EveryHairTestScripts.utils;
using static EveryHairTestScripts.utils.Find;
using OpenQA.Selenium;

namespace EveryHairTestScripts
{
    public class deleteNewUserYES : SetupSteps

    {

        public IWebDriver driver;

        private string checkDeletedUser;
        
        public void clickDeleteButton()
        {

            checkDeletedUser = find(By.Name("user.FirstName")).Text;
            Thread.Sleep(3000);


          
            // click delete button
            find(By.XPath(".//*[@id='page-wrapper']/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[15]/div/button[4]")).Click();
            Thread.Sleep(1000);
        }

        public void clicDeleteButtonYES()
        {
            
            // click anywhere
            find(By.XPath("html/body/div[3]/div/div/div/div[1]")).Click(); // drop coursor
            Thread.Sleep(1000);

            // click YES
            find(By.XPath("html/body/div[3]/div/div/div/div[2]/button[1]")).Click();
            Thread.Sleep(5000);
        }

        public void checkThatUserDeleted()

        {
                        Thread.Sleep(5000);

            // check that user is deleted
            find(By.XPath("html/body/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div/label/input")).SendKeys(checkDeletedUser);
            Thread.Sleep(1000);

        }
    }
}
