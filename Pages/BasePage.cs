using OpenQA.Selenium;
using SauceDemo.Helper;

namespace SauceDemo.Pages
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver) 
        { 
           Driver = driver;
        }
        public void OpenPageByUrl()
        { 
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);
        }
      
        
    }
}
