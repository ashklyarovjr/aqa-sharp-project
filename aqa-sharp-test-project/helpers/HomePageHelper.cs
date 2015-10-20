using aqa_sharp_test_project.page_object;
using aqa_sharp_test_project.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqa_sharp_test_project.helpers
{
    class HomePageHelper : BaseHelper
    {
        private HomePage loginPage;

        public HomePageHelper(IWebDriver driver) : base(driver)
        {
            loginPage = new HomePage(driver);
        }

        public HomePageHelper GoToFB()
        {
            string url = ConfigurationManager.AppSettings["fbUrl"];
            Utils.GoToUrl(driver, url);
            return new HomePageHelper(driver);
        }

        public ProfilePageHelper LoginToFB(string email, string password)
        {
            Waiters.WaitForElementDisplayed(driver, loginPage.GetEmailInput(), 3);
            loginPage.InputEmail(email);
            Waiters.WaitForElementDisplayed(driver, loginPage.GetPasswordInput(), 3);
            loginPage.InputPassword(password);
            Waiters.WaitForElementDisplayed(driver, loginPage.GetLoginButton(), 3);
            loginPage.ClickLoginButton();
            return new ProfilePageHelper(driver);
        }

        public ErrorLoginPageHelper WrongLoginToFB(string email, string password)
        {
            Waiters.WaitForElementDisplayed(driver, loginPage.GetEmailInput(), 3);
            loginPage.InputEmail(email);
            Waiters.WaitForElementDisplayed(driver, loginPage.GetPasswordInput(), 3);
            loginPage.InputPassword(password);
            Waiters.WaitForElementDisplayed(driver, loginPage.GetLoginButton(), 3);
            loginPage.ClickLoginButton();
            return new ErrorLoginPageHelper(driver);
        }

        
    }
}
