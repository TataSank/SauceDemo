using OpenQA.Selenium;

namespace SauceDemo.Pages
{
    public class WindowsPage : BasePage
    {
        private static readonly By OpenNewWindowBtnBy = By.LinkText("Click Here");
        public WindowsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        protected new IWebDriver Driver { get; set; }
        public IWebElement OpenNewWindowBtn() => Driver.FindElement(OpenNewWindowBtnBy);
    }
}
