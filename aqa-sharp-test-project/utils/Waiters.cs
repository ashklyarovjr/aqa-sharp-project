using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqa_sharp_test_project.utils
{
    public class Waiters
    {
        public static void WaitForElementDisplayed(IWebDriver driver, IWebElement element, int timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until<IWebElement>(func => {
                if (!element.Displayed)
                    return null;
                return element;
            });
        }
    }
}
