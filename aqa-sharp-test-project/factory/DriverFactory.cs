using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;

namespace aqa_sharp_test_project.factory
{
    class DriverFactory
    {
        private static string driverType = ConfigurationManager.AppSettings["driver"];
        private IWebDriver driver;

        public IWebDriver GetDriverInstance()
        {
            if(driverType.Equals("firefox")) 
            {
                driver = new FirefoxDriver();
                SetImplicityWait(driver);
                return driver;
            } 
            else if(driverType.Equals("chrome"))
            {
                driver = new ChromeDriver();
                SetImplicityWait(driver);
                return driver;
            }
            else
            {
                throw new WebDriverException("The driver mentioned in app.config is not supported");
            }
        }

        private void SetImplicityWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
    }
}
