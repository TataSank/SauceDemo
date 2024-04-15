using OpenQA.Selenium;
using SauceDemo.Core;
using SauceDemo.Helper;
using Allure.NUnit;

namespace SauceDemo.Tests
{
    [AllureNUnit]
    public class BaseTest
    {
        public IWebDriver? Driver { get; set; }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }

}

