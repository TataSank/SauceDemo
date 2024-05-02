using OpenQA.Selenium;

namespace SauceDemo.Pages
{
    public class ActionsPage : BasePage
    {
        private static readonly By HotSpotBy = By.Id("hot-spot");
        public ActionsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        public IWebElement HotSpot() => Driver.FindElement(HotSpotBy);
    }
}
