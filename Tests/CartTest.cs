using SauceDemo.Helper;
using SauceDemo.Pages;

namespace SauceDemo.Tests
{
    internal class CartTest : BaseTest
    {
        private LoginPage LoginPage;
        private ProductsPage ProductPage;

        [SetUp]
        public void Setup()
        {
            LoginPage = new LoginPage(Driver);
            ProductPage = new ProductsPage(Driver);
        }
        [Test]
        public void BackToProducts()
        {
            var CartPage = new CartPage(Driver);

            LoginPage.Login(Configurator.ReadConfiguration().UserStandardName, Configurator.ReadConfiguration().UserPassword);
            ProductPage.ShoppingCart().Click();
            CartPage.GoBack().Click();

            Assert.That(ProductPage.AddTocartBtn().Displayed);
        }
        [Test]
        public void GoToCheckout()
        {
            var CartPage = new CartPage(Driver);
            var CheckoutPage = new CheckoutPage(Driver);

            LoginPage.Login(Configurator.ReadConfiguration().UserStandardName, Configurator.ReadConfiguration().UserPassword);
            ProductPage.ShoppingCart().Click();
            CartPage.CheckoutBtn().Click();

            Assert.That(CheckoutPage.CheckoutPageTitle().Displayed);
        }
    }
}
