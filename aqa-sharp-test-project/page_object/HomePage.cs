using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace aqa_sharp_test_project.page_object
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input#email")]
        private IWebElement emailInput;

        [FindsBy(How = How.CssSelector, Using = "input#pass")]
        private IWebElement passwordInput;

        [FindsBy(How = How.CssSelector, Using = "label#loginbutton > input")]
        private IWebElement loginButton;

        public IWebElement GetEmailInput()
        {
            return emailInput;
        }

        public IWebElement GetPasswordInput()
        {
            return passwordInput;
        }

        public IWebElement GetLoginButton()
        {
            return loginButton;
        }

        public HomePage InputEmail(string email)
        {
            emailInput.SendKeys(email);
            return new HomePage(GetDriver());
        }

        public HomePage InputPassword(string password)
        {
            passwordInput.SendKeys(password);
            return new HomePage(GetDriver());
        }

        public ProfilePage ClickLoginButton()
        {
            loginButton.Click();
            return new ProfilePage(GetDriver());
        }
    }
}
