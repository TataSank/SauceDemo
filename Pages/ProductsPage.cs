using OpenQA.Selenium;



namespace SauceDemo.Pages
{
    internal class ProductsPage : BasePage
    {
        private static readonly By TitleBy = By.XPath("//div[@id='menu_button_container']//following::div[@class='app_logo']");
        private static readonly By ShoppingCartBy = By.ClassName("shopping_cart_link");
        private static readonly By ProductImgFirstBy = By.XPath("//div[@id='inventory_container']/descendant::div[@class='inventory_item_img'][1]");
        private static readonly By ProductItemLabelFirstBy = By.XPath("(//div[@class='pricebar'])[1]//ancestor::div[@class='inventory_item_description']//a");
        private static readonly By PriceItemFirsrBy = By.XPath("//div/button[@data-test = 'add-to-cart-sauce-labs-backpack']/parent::div/div");
        private static readonly By AddToCartBtnBy = By.XPath("(//div[@class='inventory_item_description'])[1]/child::div[@class='pricebar']/button");
        private static readonly By CountProductsBy = By.XPath("//div/a/span[contains(@data-test,'shopping')]");

        public ProductsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        protected new IWebDriver Driver { get; set; }

        public IWebElement Title() => Driver.FindElement(TitleBy);
        public IWebElement ShoppingCart() => Driver.FindElement(ShoppingCartBy);
        public IWebElement ProductImgFirst() => Driver.FindElement(ProductImgFirstBy);
        public IWebElement ProductItemLabelFirst() => Driver.FindElement(ProductItemLabelFirstBy);              
        public IWebElement AddTocartBtn() => Driver.FindElement(AddToCartBtnBy);
        public IWebElement CountProducts() => Driver.FindElement(CountProductsBy);
    }
}
