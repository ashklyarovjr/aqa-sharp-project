using aqa_sharp_test_project.page_object;
using aqa_sharp_test_project.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqa_sharp_test_project.helpers
{
    class ErrorLoginPageHelper : BaseHelper
    {
        private ErrorLoginPage errorLoginPage;

        public ErrorLoginPageHelper(IWebDriver driver) : base(driver)
        {
            errorLoginPage = new ErrorLoginPage(driver);
        }

        public bool LoginErrorMessageIsDisplayed()
        {
            IWebElement message = errorLoginPage.GetLoginErrorMessage();
            Waiters.WaitForElementDisplayed(driver, message, 5);
            return message.Displayed;
        }
    }
}
