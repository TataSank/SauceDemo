using OpenQA.Selenium;


namespace SauceDemo.Pages
{
    public class CheckoutPage:BasePage
    {
        private readonly By CheckoutPageTitleBy = By.XPath("//span[@data-test='title']");

        public CheckoutPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        protected new IWebDriver Driver { get; set; }

        public IWebElement CheckoutPageTitle() => Driver.FindElement(CheckoutPageTitleBy);
    }
}
