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
    class ProfilePageHelper
    {
        private ProfilePage profilePage;
        private IWebDriver driver;

        public ProfilePageHelper(IWebDriver driver)
        {
            this.driver = driver;
            profilePage = new ProfilePage(driver);
        }

        public string GetWelcomeText()
        {
            Waiters.WaitForElementDisplayed(driver, profilePage.GetWelcomeLink(), 5);
            string text = profilePage.GetWelcomeLink().Text;
            return text;
        }


    }
}
