
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqa_sharp_test_project.page_object
{
    abstract class BasePage
    {
        private IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver GetDriver()
        {
            if(driver != null)
                return driver;
            else
                throw new WebDriverException("Driver is not instantiated yet");
        } 

    }
}
