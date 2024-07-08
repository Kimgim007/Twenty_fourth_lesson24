using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
namespace Twenty_fourth_lesson24.WebDriver
{
    internal class Driver
    {
        private static IWebDriver? driver;
        private static WebDriverWait? wait;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }
        public static WebDriverWait SetDriver(IWebDriver driver, double time)
        {
            if (wait == null)
            {
                wait = new WebDriverWait(driver,TimeSpan.FromSeconds(time));
            }
            return wait;
        }

        public static void TeareDown()
        {
            driver.Quit();
            driver = null;
            wait = null;
        }
    }
}
