using OpenQA.Selenium;
using SauceDemo.Core;
using Allure.NUnit;
using OpenQA.Selenium.Interactions;

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
            //  Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().UrlSecond);
           
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
   
    }

}

