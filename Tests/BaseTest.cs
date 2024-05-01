using OpenQA.Selenium;
using SauceDemo.Core;
using Allure.NUnit;
using OpenQA.Selenium.Interactions;
using Allure.Net.Commons;

namespace SauceDemo.Tests
{
    [AllureNUnit]
    public class BaseTest
    {
        [OneTimeSetUp]
        public void GlobalSetup()
        {
           // AllureLifecycle.Instance.CleanupResultDirectory();
        }
        public IWebDriver? Driver { get; set; }

        [SetUp]
        public void SetUp()
        {
            Driver = new Browser().Driver;
            //  Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().UrlSecond);
           
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
   
    }

}

