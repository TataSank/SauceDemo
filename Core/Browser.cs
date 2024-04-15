using OpenQA.Selenium;
using SauceDemo.Helper;

namespace SauceDemo.Core
{

    public class Browser
    {
        public IWebDriver Driver;
        public Browser()
        {
            Driver = Configurator.ReadConfiguration().BrowserType.ToLower() switch
            {
                "chrome" => new DriverFactory().GetChromeDriver(),
                "firefox" => new DriverFactory().GetFirefoxDriver(),
                _=> throw new Exception("This browser is not supported")
            };

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Configurator.ReadConfiguration().TimeOut);
            Driver.Manage().Window.Maximize();
        }
    }
}
