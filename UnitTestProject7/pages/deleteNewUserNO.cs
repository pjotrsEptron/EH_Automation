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
    public class deleteNewUserNO : SetupSteps

    {

        public IWebDriver driver;

             public void clickDeleteButton()
        {
            // click delete button
            find(By.XPath(".//*[@id='page-wrapper']/div[2]/div[2]/div/div/div/div[2]/fieldset/form/div[15]/div/button[4]")).Click();
            Thread.Sleep(3000);
        }

        public void clicDeleteButtonNO()
        {
            // click no
            find(By.XPath("html/body/div[3]/div/div/div/div[2]/button[2]")).Click();
            Thread.Sleep(3000);

        }
    }
}
