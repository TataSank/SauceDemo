using OpenQA.Selenium;

namespace SauceDemo.Pages
{
    public class UploadFilePage : BasePage
    {
        private static readonly By InputBtnBy = By.XPath("//button[text()='Choose']");
        private static readonly By ResetBtnBy = By.XPath("//button[text()='Reset']");
        public UploadFilePage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        protected new IWebDriver Driver { get; set; }
        public IWebElement InputBtn() => Driver.FindElement(InputBtnBy);
        public IWebElement ResetBtn() => Driver.FindElement(ResetBtnBy);
    }
}
