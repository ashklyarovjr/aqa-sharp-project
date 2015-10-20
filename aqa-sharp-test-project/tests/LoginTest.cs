using System;
using aqa_sharp_test_project.tests;
using NUnit.Framework;
using System.Configuration;
using aqa_sharp_test_project.helpers;
using aqa_sharp_test_project.utils;

namespace aqa_sharp_test_project
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        private string email;
        private string password;
        private HomePageHelper loginHelper;
        private ProfilePageHelper profileHelper;
        private ErrorLoginPageHelper errorLoginHelper;

        [SetUp]
        public void SetUpCredentials()
        {
            loginHelper = new HomePageHelper(driver);
            email = ConfigurationManager.AppSettings["login"];
            password = ConfigurationManager.AppSettings["password"];

        }

        [Test]
        public void LoginTestPositive()
        {
            profileHelper = loginHelper.GoToFB()
                                       .LoginToFB(email, password);
            Assert.AreEqual(profileHelper.GetWelcomeText(), StringsKeeper.username);
        }

        [Test]
        public void LoginTestNegative()
        {
            errorLoginHelper = loginHelper.GoToFB()
                                       .WrongLoginToFB(email, StringsKeeper.wrongPassword);
            Assert.IsTrue(errorLoginHelper.LoginErrorMessageIsDisplayed());
        }
    }
}
