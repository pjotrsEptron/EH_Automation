using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EveryHairTestScripts.config;

namespace EveryHairTestScripts.utils
{
    class Find
    {
        public static IList<IWebElement> finds(By by)
        {
            return Driver.getDriver().FindElements(by);
        }
        public static IWebElement find(By by)
        {
            return Driver.getDriver().FindElement(by);

        }
    }


}
