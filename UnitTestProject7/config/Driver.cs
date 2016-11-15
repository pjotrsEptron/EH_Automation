using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryHairTestScripts.config
{
    class Driver
    {

    public static IWebDriver driver;

        public static IWebDriver init()
        {
            driver = new FirefoxDriver();
            return driver;

        }

        public static IWebDriver init(string Url)
        {
            driver = new FirefoxDriver();
            driver.Url = Url;
            return driver;
        }

        public static IWebDriver getDriver()
        {
            return driver;
        } 
    }
}
