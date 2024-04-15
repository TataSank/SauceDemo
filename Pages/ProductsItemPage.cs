using OpenQA.Selenium;


namespace SauceDemo.Pages
{
    public class ProductsItemPage:BasePage
    {
        private readonly By ProducItemFirstBy = By.CssSelector(".inventory_details_name.large_size");
        public ProductsItemPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        protected new IWebDriver Driver { get; set; }
        public IWebElement ProductItemFirstBy() => Driver.FindElement(ProducItemFirstBy);

    }
}
