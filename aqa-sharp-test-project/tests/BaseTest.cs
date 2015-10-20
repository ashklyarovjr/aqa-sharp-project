using aqa_sharp_test_project.factory;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqa_sharp_test_project.tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        private static DriverFactory factory = new DriverFactory();

        [SetUp]
        public void SetUp()
        {
            driver = factory.GetDriverInstance();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
