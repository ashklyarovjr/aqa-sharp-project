using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqa_sharp_test_project.page_object
{
    class ErrorLoginPage : BasePage
    {
        public ErrorLoginPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div[class~='login_error_box']")]
        private IWebElement loginErrorMessage;

        public IWebElement GetLoginErrorMessage()
        {
            return loginErrorMessage;
        }
    }


}
