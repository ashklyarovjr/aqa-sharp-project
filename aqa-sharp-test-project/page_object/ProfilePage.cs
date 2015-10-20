using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace aqa_sharp_test_project.page_object
{
    class ProfilePage : BasePage
    {
        public ProfilePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div#pagelet_welcome_box a.fbxWelcomeBoxName")]
        private IWebElement welcomeLink;

        public IWebElement GetWelcomeLink()
        {
            return welcomeLink;
        }
    }
}
