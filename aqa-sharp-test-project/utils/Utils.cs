using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqa_sharp_test_project.utils
{
    public class Utils
    {
        public static void GoToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
