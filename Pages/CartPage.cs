using OpenQA.Selenium;

namespace SauceDemo.Pages
{
    internal class CartPage:BasePage
    {
        private readonly By TitleProductBy = By.PartialLinkText("Sauce Labs");
        private readonly By GoBackBtnBy = By.Name("continue-shopping");
        private readonly By CheckoutBtnBy = By.CssSelector(".checkout_button");

        public CartPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        protected new IWebDriver Driver { get; set; }

        public IWebElement TitleProduct() => Driver.FindElement(TitleProductBy);
        public IWebElement GoBack() => Driver.FindElement(GoBackBtnBy);
        public IWebElement CheckoutBtn() => Driver.FindElement(CheckoutBtnBy);
    }
}
